﻿namespace VocableTrainer
{
    partial class mfrm_VocTrainerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mfrm_VocTrainerForm));
            this.mmuc_StartUC = new VocableTrainer.MainMenu_uc();
            this.vgui_VocGui = new VocableTrainer.VocableGui();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mmuc_StartUC
            // 
            this.mmuc_StartUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.mmuc_StartUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmuc_StartUC.Location = new System.Drawing.Point(0, 61);
            this.mmuc_StartUC.Margin = new System.Windows.Forms.Padding(6);
            this.mmuc_StartUC.Name = "mmuc_StartUC";
            this.mmuc_StartUC.Size = new System.Drawing.Size(700, 393);
            this.mmuc_StartUC.TabIndex = 0;
            // 
            // vgui_VocGui
            // 
            this.vgui_VocGui.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vgui_VocGui.BackgroundImage")));
            this.vgui_VocGui.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vgui_VocGui.Location = new System.Drawing.Point(0, 61);
            this.vgui_VocGui.Name = "vgui_VocGui";
            this.vgui_VocGui.Size = new System.Drawing.Size(700, 393);
            this.vgui_VocGui.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(261, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vokabeltrainer - VHS";
            // 
            // mfrm_VocTrainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mmuc_StartUC);
            this.Controls.Add(this.vgui_VocGui);
            this.MaximizeBox = false;
            this.Name = "mfrm_VocTrainerForm";
            this.Sizable = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainMenu_uc mmuc_StartUC;
        private VocableGui vgui_VocGui;
        private System.Windows.Forms.Label label1;
    }
}

