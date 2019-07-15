using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Globalization;

namespace Pizza
{
    public partial class MainForm : Form
    {
        #region Properties

        private List<Order> _ordersLst = new List<Order>();
        private Order _lastOrder = new Order();
        private List<OrderControl> _orderCrtlLst = new List<OrderControl>();
        private bool _dataHasChanged = false;
        private bool _firstStart = true;       

        private List<Order> OrdersLst
        {
            get => _ordersLst;
            set => _ordersLst = value;
        }

        private List<OrderControl> OrderCrtlLst
        {
            get => _orderCrtlLst;
            set => _orderCrtlLst = value;
        }

        private Order LastOrder
        {
            get => _lastOrder;
            set => _lastOrder = value;
        }

        public bool DataHasChanged
        {
            get => _dataHasChanged;
            set 
            {
                if (value)
                {
                    buttonSave.Enabled = true;
                }
                else
                {
                    buttonSave.Enabled = false;
                }

                _dataHasChanged = value;
            }
        }

        public bool FirstStart
        {
            get => _firstStart;
            set => _firstStart = value;
        }

        #endregion

        #region Constants

        private const int MainFormHeightOffset = 110;
        private const string XmlFilePath = ".\\orders.xml";

        #endregion

        #region Methods

        public MainForm()
        {
            InitializeComponent();
            this.Shown += new System.EventHandler(this.MainForm_Shown);
        }

        void SerializeOrdersXml()
        {
            XmlSerializer serializer;
            FileStream fileStream;

            serializer = new XmlSerializer(typeof(List<Order>));
            fileStream = new FileStream(XmlFilePath, FileMode.Create);
            serializer.Serialize(fileStream, OrdersLst);
            fileStream.Close();
            DataHasChanged = false;
        }

        void DeserializeOrdersXml()
        {
            string filePath = ".\\orders.xml";
            FileStream fileStream = null;
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Order>));
            DialogResult dialogSelectFile;
            DialogResult dialogNewXmlFile;

            // Try to read the contents of the XML file into a fileStream.
            // If the XML file could not be found, open a file dialog to select it manually.
            // If no valid file has been selected or the operation is canceled by the user
            // exit the application.
            try
            {
                fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            }
            catch (FileNotFoundException)
            {
                dialogSelectFile = MessageBox.Show("Die Bestelldaten (orders.xml) konnten nicht" +
                    " gefunden werden. Datei manuell auswählen?", "Warnung", MessageBoxButtons.YesNo);

                if (dialogSelectFile == DialogResult.Yes)
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = @".\";
                        openFileDialog.Filter = "|*.xml";
                        openFileDialog.FilterIndex = 1;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Get the path of specified file
                            filePath = openFileDialog.FileName;

                            // Read the contents of the file into a fileStream
                            fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                        }
                    }
                }
                else
                {
                    // Generate a new XML file?
                    dialogNewXmlFile = MessageBox.Show("Soll eine neue Datei für Bestelldaten erzeugt werden?"
                        + Environment.NewLine + Environment.NewLine + "Nein - beendet das Programm",
                        "Warnung", MessageBoxButtons.YesNo);

                    if (dialogNewXmlFile == DialogResult.No)
                    {
                        Application.Exit();
                        return;
                    }
                    else
                    {
                        OrdersLst.Add(new Order());
                        SetLastOrder();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unbekannter Fehler - Anwendung kann nicht ausgeführt werden!" + ex,
                    "Fehler", MessageBoxButtons.OK);
                Application.Exit();
                return;
            }

            if (fileStream == null)
            {
                return;
            }

            // Deserialize the data stream of the previously loaded XML file.
            // If the operation fails an error message will be shown
            try
            {
                OrdersLst = (List<Order>)deserializer.Deserialize(fileStream);
                fileStream.Close();
            }
            catch (InvalidOperationException ex)
            {
                string exceptionMsg = ex.Message;

                if (ex.InnerException.Message != null)
                {
                    exceptionMsg = exceptionMsg + "InnerException: " + ex;
                }

                DialogResult dialogResultXmlDeserializeException = MessageBox.Show(exceptionMsg,
                    "Fehler", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                // ???
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                }
            }

            SetLastOrder();
        }

        private void SetLastOrder()
        {
            if (OrdersLst.Any())
            {
                LastOrder = OrdersLst.OrderBy(x => x.OrderTimestamp).Last() as Order;
            }
        }

        // Add all orders (loaded from the XML file) to the combo box
        void InitComboBoxOrders()
        {
            List<DateTime> lst = new List<DateTime>();
            
            foreach(Order order in OrdersLst)
            {
                lst.Add(order.OrderTimestamp/*.ToString("yyyy-MM-ddThh:mm:ss", DateTimeFormatInfo.InvariantInfo)*/);
            }

            lst.OrderBy(x => x.Year).ThenBy(x => x.Month).ThenBy(x => x.Day).ThenBy(x => x.TimeOfDay); // sort list
            comboBoxOrders.SelectedIndexChanged -= ComboBoxOrders_SelectedIndexChanged; // temporarily disable EventHandler

            foreach(DateTime dateTime in lst)
            {
                comboBoxOrders.Items.Add(dateTime.ToString());
            }

            
            if(comboBoxOrders.Items.Count > 0)
            {
                comboBoxOrders.SelectedIndex = comboBoxOrders.Items.Count - 1; // set last order as active
            }

            comboBoxOrders.SelectedIndexChanged += ComboBoxOrders_SelectedIndexChanged;
        }

        // Create a new order table with a given order.
        void NewOrderTable(Order order)
        {
            var i = 0;
            var oldOrderCrtlCnt = 0;

            if (order.OrderPropsLst.Any())
            {
                // Disable MainForm layout logic while changing controls for better visuals.
                this.SuspendLayout();
                oldOrderCrtlCnt = CleanOrderPanel();

                // Add new control for each customer of the last order
                foreach (OrderProps orderProps in order.OrderPropsLst)
                {
                    OrderControl orderControl = new OrderControl(orderProps);
                    OrderCrtlLst.Add(orderControl);
                }

                // Sort list by CustomerName
                OrderCrtlLst.Sort((x, y) => x.OrderProps.CustomerName.CompareTo(y.OrderProps.CustomerName));

                foreach (OrderControl orderControl in OrderCrtlLst)
                {
                    panelOrder.Controls.Add(orderControl);
                    orderControl.Location = new Point(1, i == 0 ? 0 : i * orderControl.Height);
                    orderControl.OrderControlChanged += OrderControl_ControlValueChanged;
                    orderControl.OrderControlToBeRemoved += OrderControl_ControlToBeRemoved;
                    orderControl.OrderControlOrderClosed += OrderControl_OrderControlOrderClosed;
                    orderControl.CalcControlSums();
                    i++;
                }
            }

            // Add special customerControl for adding a new customer
            OrderControl orderControlNewCustomer = new OrderControl("NewCustomer");
            OrderCrtlLst.Add(orderControlNewCustomer);
            panelOrder.Controls.Add(orderControlNewCustomer);
            orderControlNewCustomer.Location = new Point(1, i == 0 ? 0 : i * orderControlNewCustomer.Height);
            orderControlNewCustomer.OrderControlNewCustomer += OrderControl_OrderControlNewCustomer;

            // Disable control(s) if an order has been submitted (not the last one which is the special
            // control for adding a new customer) or if there is no article to order.
            bool[] tmp = new bool[OrderCrtlLst.Count - 1];

            for (int j = 0; j < OrderCrtlLst.Count - 1; j ++)
            {
                if (OrderCrtlLst[j].OrderProps.Articles.Equals(string.Empty) || OrderCrtlLst[j].OrderProps.Ordered)
                {
                    OrderCrtlLst[j].OrderControlDisable();
                    tmp[j] = true;
                }    
            }

            // order has been submitted
            if (OrdersLst[GetActiveOrderIndex()].OrderClosed)
            {
                OrderCrtlLst.Last().Enabled = false;
                buttonCloseOrder.Enabled = false;

                foreach (OrderControl orderControl in OrderCrtlLst)
                {
                    orderControl.Enabled = false;
                }
            }
            else
            {
                if (tmp.All(x => x))
                {
                    buttonCloseOrder.Enabled = true;
                }
                else
                {
                    buttonCloseOrder.Enabled = false;
                }
            }

            // Disable close order button if it's a new blank order without any customers
            if (OrderCrtlLst.Count() <2)
            {
                buttonCloseOrder.Enabled = false;
            }

            // Re-enable MainForm layout logic.
            this.ResumeLayout();

            // Resize and position MainForm
            this.Size = new System.Drawing.Size(this.Width, groupBoxOrderManagement.Height
                + panelOrder.Height + panelOrderSums.Height + MainFormHeightOffset);
            
            if (oldOrderCrtlCnt < i)
            {
                this.CenterToScreen();
            }

            CalculateStatisticsForNerds();
            CalculateOrderSums();
            SerializeOrdersXml();
        }

        // Remove all controls from the panel an the OrderCrtlLst.
        private int CleanOrderPanel()
        {
            int i = 0;
            
            while (OrderCrtlLst.Count > 0)
            {
                panelOrder.Controls.Remove(OrderCrtlLst[0]);
                OrderCrtlLst[0].OrderControlChanged -= OrderControl_ControlValueChanged;
                OrderCrtlLst[0].OrderControlToBeRemoved -= OrderControl_ControlToBeRemoved;
                OrderCrtlLst[0].OrderControlNewCustomer -= OrderControl_OrderControlNewCustomer;
                OrderCrtlLst[0].Dispose();
                OrderCrtlLst.Remove(OrderCrtlLst[0]);
                i++;
            }
            return i;
        }

        private void NewCustomer(string newCustomerName)
        {
            OrderProps newOrderProps = new OrderProps(newCustomerName);
            OrderControl newOrderControl = new OrderControl(newOrderProps);

            // Add new customer to active order data structure
            OrdersLst[GetActiveOrderIndex()].OrderPropsLst.Add(newOrderProps);

            // Generate new order table
            NewOrderTable(OrdersLst[GetActiveOrderIndex()]);
        }

        private void CalculateStatisticsForNerds()
        {
            int     totalOrders = 0;
            decimal totalOrdersPrice = 0;
            decimal totalOrdersTip = 0;
            int     totalArticles = 0;
            int     totalPizzas = 0;
            int     totalSalads = 0;
            int     totalunknown = 0;
            decimal averageOrdersPrice = 0;
            decimal averageOrdersTip = 0;
            decimal maxSingleTip = 0;
            decimal shareOfPizza = 0;
            decimal shareOfSalad = 0;
            decimal shareOfUnknown = 0;

            totalOrders = OrdersLst.Count();

            if (totalOrders > 0)
            {
                foreach (Order order in OrdersLst)
                {
                    foreach (OrderProps orderProps in order.OrderPropsLst)
                    {
                        totalOrdersPrice += orderProps.Price;
                        totalOrdersTip += orderProps.Tip;

                        if (orderProps.Tip > maxSingleTip)
                        {
                            maxSingleTip = orderProps.Tip;
                        }

                        if (!orderProps.Articles.Equals(String.Empty))
                        {
                            totalArticles++;

                            if (orderProps.Articles.Contains("Pizza") || orderProps.Articles.Contains("Mittags"))
                            {
                                totalPizzas++;
                            }
                            else if (orderProps.Articles.Contains("Salat"))
                            {
                                totalSalads++;
                            }
                            else
                            {
                                totalunknown++;
                            }
                        }

                    }
                }

                averageOrdersPrice = totalOrdersPrice / totalOrders;
                averageOrdersTip = totalOrdersTip / totalOrders;
                shareOfPizza = (totalPizzas * 100.0m) / totalArticles;
                shareOfSalad = (totalSalads  * 100.0m) / totalArticles;
                shareOfUnknown = (totalunknown * 100.0m) / totalArticles;

                labelTotalNumberOfOrders.Text = OrdersLst.Count().ToString("D");
                labelTotalOrdersPrice.Text = totalOrdersPrice.ToString("N2") + " €";
                labelAverageOrdersPrice.Text = averageOrdersPrice.ToString("N2") + " €";
                labelMaxTip.Text = maxSingleTip.ToString("N2") + " €";
                labelTotalOrdersTip.Text = totalOrdersTip.ToString("N2") + " €";
                labelAverageOrdersTip.Text = averageOrdersTip.ToString("N2") + " €";
                labelShareOfPizza.Text = shareOfPizza.ToString("N2") + " %";
                labelShareOfSalad.Text = shareOfSalad.ToString("N2") + " %";
                labelShareOfUnknown.Text = shareOfUnknown.ToString("N2") + " %";
            }
        }

        private void CalculateOrderSums()
        {
            int orderIdx = GetActiveOrderIndex();
            decimal totalPrice = 0;
            decimal totalTip = 0;
            decimal totalPriceWithDiscount = 0;
            decimal totalPricePayed = 0;

            if (orderIdx >= 0)
            {
                foreach (OrderProps orderProps in OrdersLst[orderIdx].OrderPropsLst)
                {
                    totalPrice += orderProps.Price;
                    totalTip += orderProps.Tip;
                    totalPriceWithDiscount += orderProps.PriceWithDiscount;
                    totalPricePayed += orderProps.PricePayed;
                }

                labelTotalPrice.Text = totalPrice.ToString("N2") + " €";
                labelTotalTip.Text = totalTip.ToString("N2") + " €";
                labelTotalPriceWithDiscount.Text = totalPriceWithDiscount.ToString("N2") + " €";
                labelTotalPricePayed.Text = totalPricePayed.ToString("N2") + " €"; 
            }
        }

        // Function that determines the index of the currently selected Order from the OrdersLst.
        private int GetActiveOrderIndex()
        {
            if (comboBoxOrders.Items.Count > 0)
            {
                string timeStamp = comboBoxOrders.SelectedItem.ToString();

                foreach (Order order in OrdersLst)
                {
                    if (order.OrderTimestamp.ToString().Equals(timeStamp))
                    {
                        return OrdersLst.IndexOf(order);
                    }
                } 
            }

            return -1;
        }

        #endregion

        #region EventHandler

        private void MainForm_Shown(Object sender, EventArgs e)
        {
            // Set MaximumSize for MainForm to always fit screen
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height);

            // Set MaximumSize for orderPanel to always fit into MainForm with a height set to
            // a multiple of the OrderControl height (for better visuals when scrolling inside
            // a longer list of orders).
            OrderControl orderControl = new OrderControl();
            int orderControlHeight = orderControl.Height;
            orderControl.Dispose();

            int tmp = 0;

            while (true)
            {
                tmp += orderControlHeight;

                if (tmp >= Screen.PrimaryScreen.WorkingArea.Height - 250)
                {
                    panelOrder.MaximumSize = new System.Drawing.Size(this.MaximumSize.Width,
                        tmp - orderControlHeight);
                    break;
                }
            }

            // Initialize data structures and populate the order table and MainForm.
            DeserializeOrdersXml();
            InitComboBoxOrders();
            NewOrderTable(LastOrder);


            if (this.comboBoxOrders.Items.Count < 2)
            {
                this.buttonDeleteOrder.Enabled = false;
            }
        }

        private void ButtonConfig_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.Show();
        }

        private void ComboBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult dialogChangeSelctedOrder = DialogResult.No;

            if (DataHasChanged)
            {
                dialogChangeSelctedOrder = MessageBox.Show("Änderungen an aktueller" +
                " Bestellung nicht gespeichert! \r\n\r\n" + "Dennoch fortfahren?", "Warnung",
                MessageBoxButtons.YesNo);
            }
            
            if(!DataHasChanged || dialogChangeSelctedOrder == DialogResult.Yes)
            {
                string timeStamp = comboBoxOrders.SelectedItem.ToString();

                foreach (Order order in OrdersLst)
                {
                    if (order.OrderTimestamp.ToString().Equals(timeStamp))
                    {
                        NewOrderTable(order);
                        break;
                    }
                }
            }
        }

        private void OrderControl_ControlValueChanged(object objSender, EventArgs e)
        {
            CalculateStatisticsForNerds();
            CalculateOrderSums();
            SerializeOrdersXml();
            DataHasChanged = true;
        }

        private void OrderControl_ControlToBeRemoved(object sender, EventArgs e)
        {
            var activeOrderIdx = GetActiveOrderIndex();

            if (activeOrderIdx == (OrdersLst.Count - 1))
            {
                DialogResult dialogResultDeleteCustomer = MessageBox.Show("Besteller wirklich" +
                    " entfernen? Vorhandenes Guthaben wird unwiderruflich gelöscht.", "Warnung",
                    MessageBoxButtons.YesNo);

                if (dialogResultDeleteCustomer == DialogResult.Yes)
                {
                    OrderControl orderControl = sender as OrderControl;
                    OrdersLst[activeOrderIdx].OrderPropsLst.Remove(orderControl.OrderProps);
                    NewOrderTable(OrdersLst[activeOrderIdx]);
                    CalculateStatisticsForNerds();
                    CalculateOrderSums();
                }
            }
            else
            {
                MessageBox.Show("Besteller können nur aus der aktuellen Bestellung entfernt" +
                " werden.", "Fehler", MessageBoxButtons.OK);
            }
        }

        private void OrderControl_OrderControlOrderClosed(object sender, EventArgs e)
        {
            bool[] tmp = new bool[OrderCrtlLst.Count - 1];

            for (int i = 0; i < OrderCrtlLst.Count - 1; i++)
            {
                if (OrderCrtlLst[i].OrderProps.Ordered || OrderCrtlLst[i].OrderProps.Articles.Equals(String.Empty))
                {
                    tmp[i] = true;
                }
            }

            if (tmp.All(x => x))
            {
                buttonCloseOrder.Enabled = true;
            }
            else
            {
                buttonCloseOrder.Enabled = false;
            }
        }

        private void ButtonNewOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResultNewOrder = MessageBox.Show("Neue Bestellung anlegen?",
                "Achtung", MessageBoxButtons.YesNo);

            if (dialogResultNewOrder == DialogResult.Yes)
            {
                Order newOrder = new Order(new List<OrderProps>());
                OrdersLst.Add(newOrder);
                int i = GetActiveOrderIndex();

                foreach (OrderProps orderProps in OrdersLst[i].OrderPropsLst)
                {
                    OrderProps newOrderProp = new OrderProps(orderProps.CustomerName);
                    newOrderProp.CustomerName = orderProps.CustomerName;
                    newOrderProp.Credit = orderProps.Change;
                    newOrder.OrderPropsLst.Add(newOrderProp);
                }

                comboBoxOrders.Items.Add(newOrder.OrderTimestamp.ToString());
                comboBoxOrders.SelectedItem = newOrder.OrderTimestamp.ToString();

                if (this.buttonDeleteOrder.Enabled == false && OrdersLst.Count > 1)
                {
                    this.buttonDeleteOrder.Enabled = true;
                }

                SerializeOrdersXml();
            }
        }

        private void ButtonDeleteOrder_Click(object sender, EventArgs e)
        {
            // !!!!!!!!!! Löschen deaktivieren wen ausgewählte Bestellung nicht die letzte in der Liste ist !!!!!!!!!!!!
        
            if (OrdersLst.Count > 1)
            {
                DialogResult dialogResultDeleteOrder = MessageBox.Show("Durch Löschen der aktuellen" +
                    " Bestellung gehen alle eingegebene Informationen Verloren. Dies kann sich auch" +
                    " auf vorhandenen Guthaben auswirken und kann nicht rückgängig gemacht werden." +
                    " \r\n \r\n" + "Bestellung wirklich löschen und die vorherige Bestellung laden?",
                    "Achtung", MessageBoxButtons.YesNo);

                if (dialogResultDeleteOrder == DialogResult.Yes)
                {
                    OrdersLst.RemoveAt(GetActiveOrderIndex());
                    SetLastOrder();

                    comboBoxOrders.Items.Remove(comboBoxOrders.SelectedItem);
                    comboBoxOrders.SelectedIndex = comboBoxOrders.Items.Count - 1;

                    if (OrdersLst.Count <= 1)
                    {
                        this.buttonDeleteOrder.Enabled = false;
                    }
                }
            }
        }

        private void TimerAutoSave_Tick(object sender, EventArgs e)
        {
            if (DataHasChanged)
            {
                SerializeOrdersXml();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SerializeOrdersXml();
            this.Focus();
        }

        private void OrderControl_OrderControlNewCustomer(object sender, EventArgs e)
        {
            int orderIdx = GetActiveOrderIndex();
            OrdersLst[orderIdx].OrderPropsLst.Add(new OrderProps(sender as String));
            NewOrderTable(OrdersLst[orderIdx]);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DataHasChanged)
            {
                SerializeOrdersXml();
            }
        }

        private void ButtonCloseOrder_Click(object sender, EventArgs e)
        {
            int oderIdx = GetActiveOrderIndex();
            OrdersLst[oderIdx].OrderClosed = true;
            NewOrderTable(OrdersLst[oderIdx]);
        }

        #endregion

        private void ButtonHallOfFame_Click(object sender, EventArgs e)
        {
            FameAndShameForm fameAndShameForm = new FameAndShameForm(OrdersLst);
            fameAndShameForm.ShowDialog();
        }
    }
}