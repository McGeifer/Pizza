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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comboBoxOrders = new System.Windows.Forms.ComboBox();
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxOrderManagement = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelTotalNumberOfOrders = new System.Windows.Forms.Label();
            this.labelTotalOrdersPrice = new System.Windows.Forms.Label();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.labelMaxTip = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.buttonHallOfFame = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.labelShareOfUnknown = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.labelShareOfSalad = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.labelShareOfPizza = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelAverageOrdersTip = new System.Windows.Forms.Label();
            this.labelTotalOrdersTip = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelAverageOrdersPrice = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonCloseOrder = new System.Windows.Forms.Button();
            this.panelOrderHead = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.panelOrderSums = new System.Windows.Forms.Panel();
            this.labelTotalTip = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labelTotalPricePayed = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelTotalPriceWithDiscount = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.timerAutoSave = new System.Windows.Forms.Timer(this.components);
            this.labelTotalPriceToPay = new System.Windows.Forms.Label();
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
            this.comboBoxOrders.Location = new System.Drawing.Point(8, 23);
            this.comboBoxOrders.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOrders.Name = "comboBoxOrders";
            this.comboBoxOrders.Size = new System.Drawing.Size(319, 24);
            this.comboBoxOrders.TabIndex = 0;
            this.comboBoxOrders.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOrders_SelectedIndexChanged);
            // 
            // buttonNewOrder
            // 
            this.buttonNewOrder.Location = new System.Drawing.Point(8, 57);
            this.buttonNewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Size = new System.Drawing.Size(105, 28);
            this.buttonNewOrder.TabIndex = 2;
            this.buttonNewOrder.Text = "Neu";
            this.buttonNewOrder.UseVisualStyleBackColor = true;
            this.buttonNewOrder.Click += new System.EventHandler(this.ButtonNewOrder_Click);
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Location = new System.Drawing.Point(228, 57);
            this.buttonDeleteOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(100, 28);
            this.buttonDeleteOrder.TabIndex = 3;
            this.buttonDeleteOrder.Text = "Löschen";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.ButtonDeleteOrder_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(121, 57);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 28);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // groupBoxOrderManagement
            // 
            this.groupBoxOrderManagement.Controls.Add(this.comboBoxOrders);
            this.groupBoxOrderManagement.Controls.Add(this.buttonSave);
            this.groupBoxOrderManagement.Controls.Add(this.buttonNewOrder);
            this.groupBoxOrderManagement.Controls.Add(this.buttonDeleteOrder);
            this.groupBoxOrderManagement.Location = new System.Drawing.Point(16, 15);
            this.groupBoxOrderManagement.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxOrderManagement.Name = "groupBoxOrderManagement";
            this.groupBoxOrderManagement.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxOrderManagement.Size = new System.Drawing.Size(336, 95);
            this.groupBoxOrderManagement.TabIndex = 5;
            this.groupBoxOrderManagement.TabStop = false;
            this.groupBoxOrderManagement.Text = "Bestellungen";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1137, 5);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 25);
            this.label18.TabIndex = 12;
            this.label18.Text = "Trinkgeld";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(4, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1320, 2);
            this.label10.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1244, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Bestellt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(639, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Rabatt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(939, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Bezahlt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1032, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Restgeld";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(737, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Summe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bestellung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Besteller";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Anz. Bestellungen";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 39);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Bestellwert (ges.)";
            // 
            // labelTotalNumberOfOrders
            // 
            this.labelTotalNumberOfOrders.Location = new System.Drawing.Point(188, 22);
            this.labelTotalNumberOfOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalNumberOfOrders.Name = "labelTotalNumberOfOrders";
            this.labelTotalNumberOfOrders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTotalNumberOfOrders.Size = new System.Drawing.Size(45, 20);
            this.labelTotalNumberOfOrders.TabIndex = 8;
            this.labelTotalNumberOfOrders.Text = "8888";
            this.labelTotalNumberOfOrders.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTotalOrdersPrice
            // 
            this.labelTotalOrdersPrice.Location = new System.Drawing.Point(168, 42);
            this.labelTotalOrdersPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalOrdersPrice.Name = "labelTotalOrdersPrice";
            this.labelTotalOrdersPrice.Size = new System.Drawing.Size(77, 20);
            this.labelTotalOrdersPrice.TabIndex = 9;
            this.labelTotalOrdersPrice.Text = "8888,88 €";
            this.labelTotalOrdersPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.Controls.Add(this.labelMaxTip);
            this.groupBoxStatistics.Controls.Add(this.label31);
            this.groupBoxStatistics.Controls.Add(this.buttonHallOfFame);
            this.groupBoxStatistics.Controls.Add(this.label29);
            this.groupBoxStatistics.Controls.Add(this.labelShareOfUnknown);
            this.groupBoxStatistics.Controls.Add(this.label27);
            this.groupBoxStatistics.Controls.Add(this.labelShareOfSalad);
            this.groupBoxStatistics.Controls.Add(this.label24);
            this.groupBoxStatistics.Controls.Add(this.labelShareOfPizza);
            this.groupBoxStatistics.Controls.Add(this.label22);
            this.groupBoxStatistics.Controls.Add(this.label17);
            this.groupBoxStatistics.Controls.Add(this.labelAverageOrdersTip);
            this.groupBoxStatistics.Controls.Add(this.labelTotalOrdersTip);
            this.groupBoxStatistics.Controls.Add(this.label16);
            this.groupBoxStatistics.Controls.Add(this.label15);
            this.groupBoxStatistics.Controls.Add(this.label14);
            this.groupBoxStatistics.Controls.Add(this.labelAverageOrdersPrice);
            this.groupBoxStatistics.Controls.Add(this.label13);
            this.groupBoxStatistics.Controls.Add(this.labelTotalOrdersPrice);
            this.groupBoxStatistics.Controls.Add(this.label11);
            this.groupBoxStatistics.Controls.Add(this.labelTotalNumberOfOrders);
            this.groupBoxStatistics.Controls.Add(this.label12);
            this.groupBoxStatistics.Location = new System.Drawing.Point(360, 15);
            this.groupBoxStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStatistics.Size = new System.Drawing.Size(996, 95);
            this.groupBoxStatistics.TabIndex = 7;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "Statistiken für Nerds und für mich";
            // 
            // labelMaxTip
            // 
            this.labelMaxTip.Location = new System.Drawing.Point(403, 21);
            this.labelMaxTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxTip.Name = "labelMaxTip";
            this.labelMaxTip.Size = new System.Drawing.Size(77, 20);
            this.labelMaxTip.TabIndex = 27;
            this.labelMaxTip.Text = "8888,88 €";
            this.labelMaxTip.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(259, 18);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(110, 20);
            this.label31.TabIndex = 26;
            this.label31.Text = "Top Trinkgeld";
            // 
            // buttonHallOfFame
            // 
            this.buttonHallOfFame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHallOfFame.Location = new System.Drawing.Point(775, 32);
            this.buttonHallOfFame.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHallOfFame.Name = "buttonHallOfFame";
            this.buttonHallOfFame.Size = new System.Drawing.Size(167, 34);
            this.buttonHallOfFame.TabIndex = 20;
            this.buttonHallOfFame.Text = "Hall of Fame && Shame";
            this.buttonHallOfFame.UseVisualStyleBackColor = true;
            this.buttonHallOfFame.Click += new System.EventHandler(this.ButtonHallOfFame_Click);
            // 
            // label29
            // 
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label29.Location = new System.Drawing.Point(711, 20);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(3, 62);
            this.label29.TabIndex = 24;
            this.label29.Text = "label29";
            // 
            // labelShareOfUnknown
            // 
            this.labelShareOfUnknown.Location = new System.Drawing.Point(643, 63);
            this.labelShareOfUnknown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShareOfUnknown.Name = "labelShareOfUnknown";
            this.labelShareOfUnknown.Size = new System.Drawing.Size(60, 20);
            this.labelShareOfUnknown.TabIndex = 23;
            this.labelShareOfUnknown.Text = "88,88 %";
            this.labelShareOfUnknown.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(499, 60);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(121, 20);
            this.label27.TabIndex = 22;
            this.label27.Text = "Anteil Sonstige";
            // 
            // labelShareOfSalad
            // 
            this.labelShareOfSalad.Location = new System.Drawing.Point(643, 42);
            this.labelShareOfSalad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShareOfSalad.Name = "labelShareOfSalad";
            this.labelShareOfSalad.Size = new System.Drawing.Size(60, 20);
            this.labelShareOfSalad.TabIndex = 21;
            this.labelShareOfSalad.Text = "88,88 %";
            this.labelShareOfSalad.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(499, 39);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(94, 20);
            this.label24.TabIndex = 20;
            this.label24.Text = "Anteil Salat";
            // 
            // labelShareOfPizza
            // 
            this.labelShareOfPizza.Location = new System.Drawing.Point(643, 22);
            this.labelShareOfPizza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShareOfPizza.Name = "labelShareOfPizza";
            this.labelShareOfPizza.Size = new System.Drawing.Size(60, 20);
            this.labelShareOfPizza.TabIndex = 19;
            this.labelShareOfPizza.Text = "88,88 %";
            this.labelShareOfPizza.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(499, 20);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 20);
            this.label22.TabIndex = 18;
            this.label22.Text = "Anteil Pizza";
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(488, 20);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(3, 62);
            this.label17.TabIndex = 17;
            this.label17.Text = "label17";
            // 
            // labelAverageOrdersTip
            // 
            this.labelAverageOrdersTip.Location = new System.Drawing.Point(403, 62);
            this.labelAverageOrdersTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAverageOrdersTip.Name = "labelAverageOrdersTip";
            this.labelAverageOrdersTip.Size = new System.Drawing.Size(77, 20);
            this.labelAverageOrdersTip.TabIndex = 16;
            this.labelAverageOrdersTip.Text = "8888,88 €";
            this.labelAverageOrdersTip.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTotalOrdersTip
            // 
            this.labelTotalOrdersTip.Location = new System.Drawing.Point(403, 42);
            this.labelTotalOrdersTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalOrdersTip.Name = "labelTotalOrdersTip";
            this.labelTotalOrdersTip.Size = new System.Drawing.Size(77, 20);
            this.labelTotalOrdersTip.TabIndex = 15;
            this.labelTotalOrdersTip.Text = "8888,88 €";
            this.labelTotalOrdersTip.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(280, 59);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 20);
            this.label16.TabIndex = 14;
            this.label16.Text = "Trinkgeld (Ø)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(259, 39);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 20);
            this.label15.TabIndex = 13;
            this.label15.Text = "Trinkgeld (ges.)";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(253, 20);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(3, 62);
            this.label14.TabIndex = 12;
            this.label14.Text = "label14";
            // 
            // labelAverageOrdersPrice
            // 
            this.labelAverageOrdersPrice.Location = new System.Drawing.Point(168, 62);
            this.labelAverageOrdersPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAverageOrdersPrice.Name = "labelAverageOrdersPrice";
            this.labelAverageOrdersPrice.Size = new System.Drawing.Size(77, 16);
            this.labelAverageOrdersPrice.TabIndex = 11;
            this.labelAverageOrdersPrice.Text = "8888,88 €";
            this.labelAverageOrdersPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 59);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Bestellwert (Ø)";
            // 
            // buttonCloseOrder
            // 
            this.buttonCloseOrder.Enabled = false;
            this.buttonCloseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseOrder.Location = new System.Drawing.Point(9, 23);
            this.buttonCloseOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCloseOrder.Name = "buttonCloseOrder";
            this.buttonCloseOrder.Size = new System.Drawing.Size(185, 34);
            this.buttonCloseOrder.TabIndex = 18;
            this.buttonCloseOrder.Text = "Bestellung abschließen";
            this.buttonCloseOrder.UseVisualStyleBackColor = true;
            this.buttonCloseOrder.Click += new System.EventHandler(this.ButtonCloseOrder_Click);
            // 
            // panelOrderHead
            // 
            this.panelOrderHead.AutoScroll = true;
            this.panelOrderHead.Controls.Add(this.label26);
            this.panelOrderHead.Controls.Add(this.label18);
            this.panelOrderHead.Controls.Add(this.label2);
            this.panelOrderHead.Controls.Add(this.label7);
            this.panelOrderHead.Controls.Add(this.label3);
            this.panelOrderHead.Controls.Add(this.label10);
            this.panelOrderHead.Controls.Add(this.label5);
            this.panelOrderHead.Controls.Add(this.label8);
            this.panelOrderHead.Controls.Add(this.label1);
            this.panelOrderHead.Controls.Add(this.label6);
            this.panelOrderHead.Controls.Add(this.label9);
            this.panelOrderHead.Location = new System.Drawing.Point(16, 117);
            this.panelOrderHead.Margin = new System.Windows.Forms.Padding(4);
            this.panelOrderHead.MinimumSize = new System.Drawing.Size(1340, 47);
            this.panelOrderHead.Name = "panelOrderHead";
            this.panelOrderHead.Size = new System.Drawing.Size(1340, 47);
            this.panelOrderHead.TabIndex = 13;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(827, 5);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(98, 25);
            this.label26.TabIndex = 13;
            this.label26.Text = "Guthaben";
            // 
            // panelOrder
            // 
            this.panelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelOrder.AutoScroll = true;
            this.panelOrder.AutoSize = true;
            this.panelOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelOrder.BackColor = System.Drawing.SystemColors.Control;
            this.panelOrder.Location = new System.Drawing.Point(16, 171);
            this.panelOrder.Margin = new System.Windows.Forms.Padding(4);
            this.panelOrder.MinimumSize = new System.Drawing.Size(1340, 50);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(1340, 50);
            this.panelOrder.TabIndex = 15;
            // 
            // panelOrderSums
            // 
            this.panelOrderSums.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelOrderSums.BackColor = System.Drawing.SystemColors.Control;
            this.panelOrderSums.Controls.Add(this.labelTotalPriceToPay);
            this.panelOrderSums.Controls.Add(this.buttonCloseOrder);
            this.panelOrderSums.Controls.Add(this.labelTotalTip);
            this.panelOrderSums.Controls.Add(this.label21);
            this.panelOrderSums.Controls.Add(this.labelTotalPricePayed);
            this.panelOrderSums.Controls.Add(this.label20);
            this.panelOrderSums.Controls.Add(this.labelTotalPriceWithDiscount);
            this.panelOrderSums.Controls.Add(this.label19);
            this.panelOrderSums.Controls.Add(this.label28);
            this.panelOrderSums.Location = new System.Drawing.Point(16, 234);
            this.panelOrderSums.Margin = new System.Windows.Forms.Padding(4);
            this.panelOrderSums.MinimumSize = new System.Drawing.Size(1340, 66);
            this.panelOrderSums.Name = "panelOrderSums";
            this.panelOrderSums.Size = new System.Drawing.Size(1340, 66);
            this.panelOrderSums.TabIndex = 14;
            // 
            // labelTotalTip
            // 
            this.labelTotalTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTip.Location = new System.Drawing.Point(1131, 33);
            this.labelTotalTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalTip.Name = "labelTotalTip";
            this.labelTotalTip.Size = new System.Drawing.Size(95, 25);
            this.labelTotalTip.TabIndex = 19;
            this.labelTotalTip.Text = "999,99 €";
            this.labelTotalTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(437, 33);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 25);
            this.label21.TabIndex = 13;
            this.label21.Text = "Gesamt";
            // 
            // labelTotalPricePayed
            // 
            this.labelTotalPricePayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPricePayed.Location = new System.Drawing.Point(927, 33);
            this.labelTotalPricePayed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalPricePayed.Name = "labelTotalPricePayed";
            this.labelTotalPricePayed.Size = new System.Drawing.Size(95, 25);
            this.labelTotalPricePayed.TabIndex = 16;
            this.labelTotalPricePayed.Text = "999,99 €";
            this.labelTotalPricePayed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(4, 14);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(1320, 2);
            this.label20.TabIndex = 14;
            // 
            // labelTotalPriceWithDiscount
            // 
            this.labelTotalPriceWithDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPriceWithDiscount.Location = new System.Drawing.Point(728, 33);
            this.labelTotalPriceWithDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalPriceWithDiscount.Name = "labelTotalPriceWithDiscount";
            this.labelTotalPriceWithDiscount.Size = new System.Drawing.Size(95, 25);
            this.labelTotalPriceWithDiscount.TabIndex = 14;
            this.labelTotalPriceWithDiscount.Text = "999,99 €";
            this.labelTotalPriceWithDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(4, 9);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(1320, 2);
            this.label19.TabIndex = 13;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(1128, 33);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(0, 25);
            this.label28.TabIndex = 18;
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerAutoSave
            // 
            this.timerAutoSave.Enabled = true;
            this.timerAutoSave.Interval = 600000;
            this.timerAutoSave.Tick += new System.EventHandler(this.TimerAutoSave_Tick);
            // 
            // labelTotalPriceToPay
            // 
            this.labelTotalPriceToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPriceToPay.Location = new System.Drawing.Point(1234, 33);
            this.labelTotalPriceToPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalPriceToPay.Name = "labelTotalPriceToPay";
            this.labelTotalPriceToPay.Size = new System.Drawing.Size(95, 25);
            this.labelTotalPriceToPay.TabIndex = 20;
            this.labelTotalPriceToPay.Text = "999,99 €";
            this.labelTotalPriceToPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1372, 316);
            this.Controls.Add(this.panelOrderSums);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.panelOrderHead);
            this.Controls.Add(this.groupBoxStatistics);
            this.Controls.Add(this.groupBoxOrderManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Die ewige Pizzaliste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
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
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxOrderManagement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTotalOrdersPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelTotalNumberOfOrders;
        private System.Windows.Forms.GroupBox groupBoxStatistics;
        private System.Windows.Forms.Label labelAverageOrdersPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelAverageOrdersTip;
        private System.Windows.Forms.Label labelTotalOrdersTip;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panelOrderHead;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Panel panelOrderSums;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelTotalTip;
        private System.Windows.Forms.Label labelTotalPricePayed;
        private System.Windows.Forms.Label labelTotalPriceWithDiscount;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Timer timerAutoSave;
        private System.Windows.Forms.Button buttonCloseOrder;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label labelShareOfUnknown;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label labelShareOfSalad;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label labelShareOfPizza;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelMaxTip;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button buttonHallOfFame;
        private System.Windows.Forms.Label labelTotalPriceToPay;
    }
}

