﻿namespace Pizza
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
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxOrder = new System.Windows.Forms.TextBox();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.labelPriceWithDiscount = new System.Windows.Forms.Label();
            this.textBoxPricePayed = new System.Windows.Forms.TextBox();
            this.labelChange = new System.Windows.Forms.Label();
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.labelCredit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(4, 10);
            this.labelCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(93, 20);
            this.labelCustomerName.TabIndex = 0;
            this.labelCustomerName.Text = "Besteller 99";
            // 
            // textBoxOrder
            // 
            this.textBoxOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrder.Location = new System.Drawing.Point(100, 7);
            this.textBoxOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxOrder.Multiline = true;
            this.textBoxOrder.Name = "textBoxOrder";
            this.textBoxOrder.Size = new System.Drawing.Size(300, 26);
            this.textBoxOrder.TabIndex = 1;
            this.textBoxOrder.Text = "Bestellung";
            this.textBoxOrder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxOrder_MouseClick);
            this.textBoxOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxOrder_KeyPress);
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOrder.Location = new System.Drawing.Point(945, 14);
            this.checkBoxOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOrder.TabIndex = 5;
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            this.checkBoxOrder.Click += new System.EventHandler(this.CheckBoxOrder_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(407, 7);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(65, 26);
            this.textBoxPrice.TabIndex = 2;
            this.textBoxPrice.Text = "15,99 € ";
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxSum_MouseClick);
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPrice_KeyPress);
            this.textBoxPrice.Leave += new System.EventHandler(this.TextBoxPrice_Leave);
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscount.Location = new System.Drawing.Point(478, 7);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(65, 26);
            this.textBoxDiscount.TabIndex = 3;
            this.textBoxDiscount.Text = "15,99 € ";
            this.textBoxDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDiscount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxDiscount_MouseClick);
            this.textBoxDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDiscount_KeyPress);
            this.textBoxDiscount.Leave += new System.EventHandler(this.TextBoxDiscount_Leave);
            // 
            // labelPriceWithDiscount
            // 
            this.labelPriceWithDiscount.AutoSize = true;
            this.labelPriceWithDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceWithDiscount.Location = new System.Drawing.Point(620, 10);
            this.labelPriceWithDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPriceWithDiscount.Name = "labelPriceWithDiscount";
            this.labelPriceWithDiscount.Size = new System.Drawing.Size(62, 20);
            this.labelPriceWithDiscount.TabIndex = 0;
            this.labelPriceWithDiscount.Text = "15,99 €";
            this.labelPriceWithDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPricePayed
            // 
            this.textBoxPricePayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPricePayed.Location = new System.Drawing.Point(689, 7);
            this.textBoxPricePayed.Name = "textBoxPricePayed";
            this.textBoxPricePayed.Size = new System.Drawing.Size(65, 26);
            this.textBoxPricePayed.TabIndex = 4;
            this.textBoxPricePayed.Text = "15,99 € ";
            this.textBoxPricePayed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPricePayed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxPricePayed_MouseClick);
            this.textBoxPricePayed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPricePayed_KeyPress);
            this.textBoxPricePayed.Leave += new System.EventHandler(this.TextBoxPricePayed_Leave);
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.Location = new System.Drawing.Point(764, 10);
            this.labelChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(62, 20);
            this.labelChange.TabIndex = 0;
            this.labelChange.Text = "15,99 €";
            this.labelChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTip
            // 
            this.textBoxTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTip.Location = new System.Drawing.Point(843, 7);
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.Size = new System.Drawing.Size(65, 26);
            this.textBoxTip.TabIndex = 6;
            this.textBoxTip.Text = "15,99 € ";
            this.textBoxTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxTip_MouseClick);
            this.textBoxTip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxTip_KeyPress);
            this.textBoxTip.Leave += new System.EventHandler(this.TextBoxTip_Leave);
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredit.Location = new System.Drawing.Point(550, 10);
            this.labelCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(62, 20);
            this.labelCredit.TabIndex = 7;
            this.labelCredit.Text = "15,99 €";
            this.labelCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Controls.Add(this.textBoxOrder);
            this.Controls.Add(this.labelCustomerName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(975, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxOrder;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label labelPriceWithDiscount;
        private System.Windows.Forms.TextBox textBoxPricePayed;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.TextBox textBoxTip;
        private System.Windows.Forms.Label labelCredit;
    }
}
