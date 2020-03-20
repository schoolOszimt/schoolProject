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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu_uc));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.exit_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.options_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.start_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(63, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 102);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // exit_btn
            // 
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Depth = 0;
            this.exit_btn.Location = new System.Drawing.Point(206, 199);
            this.exit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Primary = true;
            this.exit_btn.Size = new System.Drawing.Size(190, 33);
            this.exit_btn.TabIndex = 14;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // options_btn
            // 
            this.options_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.options_btn.Depth = 0;
            this.options_btn.Location = new System.Drawing.Point(206, 149);
            this.options_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.options_btn.Name = "options_btn";
            this.options_btn.Primary = true;
            this.options_btn.Size = new System.Drawing.Size(190, 33);
            this.options_btn.TabIndex = 13;
            this.options_btn.Text = "About";
            this.options_btn.UseVisualStyleBackColor = true;
            this.options_btn.Click += new System.EventHandler(this.options_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.start_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_btn.Depth = 0;
            this.start_btn.Location = new System.Drawing.Point(206, 100);
            this.start_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.start_btn.Name = "start_btn";
            this.start_btn.Primary = true;
            this.start_btn.Size = new System.Drawing.Size(190, 33);
            this.start_btn.TabIndex = 12;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // MainMenu_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.options_btn);
            this.Controls.Add(this.start_btn);
            this.Name = "MainMenu_uc";
            this.Size = new System.Drawing.Size(571, 305);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialRaisedButton exit_btn;
        private MaterialSkin.Controls.MaterialRaisedButton options_btn;
        public MaterialSkin.Controls.MaterialRaisedButton start_btn;
    }
}
