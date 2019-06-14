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
        public event EventHandler OrderControlChanged;

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
            OrderProps.ControlValueChanged += OrderProps_ControlValueChanged;
            
            this.labelCustomerName.Text = orderProps.CustomerName;
        }

        #endregion

        #region methods

        // Is the key pressed a decimal or comma character?
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

        // Allow only one decimal point for the text box.
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

        // Add a currency sign (€) to the end of the text box/ label if it doesn't already exists.
        private void TextBoxAddCurrencySign(TextBox t)
        {
            if (!t.Text.Contains("€") && (!String.IsNullOrEmpty(t.Text) || !String.IsNullOrWhiteSpace(t.Text)))
            {
                t.Text = t.Text + " € ";
            }
        }
        private void LabelAddCurrencySign(Label l)
        {
            if (!l.Text.Contains("€") && (!String.IsNullOrEmpty(l.Text) || !String.IsNullOrWhiteSpace(l.Text)))
            {
                l.Text = l.Text + " € ";
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

        public void CalcControlSums()
        {
            // calculate price with discount
            decimal priceWithDiscount = OrderProps.Price - (OrderProps.Discount + OrderProps.Credit);

            if (OrderProps.PriceWithDiscount < 0)
            {
                this.labelPriceWithDiscount.Text = "  ???";
                MessageBox.Show("Bitte Eingabe prüfen!", "Fehler", MessageBoxButtons.OK);
            }
            else
            {
                OrderProps.PriceWithDiscount = priceWithDiscount;
            }

            // calculate change
            decimal change = OrderProps.PriceWithDiscount - OrderProps.PricePayed;

            if (OrderProps.Change < 0)
            {
                this.labelChange.Text = "  ???";
                MessageBox.Show("Bitte Eingabe prüfen!", "Fehler", MessageBoxButtons.OK);
            }
            else
            {
                OrderProps.Change = change;
            }

            // calculate credit
            decimal credit = OrderProps.Change - OrderProps.Tip;

            if (OrderProps.Credit < 0)
            {
                MessageBox.Show("Trinkgeld größer als Guthaben, bitte korrigieren!", "Fehler", MessageBoxButtons.OK);
            }
            else
            {
                OrderProps.Credit = credit;
            }

            // calculate overall sums
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

        // Update the text boxes and labels of the order control with their corresponding Properties if they've been changed.
        // This will guarantee consistent data between the shown value in the UI elements and the stored Property.
        private void OrderProps_ControlValueChanged(object objSender, EventArgs e)
        {
            if (this.OrderControlChanged != null)
            {
                this.OrderControlChanged(this, e);
            }

            switch (objSender as string)
            {
                case "Articles":
                    textBoxOrder.Text = OrderProps.Articles;
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

                //case "Credit":
                //    labelCredit.Text = OrderProps.Credit.ToString();
                //    LabelAddCurrencySign(labelCredit);
                //    break;

                case "PriceWithDiscount":
                    labelPriceWithDiscount.Text = OrderProps.PriceWithDiscount.ToString();
                    LabelAddCurrencySign(labelPriceWithDiscount);
                    break;

                case "PricePayed":
                    textBoxPricePayed.Text = OrderProps.PricePayed.ToString();
                    TextBoxAddCurrencySign(textBoxPricePayed);
                    break;

                case "Change":
                    labelChange.Text = OrderProps.Change.ToString();
                    LabelAddCurrencySign(labelChange);
                    break;

                case "Tip":
                    textBoxTip.Text = OrderProps.Tip.ToString();
                    TextBoxAddCurrencySign(textBoxTip);
                    break;

                case "Ordered":
                    checkBoxOrder.Checked = OrderProps.Ordered;
                    break;

                default:
                    break;
            }
        }

        #endregion
    }
}