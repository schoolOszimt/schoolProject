namespace VocableTrainer
{
    partial class VocableGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VocableGui));
            this.vocable_label = new System.Windows.Forms.Label();
            this.exit_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.skip_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.help_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.answer1_label = new MaterialSkin.Controls.MaterialLabel();
            this.answer2_label = new MaterialSkin.Controls.MaterialLabel();
            this.answer3_label = new MaterialSkin.Controls.MaterialLabel();
            this.answer4_label = new MaterialSkin.Controls.MaterialLabel();
            this.points_label = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // vocable_label
            // 
            this.vocable_label.AutoSize = true;
            this.vocable_label.BackColor = System.Drawing.Color.Transparent;
            this.vocable_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.vocable_label.ForeColor = System.Drawing.Color.White;
            this.vocable_label.Location = new System.Drawing.Point(229, 57);
            this.vocable_label.Name = "vocable_label";
            this.vocable_label.Size = new System.Drawing.Size(80, 25);
            this.vocable_label.TabIndex = 40;
            this.vocable_label.Text = "vocable";
            // 
            // exit_btn
            // 
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Depth = 0;
            this.exit_btn.Location = new System.Drawing.Point(312, 230);
            this.exit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Primary = true;
            this.exit_btn.Size = new System.Drawing.Size(76, 28);
            this.exit_btn.TabIndex = 33;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // skip_btn
            // 
            this.skip_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skip_btn.Depth = 0;
            this.skip_btn.Location = new System.Drawing.Point(230, 230);
            this.skip_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.skip_btn.Name = "skip_btn";
            this.skip_btn.Primary = true;
            this.skip_btn.Size = new System.Drawing.Size(76, 28);
            this.skip_btn.TabIndex = 27;
            this.skip_btn.Text = "Skip";
            this.skip_btn.UseVisualStyleBackColor = true;
            this.skip_btn.Click += new System.EventHandler(this.skip_btn_Click);
            // 
            // help_btn
            // 
            this.help_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_btn.Depth = 0;
            this.help_btn.Location = new System.Drawing.Point(148, 230);
            this.help_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.help_btn.Name = "help_btn";
            this.help_btn.Primary = true;
            this.help_btn.Size = new System.Drawing.Size(76, 28);
            this.help_btn.TabIndex = 26;
            this.help_btn.Text = "50:50";
            this.help_btn.UseVisualStyleBackColor = true;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(143, 95);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(19, 19);
            this.materialLabel1.TabIndex = 41;
            this.materialLabel1.Text = "A";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(143, 176);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(19, 19);
            this.materialLabel2.TabIndex = 42;
            this.materialLabel2.Text = "D";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(143, 150);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(19, 19);
            this.materialLabel3.TabIndex = 43;
            this.materialLabel3.Text = "C";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(143, 122);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(18, 19);
            this.materialLabel4.TabIndex = 44;
            this.materialLabel4.Text = "B";
            // 
            // answer1_label
            // 
            this.answer1_label.BackColor = System.Drawing.Color.Transparent;
            this.answer1_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer1_label.Depth = 0;
            this.answer1_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.answer1_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.answer1_label.Location = new System.Drawing.Point(168, 95);
            this.answer1_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.answer1_label.Name = "answer1_label";
            this.answer1_label.Size = new System.Drawing.Size(223, 19);
            this.answer1_label.TabIndex = 45;
            this.answer1_label.Text = "answer1";
            this.answer1_label.Click += new System.EventHandler(this.answer1_label_Click);
            // 
            // answer2_label
            // 
            this.answer2_label.BackColor = System.Drawing.Color.Transparent;
            this.answer2_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer2_label.Depth = 0;
            this.answer2_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.answer2_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.answer2_label.Location = new System.Drawing.Point(168, 122);
            this.answer2_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.answer2_label.Name = "answer2_label";
            this.answer2_label.Size = new System.Drawing.Size(223, 19);
            this.answer2_label.TabIndex = 46;
            this.answer2_label.Text = "answer2";
            this.answer2_label.Click += new System.EventHandler(this.answer2_label_Click);
            // 
            // answer3_label
            // 
            this.answer3_label.BackColor = System.Drawing.Color.Transparent;
            this.answer3_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer3_label.Depth = 0;
            this.answer3_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.answer3_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.answer3_label.Location = new System.Drawing.Point(168, 150);
            this.answer3_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.answer3_label.Name = "answer3_label";
            this.answer3_label.Size = new System.Drawing.Size(223, 19);
            this.answer3_label.TabIndex = 47;
            this.answer3_label.Text = "answer3";
            this.answer3_label.Click += new System.EventHandler(this.answer3_label_Click);
            // 
            // answer4_label
            // 
            this.answer4_label.BackColor = System.Drawing.Color.Transparent;
            this.answer4_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer4_label.Depth = 0;
            this.answer4_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.answer4_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.answer4_label.Location = new System.Drawing.Point(168, 176);
            this.answer4_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.answer4_label.Name = "answer4_label";
            this.answer4_label.Size = new System.Drawing.Size(223, 19);
            this.answer4_label.TabIndex = 48;
            this.answer4_label.Text = "answer4";
            this.answer4_label.Click += new System.EventHandler(this.answer4_label_Click);
            // 
            // points_label
            // 
            this.points_label.AutoSize = true;
            this.points_label.BackColor = System.Drawing.Color.Transparent;
            this.points_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points_label.ForeColor = System.Drawing.Color.White;
            this.points_label.Location = new System.Drawing.Point(244, 204);
            this.points_label.Name = "points_label";
            this.points_label.Size = new System.Drawing.Size(46, 18);
            this.points_label.TabIndex = 49;
            this.points_label.Text = "label1";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // VocableGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.points_label);
            this.Controls.Add(this.answer4_label);
            this.Controls.Add(this.answer3_label);
            this.Controls.Add(this.answer2_label);
            this.Controls.Add(this.answer1_label);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.vocable_label);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.skip_btn);
            this.Controls.Add(this.help_btn);
            this.Name = "VocableGui";
            this.Size = new System.Drawing.Size(546, 263);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label vocable_label;
        private MaterialSkin.Controls.MaterialRaisedButton exit_btn;
        private MaterialSkin.Controls.MaterialRaisedButton skip_btn;
        private MaterialSkin.Controls.MaterialRaisedButton help_btn;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialLabel materialLabel2;
        public MaterialSkin.Controls.MaterialLabel materialLabel3;
        public MaterialSkin.Controls.MaterialLabel materialLabel4;
        public MaterialSkin.Controls.MaterialLabel answer1_label;
        public MaterialSkin.Controls.MaterialLabel answer2_label;
        public MaterialSkin.Controls.MaterialLabel answer3_label;
        public MaterialSkin.Controls.MaterialLabel answer4_label;
        public System.Windows.Forms.Label points_label;
        public System.Windows.Forms.Timer timer;
    }
}
