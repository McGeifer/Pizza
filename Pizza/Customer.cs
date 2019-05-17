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
    public partial class CustomerControl : UserControl
    {
        //private CustomerProps CustomerProps;

        public CustomerControl()
        {
            InitializeComponent();
        }

        public CustomerControl(CustomerProps tmp)
        {
            //CustomerProps = tmp;
            InitializeComponent();
            this.label1.Text = tmp.CustomerName;
        }
    }

    public class CustomerProps
    {
        private string customerName;
        private string articles;
        private bool ordered;
        private float price;
        private float discount;
        private float payed;
        private float tip;
        private float change;
        private float credit;

        public CustomerProps()
        {
            
        }

        public CustomerProps(string CustomerName, string Articles)
        {
            this.customerName = CustomerName;
            this.articles = Articles;
        }
        
        public string CustomerName
        {
            get
            {
                if(customerName == string.Empty)
                {
                    return "Unbekannt";
                }
                else
                {
                    return customerName;
                }
            }
            set 
            {
                if(value == string.Empty)
                {
                    customerName = "Unbekannt";
                }
                else
                {
                    customerName = value;
                }
            }
        }

        public string Articles
        {
            get
            {
                if (articles == string.Empty)
                {
                    return "-";
                }
                else
                {
                    return articles;
                }
            }
            set
            {
                articles = value;
            }
        }

        public bool Ordered
        {
            get
            {
                return ordered;
            }
            set
            {
                ordered = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    price = 0;
                }
                else
                {
                    price = value;
                }
            }
        }

        public float Discount
        {
            get
            {
                return discount;
            }
            set
            {
                if (value < 0)
                {
                    discount = 0;
                }
                else
                {
                    discount = value;
                }
            }
        }

        public float Payed
        {
            get
            {
                return payed;
            }
            set
            {
                if (value < 0)
                {
                    payed = 0;
                }
                else
                {
                    payed = value;
                }
            }
        }

        public float Tip
        {
            get
            {
                return tip;
            }
            set
            {
                if (value < 0)
                {
                    tip = 0;
                }
                else
                {
                    tip = value;
                }
            }
        }

        public float Change
        {
            get
            {
                return change;
            }
            set
            {
                if (value < 0)
                {
                    change = 0;
                }
                else
                {
                    change = value;
                }
            }
        }

        public float Credit
        {
            get
            {
                return credit;
            }
            set
            {
                if (value < 0)
                {
                    credit = 0;
                }
                else
                {
                    credit = value;
                }
            }
        }
    }
}   