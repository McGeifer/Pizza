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
            //CustomerPropsLst.Add(new CustomerProps("Anton Abendroth", "-"));
            //CustomerPropsLst.Add(new CustomerProps("Berta Bertram", "-"));
            //CustomerPropsLst.Add(new CustomerProps("Christel", "-"));
            //CustomerPropsLst.Add(new CustomerProps("Kanzler", "-"));
            //CustomerPropsLst.Add(new CustomerProps("Schilli", "-"));

            //OrdersLst.Add(new Order(CustomerPropsLst));

            //int i = -20;

            //foreach (CustomerProps tmp in CustomerPropsLst)
            //{
            //    CustomerControl customerControl = new CustomerControl(tmp);
            //    groupBox2.Controls.Add(customerControl);
            //    customerControl.Location = new Point(5, i += 40);
            //}

            //SaveOrdersToXml();
        }

        void SaveOrdersToXml()
        {
            serializer = new XmlSerializer(typeof(List<Order>));
            fileStream = new FileStream(@".\orders.xml", FileMode.Create);
            serializer.Serialize(fileStream, OrdersLst);
            fileStream.Close();
        }

        // load orders from xml file
        void LoadOrders()
        {
            string filePath = ".\\orders.xml";
            StreamReader fileStream;
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Order>));

            try
            {
                fileStream = new StreamReader(filePath);
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
                        openFileDialog.Filter = "|orders.xml";
                        openFileDialog.FilterIndex = 1;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Get the path of specified file
                            filePath = openFileDialog.FileName;

                            //// Read the contents of the file into a fileStream
                            //fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                            //OrdersLst = (List<Order>)deserializer.Deserialize(fileStream);
                            //fileStream.Close();
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
                lst.Add(i.OrderTimestamp.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo) + " " + i.OrderTitle);
            }

            cboOrders.Items.AddRange(lst.OrderBy(x => x).ToArray());
         
            if(cboOrders.Items.Count > 0)
            {
                cboOrders.SelectedIndex = cboOrders.Items.Count - 1;
            }
        }

        // generate table with empty order by using the customers of the last order
        void InitOrderTable()
        {
            Order order = new Order();
            order = OrdersLst.OrderBy(x => x.OrderTimestamp).Last() as Order;
            int i = -20;

            foreach(CustomerProps customerProps in order.CustomerPropsLst)
            {
                CustomerControl customerControl = new CustomerControl(customerProps);
                CustomerCrtlsLst.Add(customerControl);
                groupBox2.Controls.Add(customerControl);
                customerControl.Location = new Point(5, i += 40);
            }

            if(order.OrderClosed)
            {
                groupBox2.Enabled = false;
            }
        }
    }
}