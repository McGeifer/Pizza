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
        private List<Order> _ordersLst = new List<Order>();
        private Order _lastOrder = new Order();
        private List<OrderControl> _orderCrtlLst = new List<OrderControl>();
        private const int MainFormHeightOffset = 110;

        // Nur für Testzwecke
        // private List<Orders> ordersLstTmp = new List<Orders>();
        // private List<OrderProps> orderPropsLst = new List<OrderProps>();

        //private XmlSerializer serializer;
        //private FileStream fileStream;


        public MainForm()
        {
            InitializeComponent();
            this.Shown += new System.EventHandler(this.MainForm_Shown);
        }

        private void MainForm_Shown(Object sender, EventArgs e)
        {
            // Set MaximumSize for MainForm to always fit screen
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

            // Set MaximumSize for orderPanel to always fit into MainForm with a height set to a multiple of the OrderControl height
            // (for better visuals when scrolling inside a longer list of orders).
            OrderControl orderControl = new OrderControl();
            int orderControlHeight = orderControl.Height;
            orderControl.Dispose();

            int tmp = 0;

            while (true)
            {
                tmp += orderControlHeight;

                if (tmp >= Screen.PrimaryScreen.WorkingArea.Height - 250)
                {
                    panelOrder.MaximumSize = new System.Drawing.Size(this.MaximumSize.Width, tmp - orderControlHeight);
                    break;
                }
            }

            // Initialize data structures and populate the order table and MainForm.
            DeserializeOrdersXml();
            InitComboBoxOrders();
            InitOrderTable();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    // create test XML file

        //    OrderProps props1 = new OrderProps
        //    {
        //        CustomerName = "Test1"
        //    };

        //    OrderProps props2 = new OrderProps
        //    {
        //        CustomerName = "Test2"
        //    };

        //    OrderProps props3 = new OrderProps
        //    {
        //        CustomerName = "Test3"
        //    };

        //    OrderProps props4 = new OrderProps
        //    {
        //        CustomerName = "Test4"
        //    };

        //    OrderProps props5 = new OrderProps
        //    {
        //        CustomerName = "Test5"
        //    };

        //    List<OrderProps> propsLst = new List<OrderProps>
        //    {
        //        props1,
        //        props2,
        //        props3,
        //        props4,
        //        props5
        //    };

        //    Orders orderTmp1 = new Orders
        //    {
        //        OrderTimestamp = DateTime.Parse("2019-04-01T18:45:32"),
        //        OrderPropsLst = propsLst,
        //        OrderTitle = "Order 1"
        //    };

        //    Orders orderTmp2 = new Orders
        //    {
        //        OrderTimestamp = DateTime.Parse("2019-07-01T18:45:32"),
        //        OrderPropsLst = propsLst,

        //        OrderTitle = "Order 2"
        //    };

        //    Orders orderTmp3 = new Orders
        //    {
        //        OrderTimestamp = DateTime.Parse("2019-11-01T18:45:32"),
        //        OrderPropsLst = propsLst,

        //        OrderTitle = "Order 3"
        //    };

        //    OrdersLstTmp.Add(orderTmp1);
        //    OrdersLstTmp.Add(orderTmp2);
        //    OrdersLstTmp.Add(orderTmp3);

        //    serializer = new XmlSerializer(typeof(List<Orders>));
        //    fileStream = new FileStream(@".\orders.xml", FileMode.Create);
        //    serializer.Serialize(fileStream, OrdersLstTmp);
        //    fileStream.Close();
        //}

        // load orders from XML file

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
                dialogSelectFile = MessageBox.Show("Die Bestelldaten (orders.xml) konnten nicht gefunden werden. Datei manuell auswählen?", "Warnung", MessageBoxButtons.YesNo);

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
                    dialogNewXmlFile = MessageBox.Show("Soll eine neu Datei für Bestelldaten erzeugt werden?"
                        + Environment.NewLine + Environment.NewLine + "Nein - beendet das Programm", "Warnung", MessageBoxButtons.YesNo);

                    if (dialogNewXmlFile == DialogResult.No)
                    {
                        Application.Exit();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unbekannter Fehler - Anwendung kann nicht ausgeführt werden!" + ex, "Fehler", MessageBoxButtons.OK);
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

                DialogResult dialogResultXmlDeserializeException = MessageBox.Show(exceptionMsg, "Fehler", MessageBoxButtons.OK);
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

            lst.OrderBy(x => x.Year).ThenBy(x => x.Month).ThenBy(x => x.Day).ThenBy(x => x.TimeOfDay); // Sort list
            comboBoxOrders.SelectedIndexChanged -= ComboBoxOrders_SelectedIndexChanged; // temporarily disable handler function

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

        // Generate table with a new by using the customers of the last order.
        void InitOrderTable()
        {
            NewOrderTable(LastOrder);
        }

        // Create a new order table with a given order.
        void NewOrderTable(Order order)
        {
            if (order.OrderPropsLst.Any())
            {
                // Disable MainForm layout logic while changing controls for better visuals.
                this.SuspendLayout();

                // Clean order table by removing all controls from the panel an the OrderCrtlLst.
                while (OrderCrtlLst.Count > 0)
                {
                    panelOrder.Controls.Remove(OrderCrtlLst[0]);
                    OrderCrtlLst[0].OrderControlChanged -= OrderControl_ControlValueChanged;
                    OrderCrtlLst[0].Dispose();
                    OrderCrtlLst.Remove(OrderCrtlLst[0]);
                }

                // Add new control for each customer of the given order.
                foreach (OrderProps orderProps in order.OrderPropsLst)
                {
                    // Add new control for each customer of the last order
                    OrderControl orderControl = new OrderControl(orderProps);
                    OrderCrtlLst.Add(orderControl);
                    panelOrder.Controls.Add(orderControl);
                    orderControl.Location = new Point(1, OrderCrtlLst.Count == 1 ? 0 : (OrderCrtlLst.Count - 1) * orderControl.Height);
                    orderControl.OrderControlChanged += new EventHandler(OrderControl_ControlValueChanged);
                }

                // Disable all controls if an order has been submitted.
                if (order.OrderClosed)
                {
                    foreach (OrderControl orderControl in OrderCrtlLst)
                    {
                        orderControl.Enabled = false;
                    }
                }

                // re-enable MainForm layout logic.
                this.ResumeLayout();

                // Resize and position MainForm
                this.Size = new System.Drawing.Size(this.Width, groupBoxOrderManagement.Height + panelOrder.Height + panelOrderSums.Height + MainFormHeightOffset);
                this.CenterToScreen();
            }
        }

        private List<Order> OrdersLst { get => _ordersLst; set => _ordersLst = value; }
        private List<OrderControl> OrderCrtlLst { get => _orderCrtlLst; set => _orderCrtlLst = value; }
        private Order LastOrder { get => _lastOrder; set => _lastOrder = value; }

        private void ButtonConfig_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.Show();
        }

        private void ComboBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime timeStamp = DateTime.Parse(comboBoxOrders.SelectedItem.ToString());

            for (int i = 0; i < _ordersLst.Count; i++)
            {
                if (OrdersLst[i].OrderTimestamp == timeStamp)
                {
                    NewOrderTable(OrdersLst[i]);
                }
            }
        }

        private void OrderControl_ControlValueChanged(object objSender, EventArgs e)
        {
            // calculate total sums for the order
            decimal totalPrice = 0;
            decimal totalPriceWithDiscount = 0;
            decimal totalPricePayed = 0;
            decimal totalTip = 0;
            
            foreach (OrderProps orderProps in LastOrder.OrderPropsLst)
            {
                totalPrice += orderProps.Price;
                totalPriceWithDiscount += orderProps.PriceWithDiscount;
                totalPricePayed += orderProps.PricePayed;
                totalTip += orderProps.Tip;
            }

            labelTotalPrice.Text = totalPrice.ToString("N2") + " € ";
            labelTotalPriceWithDiscount.Text = totalPriceWithDiscount.ToString("N2") + " € ";
            labelTotalPayed.Text = totalPricePayed.ToString("N2") + " € ";
            labelTotalTip.Text = totalTip.ToString("N2") + " € ";

            // calc statistics for nerds
            //foreach (Order order in OrdersLst)
            //{
            //    foreach (OrderProps orderProps in order.OrderPropsLst)
            //    {
                    
            //    }
            //}
        }
    }
}