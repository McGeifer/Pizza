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
            textBoxArticle.Enabled = false;
            textBoxPrice.Enabled = false;
            textBoxDiscount.Enabled = false;
            textBoxPricePayed.Enabled = false;
        }

        private void EnableCustomerControl()
        {
            textBoxArticle.Enabled = true;
            textBoxPrice.Enabled = true;
            textBoxDiscount.Enabled = true;
            textBoxPricePayed.Enabled = true;
        }

        public void CalcControlSums()
        {
            // calculate price with discount
            decimal priceWithDiscount = OrderProps.Price - (OrderProps.Discount + OrderProps.Credit);

            if (priceWithDiscount < 0)
            {
                this.labelPriceWithDiscount.Text = " ??? ";
                MessageBox.Show("Rabatt größer als Preis!", "Fehler", MessageBoxButtons.OK);
                this.textBoxDiscount.SelectAll();
                this.textBoxDiscount.Focus();
            }
            else
            {
                OrderProps.PriceWithDiscount = priceWithDiscount;
                this.labelPriceWithDiscount.Text = OrderProps.PriceWithDiscount.ToString("N2") + " € ";
            }

            // calculate change
            decimal change = OrderProps.PricePayed - OrderProps.PriceWithDiscount;
            OrderProps.Change = change;
            this.labelChange.Text = OrderProps.Change.ToString("N2") + " € ";

            //check tip, recalculate change
            if (textBoxTip.Text != " ??? ")
            {
                if (OrderProps.Tip > OrderProps.Change && OrderProps.Tip != 0)
                {
                    MessageBox.Show("Trinkgeld größer als Guthaben!", "Fehler", MessageBoxButtons.OK);
                    textBoxTip.Text = " ??? ";
                    this.textBoxTip.SelectAll();
                    this.textBoxTip.Focus();
                }
                else
                {
                    if (decimal.TryParse(textBoxTip.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal d))
                    {
                        OrderProps.Tip = d;
                        OrderProps.Change = OrderProps.Change - OrderProps.Tip;
                    }
                    else
                    {
                        MessageBox.Show("Bitte gültigen Wert eingeben.", "Fehler", MessageBoxButtons.OK);
                    }
                }
            }
        }

        #endregion

        #region event handler

        // 
        //  TextBox Article
        //
        private void TextBoxArticle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBoxInputConfirmed(e))
            {
                textBoxPrice.Focus();
                e.Handled = true;
            }
        }

        private void TextBoxArticle_Leave(object sender, EventArgs e)
        {
            OrderProps.Articles = textBoxArticle.Text;
        }

        // 
        //  TextBox Price
        //
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
                OrderProps.Price = 0;
            }

            if (decimal.TryParse(textBoxPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal d))
            {
                OrderProps.Price = d;
                CalcControlSums();
            }
            else
            {
                MessageBox.Show("Bitte gültigen Wert eingeben.", "Fehler", MessageBoxButtons.OK);
            }
        }

        private void TextBoxPrice_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPrice.Focus();
        }

        private void TextBoxPrice_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxPrice.SelectAll();
            textBoxPrice.Focus();
        }

        // 
        //  TextBox Discount
        //
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
            if (textBoxDiscount.Text == String.Empty)
            {
                OrderProps.Discount = 0;
            }
            
            if (decimal.TryParse(textBoxDiscount.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal d))
            {
                OrderProps.Discount = d;
                CalcControlSums();
            }
            else
            {
                MessageBox.Show("Bitte gültigen Wert eingeben.", "Fehler", MessageBoxButtons.OK);
            }
        }

        private void TextBoxDiscount_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxDiscount.Focus();
        }

        private void TextBoxDiscount_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxDiscount.SelectAll();
            textBoxDiscount.Focus();
        }

        // 
        //  TextBox PricePayed
        //
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
            if (textBoxPricePayed.Text == String.Empty)
            {
                OrderProps.PricePayed = 0;
            }
            
            if (decimal.TryParse(textBoxPricePayed.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal d))
            {
                OrderProps.PricePayed = d;
                CalcControlSums();
            }
            else
            {
                MessageBox.Show("Bitte gültigen Wert eingeben.", "Fehler", MessageBoxButtons.OK);
            }
        }

        private void TextBoxPricePayed_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPricePayed.Focus();
        }

        private void TextBoxPricePayed_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxPricePayed.SelectAll();
            textBoxPricePayed.Focus();
        }

        // 
        //  TextBox Tip
        //
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
            if (textBoxTip.Text == String.Empty)
            {
                OrderProps.Tip = 0;
            }
            
            if (decimal.TryParse(textBoxTip.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal d))
            {
                OrderProps.Tip = d;
                CalcControlSums();
            }
            else
            {
                MessageBox.Show("Bitte gültigen Wert eingeben.", "Fehler", MessageBoxButtons.OK);
            }
        }

        private void TextBoxTip_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxTip.Focus();
        }

        private void TextBoxTip_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxTip.SelectAll();
            textBoxTip.Focus();
        }

        // 
        //  CheckBox Order
        //
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

                    textBoxArticle.Text = OrderProps.Articles;
                    break;

                case "CustomerName":
                    labelCustomerName.Text = OrderProps.CustomerName;
                    break;

                case "Price":
                    textBoxPrice.Text = OrderProps.Price.ToString("N2") + " € ";
                    break;

                case "Discount":
                    textBoxDiscount.Text = OrderProps.Discount.ToString("N2") + " € ";
                    break;

                //case "Credit":
                //    labelCredit.Text = OrderProps.Credit.ToString();
                //    break;

                case "PriceWithDiscount":
                    labelPriceWithDiscount.Text = OrderProps.PriceWithDiscount.ToString("N2") + " € ";
                    break;

                case "PricePayed":
                    textBoxPricePayed.Text = OrderProps.PricePayed.ToString("N2") + " € ";
                    break;

                case "Change":
                    labelChange.Text = OrderProps.Change.ToString("N2") + " € ";
                    break;

                case "Tip":
                    textBoxTip.Text = OrderProps.Tip.ToString("N2") + " € ";
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