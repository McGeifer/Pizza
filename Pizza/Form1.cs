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
        private List<Mitesser> Lst = new List<Mitesser>();
        private List<MitesserProperties> MeLst = new List<MitesserProperties>();
        static XmlSerializer serializer;
        static FileStream stream;
        
        public Form1()
        {
            InitializeComponent();
            InitUsers();
            InitOrders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MeLst.Add(new MitesserProperties("Anton Abendroth"));
            MeLst.Add(new MitesserProperties("Berta Bertram"));
            MeLst.Add(new MitesserProperties("Christel"));
            MeLst.Add(new MitesserProperties("Kanzler"));

            foreach (MitesserProperties x in MeLst)
            {
                Lst.Add(new Mitesser(x));
            }

            int i = -20;

            foreach (Mitesser tmp in Lst)
            {
                tmp.Location = new Point(5, i += 40);
                groupBox2.Controls.Add(tmp);
            }

            SaveXml();
        }

        void SaveXml()
        {
            serializer = new XmlSerializer(typeof(MitesserProperties));
            stream = new FileStream(@".\tmp.xml", FileMode.Create);
            foreach (MitesserProperties tmp in MeLst)
            {
                serializer.Serialize(stream, tmp);
            }
            stream.Close();
        }

        // Load user data from XML file and store it in UserLst.
        void InitUsers()
        {
            try
            {
                FileStream fileStream = new FileStream(@".users.xml", FileMode.Open, FileAccess.ReadWrite);
            }
            catch (FileNotFoundException)
            {
                FileStream fileStream = new FileStream(@".users.xml", FileMode.CreateNew, FileDialog );
                throw;
            }    
        
        }
    }
}