namespace Pizza
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxOrders = new System.Windows.Forms.ComboBox();
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.groupBoxOrderManagement = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelTotalNumberOfOrders = new System.Windows.Forms.Label();
            this.labelTotalOrdersSum = new System.Windows.Forms.Label();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.labelAverageTip = new System.Windows.Forms.Label();
            this.labelTotalTips = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelAverageOrdersSum = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelOrderHead = new System.Windows.Forms.Panel();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.panelOrderSums = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBoxOrderManagement.SuspendLayout();
            this.groupBoxStatistics.SuspendLayout();
            this.panelOrderHead.SuspendLayout();
            this.panelOrderSums.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxOrders
            // 
            this.comboBoxOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrders.FormattingEnabled = true;
            this.comboBoxOrders.Location = new System.Drawing.Point(6, 19);
            this.comboBoxOrders.Name = "comboBoxOrders";
            this.comboBoxOrders.Size = new System.Drawing.Size(240, 21);
            this.comboBoxOrders.TabIndex = 0;
            this.comboBoxOrders.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOrders_SelectedIndexChanged);
            // 
            // buttonNewOrder
            // 
            this.buttonNewOrder.Location = new System.Drawing.Point(6, 46);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Size = new System.Drawing.Size(79, 23);
            this.buttonNewOrder.TabIndex = 2;
            this.buttonNewOrder.Text = "Neu";
            this.buttonNewOrder.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Location = new System.Drawing.Point(91, 46);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteOrder.TabIndex = 3;
            this.buttonDeleteOrder.Text = "Löschen";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // buttonConfig
            // 
            this.buttonConfig.Location = new System.Drawing.Point(172, 46);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonConfig.TabIndex = 4;
            this.buttonConfig.Text = "Optionen";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.ButtonConfig_Click);
            // 
            // groupBoxOrderManagement
            // 
            this.groupBoxOrderManagement.Controls.Add(this.comboBoxOrders);
            this.groupBoxOrderManagement.Controls.Add(this.buttonConfig);
            this.groupBoxOrderManagement.Controls.Add(this.buttonNewOrder);
            this.groupBoxOrderManagement.Controls.Add(this.buttonDeleteOrder);
            this.groupBoxOrderManagement.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOrderManagement.Name = "groupBoxOrderManagement";
            this.groupBoxOrderManagement.Size = new System.Drawing.Size(252, 77);
            this.groupBoxOrderManagement.TabIndex = 5;
            this.groupBoxOrderManagement.TabStop = false;
            this.groupBoxOrderManagement.Text = "Bestellungen";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(769, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 20);
            this.label18.TabIndex = 12;
            this.label18.Text = "Trinkgeld";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(3, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(910, 2);
            this.label10.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(849, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Bestellt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(479, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Rabatt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(620, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Bezahlt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(690, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Restgeld";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(551, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rabatt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(555, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "abzgl. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bestellung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Besteller";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Anz. Bestellungen";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(47, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Bestellwert";
            // 
            // labelTotalNumberOfOrders
            // 
            this.labelTotalNumberOfOrders.Location = new System.Drawing.Point(126, 18);
            this.labelTotalNumberOfOrders.Name = "labelTotalNumberOfOrders";
            this.labelTotalNumberOfOrders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTotalNumberOfOrders.Size = new System.Drawing.Size(34, 16);
            this.labelTotalNumberOfOrders.TabIndex = 8;
            this.labelTotalNumberOfOrders.Text = "8888";
            this.labelTotalNumberOfOrders.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTotalOrdersSum
            // 
            this.labelTotalOrdersSum.Location = new System.Drawing.Point(126, 34);
            this.labelTotalOrdersSum.Name = "labelTotalOrdersSum";
            this.labelTotalOrdersSum.Size = new System.Drawing.Size(58, 16);
            this.labelTotalOrdersSum.TabIndex = 9;
            this.labelTotalOrdersSum.Text = "8888,88 €";
            this.labelTotalOrdersSum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.Controls.Add(this.label17);
            this.groupBoxStatistics.Controls.Add(this.labelAverageTip);
            this.groupBoxStatistics.Controls.Add(this.labelTotalTips);
            this.groupBoxStatistics.Controls.Add(this.label16);
            this.groupBoxStatistics.Controls.Add(this.label15);
            this.groupBoxStatistics.Controls.Add(this.label14);
            this.groupBoxStatistics.Controls.Add(this.labelAverageOrdersSum);
            this.groupBoxStatistics.Controls.Add(this.label13);
            this.groupBoxStatistics.Controls.Add(this.labelTotalOrdersSum);
            this.groupBoxStatistics.Controls.Add(this.label11);
            this.groupBoxStatistics.Controls.Add(this.labelTotalNumberOfOrders);
            this.groupBoxStatistics.Controls.Add(this.label12);
            this.groupBoxStatistics.Location = new System.Drawing.Point(270, 12);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(680, 77);
            this.groupBoxStatistics.TabIndex = 7;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "Statistiken für Nerds und für mich";
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(354, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(2, 50);
            this.label17.TabIndex = 17;
            this.label17.Text = "label17";
            // 
            // labelAverageTip
            // 
            this.labelAverageTip.Location = new System.Drawing.Point(290, 50);
            this.labelAverageTip.Name = "labelAverageTip";
            this.labelAverageTip.Size = new System.Drawing.Size(58, 16);
            this.labelAverageTip.TabIndex = 16;
            this.labelAverageTip.Text = "8888,88 €";
            this.labelAverageTip.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTotalTips
            // 
            this.labelTotalTips.Location = new System.Drawing.Point(290, 34);
            this.labelTotalTips.Name = "labelTotalTips";
            this.labelTotalTips.Size = new System.Drawing.Size(58, 16);
            this.labelTotalTips.TabIndex = 15;
            this.labelTotalTips.Text = "8888,88 €";
            this.labelTotalTips.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(198, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "Trinkgeld (Ø)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(219, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 16);
            this.label15.TabIndex = 13;
            this.label15.Text = "Trinkgeld";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(190, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(2, 50);
            this.label14.TabIndex = 12;
            this.label14.Text = "label14";
            // 
            // labelAverageOrdersSum
            // 
            this.labelAverageOrdersSum.Location = new System.Drawing.Point(126, 50);
            this.labelAverageOrdersSum.Name = "labelAverageOrdersSum";
            this.labelAverageOrdersSum.Size = new System.Drawing.Size(58, 13);
            this.labelAverageOrdersSum.TabIndex = 11;
            this.labelAverageOrdersSum.Text = "8888,88 €";
            this.labelAverageOrdersSum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Bestellwert (Ø)";
            // 
            // panelOrderHead
            // 
            this.panelOrderHead.AutoScroll = true;
            this.panelOrderHead.Controls.Add(this.label18);
            this.panelOrderHead.Controls.Add(this.label2);
            this.panelOrderHead.Controls.Add(this.label7);
            this.panelOrderHead.Controls.Add(this.label3);
            this.panelOrderHead.Controls.Add(this.label4);
            this.panelOrderHead.Controls.Add(this.label10);
            this.panelOrderHead.Controls.Add(this.label5);
            this.panelOrderHead.Controls.Add(this.label8);
            this.panelOrderHead.Controls.Add(this.label1);
            this.panelOrderHead.Controls.Add(this.label6);
            this.panelOrderHead.Controls.Add(this.label9);
            this.panelOrderHead.Location = new System.Drawing.Point(12, 95);
            this.panelOrderHead.Name = "panelOrderHead";
            this.panelOrderHead.Size = new System.Drawing.Size(938, 59);
            this.panelOrderHead.TabIndex = 13;
            // 
            // panelOrder
            // 
            this.panelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelOrder.AutoScroll = true;
            this.panelOrder.AutoSize = true;
            this.panelOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelOrder.BackColor = System.Drawing.SystemColors.Control;
            this.panelOrder.Location = new System.Drawing.Point(12, 160);
            this.panelOrder.MinimumSize = new System.Drawing.Size(938, 41);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(938, 41);
            this.panelOrder.TabIndex = 15;
            // 
            // panelOrderSums
            // 
            this.panelOrderSums.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelOrderSums.BackColor = System.Drawing.SystemColors.Control;
            this.panelOrderSums.Controls.Add(this.label22);
            this.panelOrderSums.Controls.Add(this.label21);
            this.panelOrderSums.Controls.Add(this.label23);
            this.panelOrderSums.Controls.Add(this.label20);
            this.panelOrderSums.Controls.Add(this.label24);
            this.panelOrderSums.Controls.Add(this.label25);
            this.panelOrderSums.Controls.Add(this.label19);
            this.panelOrderSums.Controls.Add(this.label28);
            this.panelOrderSums.Location = new System.Drawing.Point(12, 219);
            this.panelOrderSums.MinimumSize = new System.Drawing.Size(938, 54);
            this.panelOrderSums.Name = "panelOrderSums";
            this.panelOrderSums.Size = new System.Drawing.Size(938, 54);
            this.panelOrderSums.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(323, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 20);
            this.label21.TabIndex = 13;
            this.label21.Text = "Gesamt";
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(3, 11);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(910, 2);
            this.label20.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(3, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(910, 2);
            this.label19.TabIndex = 13;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(771, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 20);
            this.label22.TabIndex = 19;
            this.label22.Text = "999,99€";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(615, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 20);
            this.label23.TabIndex = 16;
            this.label23.Text = "999,99 €";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(400, 27);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 20);
            this.label24.TabIndex = 13;
            this.label24.Text = "999,99 €";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(543, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 20);
            this.label25.TabIndex = 14;
            this.label25.Text = "999,99 €";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(846, 27);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(0, 20);
            this.label28.TabIndex = 18;
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(962, 285);
            this.Controls.Add(this.panelOrderSums);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.panelOrderHead);
            this.Controls.Add(this.groupBoxStatistics);
            this.Controls.Add(this.groupBoxOrderManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(978, 324);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Die ewige Pizzaliste";
            this.groupBoxOrderManagement.ResumeLayout(false);
            this.groupBoxStatistics.ResumeLayout(false);
            this.groupBoxStatistics.PerformLayout();
            this.panelOrderHead.ResumeLayout(false);
            this.panelOrderHead.PerformLayout();
            this.panelOrderSums.ResumeLayout(false);
            this.panelOrderSums.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOrders;
        private System.Windows.Forms.Button buttonNewOrder;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.GroupBox groupBoxOrderManagement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTotalOrdersSum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelTotalNumberOfOrders;
        private System.Windows.Forms.GroupBox groupBoxStatistics;
        private System.Windows.Forms.Label labelAverageOrdersSum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelAverageTip;
        private System.Windows.Forms.Label labelTotalTips;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panelOrderHead;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Panel panelOrderSums;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label28;
    }
}

