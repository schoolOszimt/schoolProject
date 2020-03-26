namespace VocableTrainer
{
    partial class MainMenu_uc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu_uc));
            this.pbo_VHSLogo = new System.Windows.Forms.PictureBox();
            this.btn_Beenden = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Info = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Start = new MaterialSkin.Controls.MaterialRaisedButton();
            this.toolTip_mainMenu = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbo_VHSLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbo_VHSLogo
            // 
            this.pbo_VHSLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbo_VHSLogo.ErrorImage = null;
            this.pbo_VHSLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbo_VHSLogo.Image")));
            this.pbo_VHSLogo.Location = new System.Drawing.Point(509, 309);
            this.pbo_VHSLogo.Margin = new System.Windows.Forms.Padding(6);
            this.pbo_VHSLogo.Name = "pbo_VHSLogo";
            this.pbo_VHSLogo.Size = new System.Drawing.Size(204, 100);
            this.pbo_VHSLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbo_VHSLogo.TabIndex = 17;
            this.pbo_VHSLogo.TabStop = false;
            this.toolTip_mainMenu.SetToolTip(this.pbo_VHSLogo, "https://berlin.de/vhs/");
            this.pbo_VHSLogo.Click += new System.EventHandler(this.pbo_VHSLogo_Click);
            // 
            // btn_Beenden
            // 
            this.btn_Beenden.BackColor = System.Drawing.Color.Gray;
            this.btn_Beenden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Beenden.Depth = 0;
            this.btn_Beenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Beenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Beenden.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Beenden.Location = new System.Drawing.Point(240, 224);
            this.btn_Beenden.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Beenden.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Beenden.Name = "btn_Beenden";
            this.btn_Beenden.Primary = true;
            this.btn_Beenden.Size = new System.Drawing.Size(223, 54);
            this.btn_Beenden.TabIndex = 3;
            this.btn_Beenden.Text = "BEENDEN";
            this.toolTip_mainMenu.SetToolTip(this.btn_Beenden, "Dieser Button beendet das Programm");
            this.btn_Beenden.UseVisualStyleBackColor = false;
            this.btn_Beenden.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.BackColor = System.Drawing.Color.Gray;
            this.btn_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Info.Depth = 0;
            this.btn_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Info.Location = new System.Drawing.Point(240, 160);
            this.btn_Info.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Info.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Primary = true;
            this.btn_Info.Size = new System.Drawing.Size(223, 52);
            this.btn_Info.TabIndex = 2;
            this.btn_Info.Text = "INFO";
            this.toolTip_mainMenu.SetToolTip(this.btn_Info, "Diese Button gibt dir weitere Infromationen über das Programm");
            this.btn_Info.UseVisualStyleBackColor = false;
            this.btn_Info.Click += new System.EventHandler(this.options_btn_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.White;
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Start.Depth = 0;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Start.Location = new System.Drawing.Point(240, 98);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Start.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Primary = true;
            this.btn_Start.Size = new System.Drawing.Size(223, 50);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Start";
            this.toolTip_mainMenu.SetToolTip(this.btn_Start, "Dieser Button startet die Lernaufgabe");
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // MainMenu_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.pbo_VHSLogo);
            this.Controls.Add(this.btn_Beenden);
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.btn_Start);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainMenu_uc";
            this.Size = new System.Drawing.Size(700, 400);
            ((System.ComponentModel.ISupportInitialize)(this.pbo_VHSLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbo_VHSLogo;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Beenden;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Info;
        public MaterialSkin.Controls.MaterialRaisedButton btn_Start;
        private System.Windows.Forms.ToolTip toolTip_mainMenu;
    }
}
