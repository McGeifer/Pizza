namespace Pizza
{
    partial class CustomerControl
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
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.labelSumWithDiscount = new System.Windows.Forms.Label();
            this.textBoxSumPayed = new System.Windows.Forms.TextBox();
            this.labelChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(4, 9);
            this.labelCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(85, 20);
            this.labelCustomerName.TabIndex = 0;
            this.labelCustomerName.Text = "Dominique";
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
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOrder.Location = new System.Drawing.Point(795, 14);
            this.checkBoxOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOrder.TabIndex = 5;
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            this.checkBoxOrder.CheckedChanged += new System.EventHandler(this.checkBoxOrder_CheckedChanged);
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(407, 7);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(65, 26);
            this.textBoxSum.TabIndex = 2;
            this.textBoxSum.Text = "15,99 € ";
            this.textBoxSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxSum_MouseClick);
            this.textBoxSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSum_KeyPress);
            this.textBoxSum.Leave += new System.EventHandler(this.TextBoxSum_Leave);
            // 
            // textBoxDiscount
            // 
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
            // labelSumWithDiscount
            // 
            this.labelSumWithDiscount.AutoSize = true;
            this.labelSumWithDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumWithDiscount.Location = new System.Drawing.Point(550, 10);
            this.labelSumWithDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSumWithDiscount.Name = "labelSumWithDiscount";
            this.labelSumWithDiscount.Size = new System.Drawing.Size(62, 20);
            this.labelSumWithDiscount.TabIndex = 0;
            this.labelSumWithDiscount.Text = "15,99 €";
            this.labelSumWithDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSumPayed
            // 
            this.textBoxSumPayed.Location = new System.Drawing.Point(619, 7);
            this.textBoxSumPayed.Name = "textBoxSumPayed";
            this.textBoxSumPayed.Size = new System.Drawing.Size(65, 26);
            this.textBoxSumPayed.TabIndex = 4;
            this.textBoxSumPayed.Text = "15,99 € ";
            this.textBoxSumPayed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSumPayed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxSumPayed_MouseClick);
            this.textBoxSumPayed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSumPayed_KeyPress);
            this.textBoxSumPayed.Leave += new System.EventHandler(this.TextBoxSumPayed_Leave);
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.Location = new System.Drawing.Point(704, 10);
            this.labelChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(49, 20);
            this.labelChange.TabIndex = 0;
            this.labelChange.Text = "15,99";
            this.labelChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.textBoxSumPayed);
            this.Controls.Add(this.labelSumWithDiscount);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.checkBoxOrder);
            this.Controls.Add(this.textBoxOrder);
            this.Controls.Add(this.labelCustomerName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerControl";
            this.Size = new System.Drawing.Size(814, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxOrder;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label labelSumWithDiscount;
        private System.Windows.Forms.TextBox textBoxSumPayed;
        private System.Windows.Forms.Label labelChange;
    }
}
