namespace VocableTrainer
{
    partial class vT_Form
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
            this.startMenu_uc1 = new VocableTrainer.startMenu_uc();
            this.vocableGui_uc1 = new VocableTrainer.vocableGui_uc();
            this.SuspendLayout();
            // 
            // startMenu_uc1
            // 
            this.startMenu_uc1.Location = new System.Drawing.Point(0, 64);
            this.startMenu_uc1.Name = "startMenu_uc1";
            this.startMenu_uc1.Size = new System.Drawing.Size(546, 263);
            this.startMenu_uc1.TabIndex = 0;
            // 
            // vocableGui_uc1
            // 
            this.vocableGui_uc1.Location = new System.Drawing.Point(0, 64);
            this.vocableGui_uc1.Name = "vocableGui_uc1";
            this.vocableGui_uc1.Size = new System.Drawing.Size(546, 263);
            this.vocableGui_uc1.TabIndex = 1;
            // 
            // vT_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 326);
            this.Controls.Add(this.startMenu_uc1);
            this.Controls.Add(this.vocableGui_uc1);
            this.MaximizeBox = false;
            this.Name = "vT_Form";
            this.Sizable = false;
            this.Text = "VocableTrainer";
            this.ResumeLayout(false);

        }

        #endregion

        private startMenu_uc startMenu_uc1;
        private vocableGui_uc vocableGui_uc1;
    }
}

