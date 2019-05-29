﻿using System;
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
            this.Shown += new System.EventHandler(this.MainForm_Shown);
        }

        private void MainForm_Shown(Object sender, EventArgs e)
        {
            // Initializing data structures and load program data.
            DeserializeOrdersXml();
            InitComboBoxOrders();
            InitOrderTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create test XML file

            OrderProps props1 = new OrderProps
            {
                CustomerName = "Test1"
            };

            OrderProps props2 = new OrderProps
            {
                CustomerName = "Test2"
            };

            OrderProps props3 = new OrderProps
            {
                CustomerName = "Test3"
            };

            OrderProps props4 = new OrderProps
            {
                CustomerName = "Test4"
            };

            OrderProps props5 = new OrderProps
            {
                CustomerName = "Test5"
            };

            List<OrderProps> propsLst = new List<OrderProps>
            {
                props1,
                props2,
                props3,
                props4,
                props5
            };

            Orders orderTmp1 = new Orders
            {
                OrderTimestamp = DateTime.Parse("2019-04-01T18:45:32"),
                OrderPropsLst = propsLst,
                OrderTitle = "Order 1"
            };

            Orders orderTmp2 = new Orders
            {
                OrderTimestamp = DateTime.Parse("2019-07-01T18:45:32"),
                OrderPropsLst = propsLst,

                OrderTitle = "Order 2"
            };

            Orders orderTmp3 = new Orders
            {
                OrderTimestamp = DateTime.Parse("2019-11-01T18:45:32"),
                OrderPropsLst = propsLst,

                OrderTitle = "Order 3"
            };

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
            FileStream fileStream = null;
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Orders>));

            // Try to read the contents of the XML file into a fileStream.
            // If the XML file could not be found, open a file dialog to select it manually.
            // If no valid file has been selected or the operation is canceled by the user,
            // exit the application.
            try
            {
                fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            }
            catch (FileNotFoundException)
            {
                DialogResult dialogSelectFile = MessageBox.Show("Die Bestelldaten konnten nicht gefunden werden. Datei manuell auswählen?", "Warnung", MessageBoxButtons.YesNo);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unbekannter Fehler - Anwendung kann nicht ausgeführt werden!" + ex, "Fehler", MessageBoxButtons.OK);
                Application.Exit();
                return;
            }
            
            if (fileStream == null)
            {
                MessageBox.Show("Keine gültigen Bestelldaten vorhanden - Anwendung kann nicht ausgeführt werden!", "Fehler", MessageBoxButtons.OK);
                Application.Exit();
                return;
            }
            
            try
            {
                OrdersLst = (List<Orders>)deserializer.Deserialize(fileStream);
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
                    orderControl.Location = new Point(1, i += 40);
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

        private void ButtonConfig_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.Show();
        }
    }
}