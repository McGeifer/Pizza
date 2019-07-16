namespace Pizza
{
    partial class FameAndShameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFameTip = new System.Windows.Forms.Label();
            this.labelShameTip = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelShameOrderCount = new System.Windows.Forms.Label();
            this.labelFameOrderCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelShameOrderSum = new System.Windows.Forms.Label();
            this.labelFameOrderSum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(491, 295);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(125, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Ich hab\'s begriffen!";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ø Trinkgeld";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFameTip
            // 
            this.labelFameTip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFameTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFameTip.Location = new System.Drawing.Point(12, 48);
            this.labelFameTip.Name = "labelFameTip";
            this.labelFameTip.Size = new System.Drawing.Size(200, 75);
            this.labelFameTip.TabIndex = 1;
            this.labelFameTip.Text = "1. Person A - 99,99 %\r\n2. Person B - 99,99 %\r\n3. Person C - 99,99 %";
            this.labelFameTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelShameTip
            // 
            this.labelShameTip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelShameTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShameTip.Location = new System.Drawing.Point(424, 48);
            this.labelShameTip.Name = "labelShameTip";
            this.labelShameTip.Size = new System.Drawing.Size(200, 75);
            this.labelShameTip.TabIndex = 2;
            this.labelShameTip.Text = "1. Person A - 99,99 %\r\n2. Person B - 99,99 %\r\n3. Person C - 99,99 %";
            this.labelShameTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.labelShameOrderCount);
            this.panel1.Controls.Add(this.labelFameOrderCount);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.labelShameOrderSum);
            this.panel1.Controls.Add(this.labelFameOrderSum);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelShameTip);
            this.panel1.Controls.Add(this.labelFameTip);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 290);
            this.panel1.TabIndex = 1;
            // 
            // labelShameOrderCount
            // 
            this.labelShameOrderCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelShameOrderCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShameOrderCount.Location = new System.Drawing.Point(424, 202);
            this.labelShameOrderCount.Name = "labelShameOrderCount";
            this.labelShameOrderCount.Size = new System.Drawing.Size(200, 75);
            this.labelShameOrderCount.TabIndex = 12;
            this.labelShameOrderCount.Text = "1. Person A - 99,99 %\r\n2. Person B - 99,99 %\r\n3. Person C - 99,99 %";
            this.labelShameOrderCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFameOrderCount
            // 
            this.labelFameOrderCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFameOrderCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFameOrderCount.Location = new System.Drawing.Point(12, 202);
            this.labelFameOrderCount.Name = "labelFameOrderCount";
            this.labelFameOrderCount.Size = new System.Drawing.Size(200, 75);
            this.labelFameOrderCount.TabIndex = 11;
            this.labelFameOrderCount.Text = "1. Person A - 99,99 %\r\n2. Person B - 99,99 %\r\n3. Person C - 99,99 %";
            this.labelFameOrderCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(218, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 75);
            this.label11.TabIndex = 10;
            this.label11.Text = "Anzahl Bestellungen";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelShameOrderSum
            // 
            this.labelShameOrderSum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelShameOrderSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShameOrderSum.Location = new System.Drawing.Point(424, 125);
            this.labelShameOrderSum.Name = "labelShameOrderSum";
            this.labelShameOrderSum.Size = new System.Drawing.Size(200, 75);
            this.labelShameOrderSum.TabIndex = 9;
            this.labelShameOrderSum.Text = "1. Person A - 99,99 %\r\n2. Person B - 99,99 %\r\n3. Person C - 99,99 %";
            this.labelShameOrderSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFameOrderSum
            // 
            this.labelFameOrderSum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFameOrderSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFameOrderSum.Location = new System.Drawing.Point(12, 125);
            this.labelFameOrderSum.Name = "labelFameOrderSum";
            this.labelFameOrderSum.Size = new System.Drawing.Size(200, 75);
            this.labelFameOrderSum.TabIndex = 8;
            this.labelFameOrderSum.Text = "1. Person A - 99,99 %\r\n2. Person B - 99,99 %\r\n3. Person C - 99,99 %";
            this.labelFameOrderSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(218, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 75);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ø Bestellwert";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Shame";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fame";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FameAndShameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 321);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FameAndShameForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFameTip;
        private System.Windows.Forms.Label labelShameTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelShameOrderCount;
        private System.Windows.Forms.Label labelFameOrderCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelShameOrderSum;
        private System.Windows.Forms.Label labelFameOrderSum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}