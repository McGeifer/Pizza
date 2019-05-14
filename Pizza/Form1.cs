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

namespace Pizza
{
    public partial class Form1 : Form
    {
        private List<Customer>             BestellerLst = new List<Customer>();
        private List<BestellerProps>   BestellerPropLst = new List<BestellerProps>();
        private List<Order>            BestellungLst = new List<Order>();

        static XmlSerializer serializer;
        static FileStream fileStream;
        
        public Form1()
        {
            InitializeComponent();
            InitBesteller();
            //InitOrders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BestellerPropLst.Add(new BestellerProps("Anton Abendroth"));
            BestellerPropLst.Add(new BestellerProps("Berta Bertram"));
            BestellerPropLst.Add(new BestellerProps("Christel"));
            BestellerPropLst.Add(new BestellerProps("Kanzler"));

            foreach (BestellerProps x in BestellerPropLst)
            {
                BestellerLst.Add(new Customer(x));
            }

            int i = -20;

            foreach (Customer tmp in BestellerLst)
            {
                tmp.Location = new Point(5, i += 40);
                groupBox2.Controls.Add(tmp);
            }

            SaveXml();
        }

        void SaveXml()
        {
            serializer = new XmlSerializer(typeof(BestellerProps));
            fileStream = new FileStream(@".\tmp.xml", FileMode.Create);
            foreach (BestellerProps tmp in BestellerPropLst)
            {
                serializer.Serialize(fileStream, tmp);
            }
            fileStream.Close();
        }

        // Lade Besteller-Daten und speichere diese in der BestellerLst.
        void InitBesteller()
        {
            try
            {
                FileStream fileStream = new FileStream(@".users.xml", FileMode.Open, FileAccess.ReadWrite);
            }
            catch (FileNotFoundException)
            {
                DialogResult dialogResult = MessageBox.Show("Die Benutzerdaten konnten nicht gefunden werden. Datei manuell auswählen?", "Warnung", MessageBoxButtons.YesNo);
                
                if(dialogResult == DialogResult.Yes)
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = @".\";
                        openFileDialog.Filter = "|bestellerName.xml";
                        openFileDialog.FilterIndex = 1;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Get the path of specified file
                            var filePath = openFileDialog.FileName;

                            // Read the contents of the file into a fileStream
                            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                            serializer = new XmlSerializer(typeof(BestellerProps));
                            //(BestellerProps)serializer.Deserialize(fileStream);


                        }
                    }
                }
            }    
        }
    }
}