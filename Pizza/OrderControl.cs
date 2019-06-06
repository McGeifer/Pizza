using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Pizza
{
    public partial class OrderControl : UserControl
    {
        #region properties

        private OrderProps _orderProps;

        private OrderProps OrderProps
        {
            get => _orderProps;
            set => _orderProps = value;
        }

        #endregion

        #region constructors

        public OrderControl()
        {
            InitializeComponent();
        }

        public OrderControl(OrderProps orderProps)
        {
            InitializeComponent();
            OrderProps = orderProps;
            orderProps.ControlValueChanged += OrderProps_ControlValueChanged;
            
            this.labelCustomerName.Text = orderProps.CustomerName;
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
        private void TextBoxAddCurrencySign(TextBox t)
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
            textBoxOrder.Enabled = false;
            textBoxPrice.Enabled = false;
            textBoxDiscount.Enabled = false;
            textBoxPricePayed.Enabled = false;
        }

        private void EnableCustomerControl()
        {
            textBoxOrder.Enabled = true;
            textBoxPrice.Enabled = true;
            textBoxDiscount.Enabled = true;
            textBoxPricePayed.Enabled = true;
        }

        public void CalcSums()
        {
            // calc price with discount

            OrderProps.PriceWithDiscount = OrderProps.Price - (OrderProps.Discount - OrderProps.Credit);
            if (OrderProps.Discount > OrderProps.Price)
            {
                this.labelPriceWithDiscount.Text = "  ???";
            }
            else
            {
                decimal x = OrderProps.Price - OrderProps.Discount;
                this.labelPriceWithDiscount.Text = x.ToString();
            }

            // calc change
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
                textBoxPrice.Focus();
                e.Handled = true;
            }
        }

        private void TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextBoxPrice_Leave(object sender, EventArgs e)
        {
            if (textBoxPrice.Text == String.Empty)
            {
                textBoxPrice.Text = "0,00 €";
            }
            else
            {
                try
                {
                    OrderProps.Price = Convert.ToDecimal(textBoxPrice.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Eingabe ist keine Dezimalzahl! Bitte gültigen Wert eingeben.", "Fehler", MessageBoxButtons.OK);
                }
            }

            TextBoxAddCurrencySign(textBoxPrice);
            CalcSums();
        }

        private void TextBoxSum_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPrice.SelectAll();
        }

        private void TextBoxDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBoxInputConfirmed(e))
            {
                e.Handled = true;
                textBoxPricePayed.Focus();
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
            TextBoxAddCurrencySign(textBoxDiscount);
        }

        private void TextBoxDiscount_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxDiscount.SelectAll();
        }
       
        private void TextBoxPricePayed_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextBoxPricePayed_Leave(object sender, EventArgs e)
        {
            TextBoxAddCurrencySign(textBoxPricePayed);
        }

        private void TextBoxPricePayed_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPricePayed.SelectAll();
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
            TextBoxAddCurrencySign(textBoxTip);
        }

        private void TextBoxTip_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxTip.SelectAll();
        }

        private void CheckBoxOrder_Click(object sender, EventArgs e)
        {
            OrderProps.Articles = "Das ist ein Test";
            
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

        // Update the text boxes and labels of the control with there corresponding Properties if they've been changed.
        // This will guarantee consistent data between the shown value in the UI elements and the stored Property.
        private void OrderProps_ControlValueChanged(Object objSender, EventArgs e)
        {
            switch (objSender as string)
            {
                case "Articles":
                    textBoxOrder.Text = OrderProps.Articles;
                    DialogResult dialogResult = MessageBox.Show("EventHandleeeeer", "%$(&§$%/§(?=)(", MessageBoxButtons.OK);
                    break;

                case "CustomerName":
                    labelCustomerName.Text = OrderProps.CustomerName;
                    break;

                case "Price":
                    textBoxPrice.Text = OrderProps.Price.ToString();
                    TextBoxAddCurrencySign(textBoxPrice);
                    break;

                case "Discount":
                    textBoxDiscount.Text = OrderProps.Discount.ToString();
                    TextBoxAddCurrencySign(textBoxDiscount);
                    break;

                case "Credit":
                    break;

                case "PriceWithDiscount":
                    break;

                case "PricePayed":
                    break;

                case "Change":
                    break;

                case "Tip":
                    break;

                case "Ordered":
                    break;

                default:
                    break;
            }
        }

        #endregion
    }
}