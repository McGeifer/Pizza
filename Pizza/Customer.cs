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
#region constructors
        public CustomerControl()
        {
            InitializeComponent();
        }

        public CustomerControl(CustomerProps tmp)
        {
            InitializeComponent();
            this.labelCustomerName.Text = tmp.CustomerName;
        }
#endregion

#region methods
        // keypress is a decimal or comma character
        private bool KeyPressedIsDecimalOrComma(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        // only allow one decimal point for text box
        private bool AllowOnlyOneComma(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void TextBoxAddCurrencySign(TextBox t, EventArgs e)
        {
            if (!t.Text.Contains("€") && (!String.IsNullOrEmpty(t.Text) || !String.IsNullOrWhiteSpace(t.Text)))
            {
                t.Text = t.Text + " € ";
            }
        }

        private bool TextBoxInputConfirmed(KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Return))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void DisableCustomerControl()
        {
            //labelCustomerName.Enabled = false;
            //labelSumWithDiscount.Enabled = false;
            //labelChange.Enabled = false;
            textBoxOrder.Enabled = false;
            textBoxSum.Enabled = false;
            textBoxDiscount.Enabled = false;
            textBoxSumPayed.Enabled = false;
        }

        private void EnableCustomerControl()
        {
            //labelCustomerName.Enabled = true;
            //labelSumWithDiscount.Enabled = true;
            //labelChange.Enabled = true;
            textBoxOrder.Enabled = true;
            textBoxSum.Enabled = true;
            textBoxDiscount.Enabled = true;
            textBoxSumPayed.Enabled = true;
        }

#endregion

#region event handler

        private void TextBoxSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBoxInputConfirmed(e))
            {
                e.Handled = true;
                textBoxDiscount.Focus();
            }

            if(KeyPressedIsDecimalOrComma(sender, e))    
            {
                e.Handled = true;
            }
            
            if (AllowOnlyOneComma(sender, e))
            {
                e.Handled = true;
            }
        }

        private void TextBoxSum_Leave(object sender, EventArgs e)
        {
            TextBoxAddCurrencySign(textBoxSum, e);
        }

        private void TextBoxSum_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSum.SelectAll();
        }

        private void TextBoxDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBoxInputConfirmed(e))
            {
                e.Handled = true;
                textBoxSumPayed.Focus();
            }

            if (KeyPressedIsDecimalOrComma(sender, e))
            {
                e.Handled = true;
            }

            if (AllowOnlyOneComma(sender, e))
            {
                e.Handled = true;
            }
        }

        private void TextBoxDiscount_Leave(object sender, EventArgs e)
        {
            TextBoxAddCurrencySign(textBoxDiscount, e);
        }

        private void TextBoxDiscount_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxDiscount.SelectAll();
        }
       
        private void TextBoxSumPayed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBoxInputConfirmed(e))
            {
                e.Handled = true;
                checkBoxOrder.Focus();
            }

            if (KeyPressedIsDecimalOrComma(sender, e))
            {
                e.Handled = true;
            }

            if (AllowOnlyOneComma(sender, e))
            {
                e.Handled = true;
            }
        }

        private void TextBoxSumPayed_Leave(object sender, EventArgs e)
        {
            TextBoxAddCurrencySign(textBoxSumPayed, e);
        }

        private void TextBoxSumPayed_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSumPayed.SelectAll();
        }

        #endregion

        private void checkBoxOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOrder.Checked)
            {
                DisableCustomerControl();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bestellt Markierung wirklich aufheben?", "Warnung", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    EnableCustomerControl();
                }
            }
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