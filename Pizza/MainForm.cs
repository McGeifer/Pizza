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
        private List<Orders> ordersLst = new List<Orders>();
        private List<Orders> ordersLstTmp = new List<Orders>();

        // nur für Testzwecke
        private List<OrderProps> orderPropsLst = new List<OrderProps>();
        private List<OrderControl> orderCrtlLst = new List<OrderControl>();

        static XmlSerializer serializer;
        static FileStream fileStream;
        

        public MainForm()
        {
            InitializeComponent();
            DeserializeOrdersXml();
            InitComboBoxOrders();
            InitOrderTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create test XML file
        
            OrderProps props1 = new OrderProps();
            props1.CustomerName = "Test1";

            OrderProps props2 = new OrderProps();
            props2.CustomerName = "Test2";

            OrderProps props3 = new OrderProps();
            props3.CustomerName = "Test3";

            OrderProps props4 = new OrderProps();
            props4.CustomerName = "Test4";

            OrderProps props5 = new OrderProps();
            props5.CustomerName = "Test5";

            List<OrderProps> propsLst = new List<OrderProps>();

            propsLst.Add(props1);
            propsLst.Add(props2);
            propsLst.Add(props3);
            propsLst.Add(props4);
            propsLst.Add(props5);

            Orders orderTmp1 = new Orders();
            orderTmp1.OrderTimestamp = DateTime.Parse("2019-04-01T18:45:32");
            orderTmp1.OrderPropsLst = propsLst;
            orderTmp1.OrderTitle = "Order 1";

            Orders orderTmp2 = new Orders();
            orderTmp2.OrderTimestamp = DateTime.Parse("2019-07-01T18:45:32");
            orderTmp2.OrderPropsLst = propsLst;

            orderTmp2.OrderTitle = "Order 2";

            Orders orderTmp3 = new Orders();
            orderTmp3.OrderTimestamp = DateTime.Parse("2019-11-01T18:45:32");
            orderTmp3.OrderPropsLst = propsLst;

            orderTmp3.OrderTitle = "Order 3";

            OrdersLstTmp.Add(orderTmp1);
            OrdersLstTmp.Add(orderTmp2);
            OrdersLstTmp.Add(orderTmp3);


            serializer = new XmlSerializer(typeof(List<Orders>));
            fileStream = new FileStream(@".\orders.xml", FileMode.Create);
            serializer.Serialize(fileStream, OrdersLstTmp);
            fileStream.Close();

        }

        // load orders from XML file
        void DeserializeOrdersXml()
        {
            string filePath = ".\\orders.xml";
            FileStream fileStream;
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Orders>));

            try
            {
                fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                OrdersLst = (List<Orders>)deserializer.Deserialize(fileStream);
                fileStream.Close();
            }
            catch (FileNotFoundException)
            {
                DialogResult dialogResult = MessageBox.Show("Die Bestelldaten konnten nicht gefunden werden. Datei manuell auswählen?", "Warnung", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
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
                            OrdersLst = (List<Orders>)deserializer.Deserialize(fileStream);
                            fileStream.Close();
                        }
                        else
                        {
                            //   ???????
                        }
                    }
                }
            }
        }
        
        // add orders to combo box
        void InitComboBoxOrders()
        {
            List<string> lst = new List<string>();
            
            foreach(Orders order in OrdersLst)
            {
                lst.Add(order.OrderTimestamp.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo) + " " + order.OrderTitle); // sort orders by time stamp
            }

            cboOrders.Items.AddRange(lst.OrderBy(x => x).ToArray()); // add sorted orders to combo box
         
            if(cboOrders.Items.Count > 0)
            {
                cboOrders.SelectedIndex = cboOrders.Items.Count - 1; // set last order as active
            }
        }

        // generate table with empty order by using the customers of the last order
        void InitOrderTable()
        {
            if (OrdersLst.Any())
            {
                Orders order = new Orders();
                order = OrdersLst.OrderBy(x => x.OrderTimestamp).Last() as Orders;
                int i = 25;

                foreach (OrderProps orderProps in order.OrderPropsLst)
                {
                    OrderControl orderControl = new OrderControl(orderProps);
                    OrderCrtlLst.Add(orderControl);
                    groupBox2.Controls.Add(orderControl);
                    orderControl.Location = new Point(5, i += 40);
                }

                if (order.OrderClosed)
                {
                    groupBox2.Enabled = false;
                } 
            }
        }

        public List<Orders> OrdersLstTmp { get => ordersLstTmp; set => ordersLstTmp = value; }
        public List<Orders> OrdersLst { get => ordersLst; set => ordersLst = value; }
        public List<OrderProps> OrderPropsLst { get => orderPropsLst; set => orderPropsLst = value; }
        public List<OrderControl> OrderCrtlLst { get => orderCrtlLst; set => orderCrtlLst = value; }


        private void buttonConfig_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.Show();
        }
    }
}