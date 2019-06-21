namespace Pizza
{
    partial class OrderControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.contextMenuStripDeleteCustomer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDeleteCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxArticle = new System.Windows.Forms.TextBox();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.labelPriceWithDiscount = new System.Windows.Forms.Label();
            this.textBoxPricePayed = new System.Windows.Forms.TextBox();
            this.labelChange = new System.Windows.Forms.Label();
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.labelCredit = new System.Windows.Forms.Label();
            this.contextMenuStripDeleteCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.ContextMenuStrip = this.contextMenuStripDeleteCustomer;
            this.labelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(4, 10);
            this.labelCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(93, 20);
            this.labelCustomerName.TabIndex = 0;
            this.labelCustomerName.Text = "Besteller 99";
            // 
            // contextMenuStripDeleteCustomer
            // 
            this.contextMenuStripDeleteCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDeleteCustomer});
            this.contextMenuStripDeleteCustomer.Name = "contextMenuStripDeleteCustomer";
            this.contextMenuStripDeleteCustomer.ShowImageMargin = false;
            this.contextMenuStripDeleteCustomer.ShowItemToolTips = false;
            this.contextMenuStripDeleteCustomer.Size = new System.Drawing.Size(156, 48);
            this.contextMenuStripDeleteCustomer.Text = "Besteller entfernen";
            // 
            // toolStripMenuItemDeleteCustomer
            // 
            this.toolStripMenuItemDeleteCustomer.Name = "toolStripMenuItemDeleteCustomer";
            this.toolStripMenuItemDeleteCustomer.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemDeleteCustomer.Text = "Besteller entfernen";
            this.toolStripMenuItemDeleteCustomer.Click += new System.EventHandler(this.ToolStripMenuItemDeleteCustomer_Click);
            // 
            // textBoxArticle
            // 
            this.textBoxArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArticle.Location = new System.Drawing.Point(100, 7);
            this.textBoxArticle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxArticle.Multiline = true;
            this.textBoxArticle.Name = "textBoxArticle";
            this.textBoxArticle.Size = new System.Drawing.Size(300, 26);
            this.textBoxArticle.TabIndex = 1;
            this.textBoxArticle.Text = "Bestellung";
            this.textBoxArticle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxArticle_KeyPress);
            this.textBoxArticle.Leave += new System.EventHandler(this.TextBoxArticle_Leave);
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOrder.Location = new System.Drawing.Point(945, 14);
            this.checkBoxOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOrder.TabIndex = 6;
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            this.checkBoxOrder.Click += new System.EventHandler(this.CheckBoxOrder_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(407, 7);
            this.textBoxPrice.MaxLength = 5;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(65, 26);
            this.textBoxPrice.TabIndex = 2;
            this.textBoxPrice.Text = "0,00 € ";
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxPrice_MouseClick);
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPrice_KeyPress);
            this.textBoxPrice.Leave += new System.EventHandler(this.TextBoxPrice_Leave);
            this.textBoxPrice.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxPrice_MouseDoubleClick);
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscount.Location = new System.Drawing.Point(478, 7);
            this.textBoxDiscount.MaxLength = 5;
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(65, 26);
            this.textBoxDiscount.TabIndex = 3;
            this.textBoxDiscount.Text = "0,00 € ";
            this.textBoxDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDiscount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxDiscount_MouseClick);
            this.textBoxDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDiscount_KeyPress);
            this.textBoxDiscount.Leave += new System.EventHandler(this.TextBoxDiscount_Leave);
            this.textBoxDiscount.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxDiscount_MouseDoubleClick);
            // 
            // labelPriceWithDiscount
            // 
            this.labelPriceWithDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceWithDiscount.Location = new System.Drawing.Point(620, 10);
            this.labelPriceWithDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPriceWithDiscount.Name = "labelPriceWithDiscount";
            this.labelPriceWithDiscount.Size = new System.Drawing.Size(62, 20);
            this.labelPriceWithDiscount.TabIndex = 0;
            this.labelPriceWithDiscount.Text = "0,00 € ";
            this.labelPriceWithDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPricePayed
            // 
            this.textBoxPricePayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPricePayed.Location = new System.Drawing.Point(689, 7);
            this.textBoxPricePayed.MaxLength = 5;
            this.textBoxPricePayed.Name = "textBoxPricePayed";
            this.textBoxPricePayed.Size = new System.Drawing.Size(65, 26);
            this.textBoxPricePayed.TabIndex = 4;
            this.textBoxPricePayed.Text = "0,00 € ";
            this.textBoxPricePayed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPricePayed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxPricePayed_MouseClick);
            this.textBoxPricePayed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPricePayed_KeyPress);
            this.textBoxPricePayed.Leave += new System.EventHandler(this.TextBoxPricePayed_Leave);
            this.textBoxPricePayed.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxPricePayed_MouseDoubleClick);
            // 
            // labelChange
            // 
            this.labelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.Location = new System.Drawing.Point(764, 10);
            this.labelChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(62, 20);
            this.labelChange.TabIndex = 0;
            this.labelChange.Text = "0,00 € ";
            this.labelChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTip
            // 
            this.textBoxTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTip.Location = new System.Drawing.Point(843, 7);
            this.textBoxTip.MaxLength = 5;
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.Size = new System.Drawing.Size(65, 26);
            this.textBoxTip.TabIndex = 5;
            this.textBoxTip.Text = "0,00 € ";
            this.textBoxTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxTip_MouseClick);
            this.textBoxTip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxTip_KeyPress);
            this.textBoxTip.Leave += new System.EventHandler(this.TextBoxTip_Leave);
            this.textBoxTip.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxTip_MouseDoubleClick);
            // 
            // labelCredit
            // 
            this.labelCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredit.Location = new System.Drawing.Point(550, 10);
            this.labelCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(62, 20);
            this.labelCredit.TabIndex = 7;
            this.labelCredit.Text = "0,00 € ";
            this.labelCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.labelCredit);
            this.Controls.Add(this.textBoxTip);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.textBoxPricePayed);
            this.Controls.Add(this.labelPriceWithDiscount);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.checkBoxOrder);
            this.Controls.Add(this.textBoxArticle);
            this.Controls.Add(this.labelCustomerName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(975, 41);
            this.contextMenuStripDeleteCustomer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxArticle;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label labelPriceWithDiscount;
        private System.Windows.Forms.TextBox textBoxPricePayed;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.TextBox textBoxTip;
        private System.Windows.Forms.Label labelCredit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDeleteCustomer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteCustomer;
    }
}
