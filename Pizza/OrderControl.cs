using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class OrderControl : UserControl
    {
        #region properties

        private OrderProps _orderProps;
        private System.Windows.Forms.Button buttonNewCustomer;
        private System.Windows.Forms.TextBox textBoxNewCustomer;

        public OrderProps OrderProps
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

            this.labelCustomerName.Text = OrderProps.CustomerName;
            this.textBoxArticle.Text = OrderProps.Articles;
            this.textBoxPrice.Text = OrderProps.Price.ToString("N2") + " € ";
            this.textBoxDiscount.Text = OrderProps.Discount.ToString("N2") + " € ";
            this.labelCredit.Text = OrderProps.Credit.ToString("N2") + " € ";
            this.labelPriceWithDiscount.Text = OrderProps.PriceWithDiscount.ToString("N2") + " € ";
            this.textBoxPricePayed.Text = OrderProps.PricePayed.ToString("N2") + " € ";
            this.labelChange.Text = OrderProps.Change.ToString("N2") + " € ";
            this.textBoxTip.Text = OrderProps.Tip.ToString("N2") + " € ";
            this.checkBoxOrder.Checked = OrderProps.Ordered;

            OrderProps.ControlValueChanged += OrderProps_ControlValueChanged;
        }

        public OrderControl(string str)
        {
            // special control for adding a new customer
            if (str.Equals("NewCustomer"))
            {
                InitializeComponent();
                OrderProps = new OrderProps();

                this.labelCustomerName.Text = OrderProps.CustomerName;
                this.textBoxArticle.Text = OrderProps.Articles;
                this.textBoxPrice.Text = OrderProps.Price.ToString("N2") + " € ";
                this.textBoxDiscount.Text = OrderProps.Discount.ToString("N2") + " € ";
                this.labelCredit.Text = OrderProps.Credit.ToString("N2") + " € ";
                this.labelPriceWithDiscount.Text = OrderProps.PriceWithDiscount.ToString("N2") + " € ";
                this.textBoxPricePayed.Text = OrderProps.PricePayed.ToString("N2") + " € ";
                this.labelChange.Text = OrderProps.Change.ToString("N2") + " € ";
                this.textBoxTip.Text = OrderProps.Tip.ToString("N2") + " € ";
                this.checkBoxOrder.Checked = OrderProps.Ordered;

                this.labelCustomerName.Visible = false;

                // create new button
                this.SuspendLayout();

                this.buttonNewCustomer = new System.Windows.Forms.Button
                {
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Location = new System.Drawing.Point(0, 6),
                    Name = "buttonNewCustomer",
                    Size = new System.Drawing.Size(93, 28),
                    TabIndex = 0,
                    Text = "Neu",
                    UseVisualStyleBackColor = true
                };

                this.buttonNewCustomer.Click += new System.EventHandler(this.ButtonNewCustomer_Click);
                this.Controls.Add(buttonNewCustomer);

                // disable all other controls
                this.textBoxArticle.Enabled = false;
                this.textBoxPrice.Enabled = false;
                this.textBoxDiscount.Enabled = false;
                this.labelCredit.Enabled = false;
                this.labelPriceWithDiscount.Enabled = false;
                this.textBoxPricePayed.Enabled = false;
                this.labelChange.Enabled = false;
                this.textBoxTip.Enabled = false;
                this.checkBoxOrder.Enabled = false;

                this.ResumeLayout();
            }
        }

        #endregion

        #region methods

        private void AddContextMenu()
        {
            ContextMenu orderControlContextMenu = new ContextMenu();
            orderControlContextMenu.MenuItems.Add("Besteller entfernen");
            this.ContextMenu = orderControlContextMenu;
        }

        public void OrderControlDisable()
        {
            textBoxPrice.Enabled = false;
            textBoxDiscount.Enabled = false;
            textBoxPricePayed.Enabled = false;
            textBoxTip.Enabled = false;

            if (!this.OrderProps.Articles.Equals(String.Empty))
            {
                textBoxArticle.Enabled = false;
                
            }
            else
            {
                checkBoxOrder.Enabled = false;
            }
        }

        public void OrderControlEnable()
        {
            textBoxArticle.Enabled = true;
            textBoxPrice.Enabled = true;
            textBoxDiscount.Enabled = true;
            textBoxPricePayed.Enabled = true;
            textBoxTip.Enabled = true;
            checkBoxOrder.Enabled = true;
        }

        public void CalcControlSums()
        {
            OrderProps.PriceWithDiscount = OrderProps.Price - OrderProps.Discount;
            OrderProps.Change = (OrderProps.Credit + OrderProps.PricePayed - OrderProps.Tip) - OrderProps.PriceWithDiscount;
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

        private void ShowToolTip(TextBox textBox, string message)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Show(message, textBox, textBox.Width, textBox.Height, 3000);
        }

        #endregion

        #region event handler

        public event EventHandler OrderControlChanged;
        public event EventHandler OrderControlToBeRemoved;
        public event EventHandler OrderControlNewCustomer;
        public event EventHandler OrderControlOrderClosed;

        private void ButtonNewCustomer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResultNewCustomer = MessageBox.Show("Neuen Besteller anlegen?", "Hinweis", MessageBoxButtons.YesNo);

            if (dialogResultNewCustomer == DialogResult.Yes)
            {
                this.SuspendLayout();
                this.buttonNewCustomer.Visible = false;

                this.textBoxNewCustomer = new TextBox
                {
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Location = new System.Drawing.Point(0, 6),
                    Margin = new System.Windows.Forms.Padding(4, 5, 4, 5),
                    Multiline = true,
                    Name = "textBoxArticle",
                    Size = new System.Drawing.Size(93, 28),
                    TabIndex = 1,
                    Text = "Bestellung"

                };

                this.textBoxNewCustomer.KeyPress += TextBoxNewCustomer_KeyPress;
                this.textBoxNewCustomer.Leave += TextBoxNewCustomer_Leave;

                this.Controls.Add(textBoxNewCustomer);
                this.ResumeLayout();
                this.textBoxNewCustomer.SelectAll();
                this.textBoxNewCustomer.Focus();
            }
        }

        private void TextBoxNewCustomer_Leave(object sender, EventArgs e)
        {
            if (this.textBoxNewCustomer.Text.Length >= 2)
            {
                this.textBoxNewCustomer.Leave -= TextBoxNewCustomer_Leave;
                OnOrderControlNewCustomer(textBoxNewCustomer.Text, e);
            }
            else
            {
                ShowToolTip(textBoxNewCustomer, "Name des Besteller muss mindestens 2 Zeichen lang sein!");
                this.textBoxNewCustomer.SelectAll();
                this.textBoxNewCustomer.Focus();
            }
        }

        private void TextBoxNewCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBoxInputConfirmed(e))
            {
                TextBoxNewCustomer_Leave(sender, e);
            }
        }

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

        // 
        //  TextBox Article
        //
        private void TextBoxArticle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBoxInputConfirmed(e))
            {
                
                e.Handled = true;
            }
        }

        private void TextBoxArticle_Leave(object sender, EventArgs e)
        {
            if (!textBoxArticle.Text.Equals(OrderProps.Articles))
            {
                OrderProps.Articles = textBoxArticle.Text;
                textBoxPrice.Focus();
                textBoxPrice.SelectAll();
            }
        }

        // 
        //  TextBox Price
        //
        private void TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBoxInputConfirmed(e))
            {
                e.Handled = true;
                textBoxDiscount.SelectAll();
                textBoxDiscount.Focus();
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

        private void TextBoxPrice_Leave(object sender, EventArgs e)
        {
            if (textBoxPrice.Text == String.Empty)
            {
                OrderProps.Price = 0;
            }

            if (decimal.TryParse(textBoxPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal val))
            {
                if (val < OrderProps.Discount)
                {
                    OrderProps.Discount = 0;
                    ShowToolTip(textBoxDiscount, "Wert prüfen!");
                }

                OrderProps.Price = val;
                CalcControlSums();
            }
            else
            {
                ShowToolTip(textBoxDiscount, "Bitte gültigen Wert eingeben.");
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
                textBoxPricePayed.SelectAll();
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

            if (decimal.TryParse(textBoxDiscount.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal val))
            {
                if (val <= OrderProps.Price)
                {
                    OrderProps.Discount = val;
                    CalcControlSums();
                }
                else
                {
                    ShowToolTip(textBoxDiscount, "Rabatt größer als Preis");
                    textBoxDiscount.Text = OrderProps.Discount.ToString("N2") + " € ";
                    textBoxDiscount.SelectAll();
                    textBoxDiscount.Focus();
                }
            }
            else
            {
                ShowToolTip(textBoxDiscount, "Bitte gültigen Wert eingeben.");
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
                textBoxTip.SelectAll();
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

            if (decimal.TryParse(textBoxPricePayed.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal val))
            {
                if (OrderProps.PriceWithDiscount > OrderProps.Credit || val == 0)
                {
                    OrderProps.PricePayed = val;
                    CalcControlSums();
                }
                else
                {
                    ShowToolTip(textBoxPricePayed, "Guthaben deckt Summe");
                    OrderProps.PricePayed = 0;
                }
            }
            else
            {
                ShowToolTip(textBoxPricePayed, "Bitte gültigen Wert eingeben.");
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

            if (decimal.TryParse(textBoxTip.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal val))
            {
                if (OrderProps.Change - val >= 0)
                {
                    OrderProps.Tip = val;
                    CalcControlSums();
                }
                else
                {
                    ShowToolTip(textBoxTip, "Trinkgeld größer Restgeld");
                }
            }
            else
            {
                ShowToolTip(textBoxTip, "Bitte gültigen Wert eingeben!");
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
            if (checkBoxOrder.Checked)
            {
                if (this.OrderProps.Change < 0)
                {
                    MessageBox.Show("Posten nicht bezahlt!", "Fehler", MessageBoxButtons.OK);
                    this.OrderProps.Ordered = false;
                }
                else
                {
                    this.OrderProps.Ordered = true;
                    OrderControlDisable();
                }
            }
            else
            {
                checkBoxOrder.Checked = true;
                DialogResult dialogResult = MessageBox.Show("Bestellt Markierung wirklich aufheben?", "Warnung", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    this.OrderProps.Ordered = false;
                    OrderControlEnable();
                }
            }

            OnOrderControlOrderClosed(sender, e);
        }

        private void ToolStripMenuItemDeleteCustomer_Click(object sender, EventArgs e)
        {
            OnControlToBeRemoved(this, EventArgs.Empty);
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
                    if (OrderProps.Articles.Equals(String.Empty))
                    {
                        this.textBoxPrice.Enabled = false;
                        this.textBoxDiscount.Enabled = false;
                        this.labelCredit.Enabled = false;
                        this.labelPriceWithDiscount.Enabled = false;
                        this.textBoxPricePayed.Enabled = false;
                        this.labelChange.Enabled = false;
                        this.textBoxTip.Enabled = false;
                        this.checkBoxOrder.Enabled = false;
                    }
                    else
                    {
                        this.textBoxPrice.Enabled = true;
                        this.textBoxDiscount.Enabled = true;
                        this.labelCredit.Enabled = true;
                        this.labelPriceWithDiscount.Enabled = true;
                        this.textBoxPricePayed.Enabled = true;
                        this.labelChange.Enabled = true;
                        this.textBoxTip.Enabled = true;
                        this.checkBoxOrder.Enabled = true;
                    }

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

        protected virtual void OnControlToBeRemoved(OrderControl orderCrtl, EventArgs e)
        {
            EventHandler orderControlToBeRemoved = OrderControlToBeRemoved;

            if (orderControlToBeRemoved != null)
            {
                orderControlToBeRemoved(orderCrtl, e);
            }
        }

        protected virtual void OnOrderControlNewCustomer(string customerName, EventArgs e)
        {
            EventHandler orderControlNewCustomer = OrderControlNewCustomer;

            if (orderControlNewCustomer != null)
            {
                orderControlNewCustomer(customerName, e);
            }
        }

        protected virtual void OnOrderControlOrderClosed(object obj, EventArgs e)
        {
            EventHandler orderControlOrderClosed = OrderControlOrderClosed;

            if (orderControlOrderClosed != null)
            {
                orderControlOrderClosed(obj, e);
            }
        }
        #endregion
    }
}