namespace Pizza
{
    partial class LoadScreen
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
            this.labelLoadingData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLoadingData
            // 
            this.labelLoadingData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLoadingData.AutoSize = true;
            this.labelLoadingData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadingData.Location = new System.Drawing.Point(105, 10);
            this.labelLoadingData.Name = "labelLoadingData";
            this.labelLoadingData.Size = new System.Drawing.Size(318, 31);
            this.labelLoadingData.TabIndex = 0;
            this.labelLoadingData.Text = "Lade Daten, bitte warten.";
            this.labelLoadingData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.labelLoadingData);
            this.MinimumSize = new System.Drawing.Size(500, 50);
            this.Name = "LoadScreen";
            this.Size = new System.Drawing.Size(500, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoadingData;
    }
}
