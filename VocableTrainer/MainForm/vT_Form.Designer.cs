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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vT_Form));
            this.MainMenu_uc1 = new VocableTrainer.MainMenu_uc();
            this.vocableGui1 = new VocableTrainer.VocableGui();
            this.SuspendLayout();
            // 
            // MainMenu_uc1
            // 
            this.MainMenu_uc1.BackColor = System.Drawing.Color.White;
            this.MainMenu_uc1.Location = new System.Drawing.Point(0, 62);
            this.MainMenu_uc1.Name = "MainMenu_uc1";
            this.MainMenu_uc1.Size = new System.Drawing.Size(566, 304);
            this.MainMenu_uc1.TabIndex = 0;
            // 
            // vocableGui1
            // 
            this.vocableGui1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vocableGui1.BackgroundImage")));
            this.vocableGui1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vocableGui1.Location = new System.Drawing.Point(0, 62);
            this.vocableGui1.Name = "vocableGui1";
            this.vocableGui1.Size = new System.Drawing.Size(566, 304);
            this.vocableGui1.TabIndex = 1;
            // 
            // vT_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 366);
            this.Controls.Add(this.MainMenu_uc1);
            this.Controls.Add(this.vocableGui1);
            this.MaximizeBox = false;
            this.Name = "vT_Form";
            this.Sizable = false;
            this.Text = "VocableTrainer";
            this.ResumeLayout(false);

        }

        #endregion

        private MainMenu_uc MainMenu_uc1;
        private VocableGui vocableGui1;
    }
}

