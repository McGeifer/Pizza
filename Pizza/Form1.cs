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
    public partial class Form1 : Form
    {
        private List<Order> OrdersLst = new List<Order>();

        private List<Order> OrdersLstTmp = new List<Order>();

        // nur für Testzwecke
        private List<CustomerProps> CustomerPropsLst = new List<CustomerProps>();
        private List<CustomerControl> CustomerCrtlsLst = new List<CustomerControl>();

        static XmlSerializer serializer;
        static FileStream fileStream;
        
        public Form1()
        {
            InitializeComponent();
            LoadOrders();
            InitComboBoxOrders();
            InitOrderTable();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create test xml file
        
            CustomerProps props1 = new CustomerProps();
            props1.CustomerName = "Test1";

            CustomerProps props2 = new CustomerProps();
            props2.CustomerName = "Test2";

            CustomerProps props3 = new CustomerProps();
            props3.CustomerName = "Test3";

            CustomerProps props4 = new CustomerProps();
            props4.CustomerName = "Test4";

            CustomerProps props5 = new CustomerProps();
            props5.CustomerName = "Test5";

            List<CustomerProps> propsLst = new List<CustomerProps>();

            propsLst.Add(props1);
            propsLst.Add(props2);
            propsLst.Add(props3);
            propsLst.Add(props4);
            propsLst.Add(props5);

            Order orderTmp1 = new Order();
            orderTmp1.OrderTimestamp = DateTime.Parse("2019-04-01T18:45:32");
            orderTmp1.CustomerPropsLst = propsLst;
            orderTmp1.OrderTitle = "Order 1";

            Order orderTmp2 = new Order();
            orderTmp2.OrderTimestamp = DateTime.Parse("2019-07-01T18:45:32");
            orderTmp2.CustomerPropsLst = propsLst;

            orderTmp2.OrderTitle = "Order 2";

            Order orderTmp3 = new Order();
            orderTmp3.OrderTimestamp = DateTime.Parse("2019-11-01T18:45:32");
            orderTmp3.CustomerPropsLst = propsLst;

            orderTmp3.OrderTitle = "Order 3";

            OrdersLstTmp.Add(orderTmp1);
            OrdersLstTmp.Add(orderTmp2);
            OrdersLstTmp.Add(orderTmp3);


            serializer = new XmlSerializer(typeof(List<Order>));
            fileStream = new FileStream(@".\orders.xml", FileMode.Create);
            serializer.Serialize(fileStream, OrdersLstTmp);
            fileStream.Close();

        }

        // load orders from xml file
        void LoadOrders()
        {
            string filePath = ".\\orders.xml";
            FileStream fileStream;
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Order>));

            try
            {
                fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                OrdersLst = (List<Order>)deserializer.Deserialize(fileStream);
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
                            OrdersLst = (List<Order>)deserializer.Deserialize(fileStream);
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
            
            foreach(Order i in OrdersLst)
            {
                lst.Add(i.OrderTimestamp.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo) + " " + i.OrderTitle); // sort orders by timestamp
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
                Order order = new Order();
                order = OrdersLst.OrderBy(x => x.OrderTimestamp).Last() as Order;
                int i = -20;

                foreach (CustomerProps customerProps in order.CustomerPropsLst)
                {
                    CustomerControl customerControl = new CustomerControl(customerProps);
                    CustomerCrtlsLst.Add(customerControl);
                    groupBox2.Controls.Add(customerControl);
                    customerControl.Location = new Point(5, i += 40);
                }

                if (order.OrderClosed)
                {
                    groupBox2.Enabled = false;
                } 
            }
        }
    }
}