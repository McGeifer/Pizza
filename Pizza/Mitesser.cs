using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Mitesser : UserControl
    {
        MitesserProperties MitesserProperties;
    
        public Mitesser()
        {
            MitesserProperties = new MitesserProperties();
            InitializeComponent();
        }

        public Mitesser(MitesserProperties tmp)
        {
            MitesserProperties = tmp;    
            InitializeComponent();

            // Initialisierung der control properties .....
            // init Funktion
            this.label1.Text = MitesserProperties.MitesserName;
        }
    }

    public class MitesserProperties
    {
        private string mitesserName;
        private string bestellung;
        private bool bestellt;
        private float preis;
        private float rabatt;
        private float bezahlt;
        private float trinkgeld;
        private float restgeld;

        public MitesserProperties() {}

        public MitesserProperties(string name)
        {
            mitesserName = name;
        }

        public bool Bestellt
        {
            get
            {
               return bestellt;
            }
            set
            {
                bestellt = value;
            }
        }

        public string MitesserName
        {
            get
            {
                return mitesserName;
            }
            set
            {
                mitesserName = value;
            }
        }

        public string Bestellung
        {
            get
            {
                return bestellung;
            }
            set
            {
                bestellung = value;
            }
        }

        public float Preis
        {
            get
            {
                return preis;
            }
            set
            {
                if (value < 0)
                {
                    preis = 0;
                }
                else
                {
                    preis = value;
                }
            }
        }

        public float Rabatt
        {
            get
            {
                return rabatt;
            }
            set
            {
                if (value < 0)
                {
                    rabatt = 0;
                }
                else
                {
                    rabatt = value;
                }
            }
        }

        public float Bezahlt
        {
            get
            {
                return bezahlt;
            }
            set
            {
                if (value < 0)
                {
                    bezahlt = 0;
                }
                else
                {
                    bezahlt = value;
                }
            }
        }

        public float Trinkgeld
        {
            get
            {
                return trinkgeld;
            }
            set
            {
                if (value < 0)
                {
                    trinkgeld = 0;
                }
                else
                {
                    trinkgeld = value;
                }
            }
        }

        public float Restgeld
        {
            get
            {
                return restgeld;
            }
            set
            {
                if (value < 0)
                {
                    restgeld = 0;
                }
                else
                {
                    restgeld = value;
                }
            }
        }
    }
}