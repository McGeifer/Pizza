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
    public partial class OrderControl : UserControl
    {
        #region constructors

        public OrderControl()
        {
            InitializeComponent();
        }

        public OrderControl(OrderProps tmp)
        {
            InitializeComponent();
            this.labelCustomerName.Text = tmp.CustomerName;
        }

        #endregion

        #region methods

        // The key pressed is a decimal or comma character?
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

        // Only allow one decimal point for the text box.
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

        // Add a currency sign (€) to the ende of the text box if it's not already existing.
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

        private void TextBoxOrder_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxOrder.SelectAll();
        }

        private void TextBoxOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBoxInputConfirmed(e))
            {
                textBoxSum.Focus();
                e.Handled = true;
            }
        }

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
                textBoxTip.Focus();
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

        private void TextBoxTip_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextBoxTip_Leave(object sender, EventArgs e)
        {
            TextBoxAddCurrencySign(textBoxTip, e);
        }

        private void TextBoxTip_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxTip.SelectAll();
        }

        private void CheckBoxOrder_Click(object sender, EventArgs e)
        {
            if (checkBoxOrder.Checked)
            {
                DisableCustomerControl();
            }
            else
            {
                checkBoxOrder.Checked = true;
                DialogResult dialogResult = MessageBox.Show("Bestellt Markierung wirklich aufheben?", "Warnung", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    EnableCustomerControl();
                    checkBoxOrder.Checked = false;
                }
            }
        }
        #endregion
    }
}