namespace VocableTrainer
{
    partial class vocableGui_uc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vocableGui_uc));
            this.answer2_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.answer1_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.answer3_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.answer4_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.points_label = new MaterialSkin.Controls.MaterialLabel();
            this.skip_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.help_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.exit_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.feedback_result = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vocable_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // answer2_btn
            // 
            this.answer2_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer2_btn.Depth = 0;
            this.answer2_btn.Location = new System.Drawing.Point(46, 17);
            this.answer2_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.answer2_btn.Name = "answer2_btn";
            this.answer2_btn.Primary = true;
            this.answer2_btn.Size = new System.Drawing.Size(172, 48);
            this.answer2_btn.TabIndex = 15;
            this.answer2_btn.Text = "answer2";
            this.answer2_btn.UseVisualStyleBackColor = true;
            this.answer2_btn.Click += new System.EventHandler(this.answer2_btn_Click);
            // 
            // answer1_btn
            // 
            this.answer1_btn.BackColor = System.Drawing.SystemColors.Control;
            this.answer1_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer1_btn.Depth = 0;
            this.answer1_btn.Location = new System.Drawing.Point(46, 126);
            this.answer1_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.answer1_btn.Name = "answer1_btn";
            this.answer1_btn.Primary = true;
            this.answer1_btn.Size = new System.Drawing.Size(172, 48);
            this.answer1_btn.TabIndex = 14;
            this.answer1_btn.Text = "answer1";
            this.answer1_btn.UseVisualStyleBackColor = false;
            this.answer1_btn.Click += new System.EventHandler(this.answer1_btn_Click);
            // 
            // answer3_btn
            // 
            this.answer3_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer3_btn.Depth = 0;
            this.answer3_btn.Location = new System.Drawing.Point(315, 17);
            this.answer3_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.answer3_btn.Name = "answer3_btn";
            this.answer3_btn.Primary = true;
            this.answer3_btn.Size = new System.Drawing.Size(172, 48);
            this.answer3_btn.TabIndex = 13;
            this.answer3_btn.Text = "answer3";
            this.answer3_btn.UseVisualStyleBackColor = true;
            this.answer3_btn.Click += new System.EventHandler(this.answer3_btn_Click);
            // 
            // answer4_btn
            // 
            this.answer4_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer4_btn.Depth = 0;
            this.answer4_btn.Location = new System.Drawing.Point(315, 126);
            this.answer4_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.answer4_btn.Name = "answer4_btn";
            this.answer4_btn.Primary = true;
            this.answer4_btn.Size = new System.Drawing.Size(172, 48);
            this.answer4_btn.TabIndex = 12;
            this.answer4_btn.Text = "answer4";
            this.answer4_btn.UseVisualStyleBackColor = true;
            this.answer4_btn.Click += new System.EventHandler(this.answer4_btn_Click);
            // 
            // points_label
            // 
            this.points_label.AutoSize = true;
            this.points_label.Depth = 0;
            this.points_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.points_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.points_label.Location = new System.Drawing.Point(245, 169);
            this.points_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.points_label.Name = "points_label";
            this.points_label.Size = new System.Drawing.Size(47, 19);
            this.points_label.TabIndex = 10;
            this.points_label.Text = "0/200";
            // 
            // skip_btn
            // 
            this.skip_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skip_btn.Depth = 0;
            this.skip_btn.Location = new System.Drawing.Point(82, 233);
            this.skip_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.skip_btn.Name = "skip_btn";
            this.skip_btn.Primary = true;
            this.skip_btn.Size = new System.Drawing.Size(76, 28);
            this.skip_btn.TabIndex = 9;
            this.skip_btn.Text = "Skip";
            this.skip_btn.UseVisualStyleBackColor = true;
            this.skip_btn.Click += new System.EventHandler(this.skip_btn_Click);
            // 
            // help_btn
            // 
            this.help_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_btn.Depth = 0;
            this.help_btn.Location = new System.Drawing.Point(3, 233);
            this.help_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.help_btn.Name = "help_btn";
            this.help_btn.Primary = true;
            this.help_btn.Size = new System.Drawing.Size(76, 28);
            this.help_btn.TabIndex = 8;
            this.help_btn.Text = "Help";
            this.help_btn.UseVisualStyleBackColor = true;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Depth = 0;
            this.exit_btn.Location = new System.Drawing.Point(467, 233);
            this.exit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Primary = true;
            this.exit_btn.Size = new System.Drawing.Size(76, 28);
            this.exit_btn.TabIndex = 16;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // feedback_result
            // 
            this.feedback_result.AutoSize = true;
            this.feedback_result.Depth = 0;
            this.feedback_result.Font = new System.Drawing.Font("Roboto", 11F);
            this.feedback_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.feedback_result.Location = new System.Drawing.Point(244, 135);
            this.feedback_result.MouseState = MaterialSkin.MouseState.HOVER;
            this.feedback_result.Name = "feedback_result";
            this.feedback_result.Size = new System.Drawing.Size(0, 19);
            this.feedback_result.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(371, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 103);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(276, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 82);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(105, 161);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(88, 106);
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 102);
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(455, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 105);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // vocable_label
            // 
            this.vocable_label.AutoSize = true;
            this.vocable_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.vocable_label.Location = new System.Drawing.Point(232, 88);
            this.vocable_label.Name = "vocable_label";
            this.vocable_label.Size = new System.Drawing.Size(80, 25);
            this.vocable_label.TabIndex = 25;
            this.vocable_label.Text = "vocable";
            // 
            // vocableGui_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vocable_label);
            this.Controls.Add(this.feedback_result);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.answer2_btn);
            this.Controls.Add(this.answer1_btn);
            this.Controls.Add(this.answer3_btn);
            this.Controls.Add(this.answer4_btn);
            this.Controls.Add(this.points_label);
            this.Controls.Add(this.skip_btn);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "vocableGui_uc";
            this.Size = new System.Drawing.Size(546, 263);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton skip_btn;
        private MaterialSkin.Controls.MaterialRaisedButton help_btn;
        private MaterialSkin.Controls.MaterialRaisedButton exit_btn;
        public MaterialSkin.Controls.MaterialRaisedButton answer2_btn;
        public MaterialSkin.Controls.MaterialRaisedButton answer1_btn;
        public MaterialSkin.Controls.MaterialRaisedButton answer3_btn;
        public MaterialSkin.Controls.MaterialRaisedButton answer4_btn;
        public MaterialSkin.Controls.MaterialLabel feedback_result;
        public MaterialSkin.Controls.MaterialLabel points_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label vocable_label;
    }
}
