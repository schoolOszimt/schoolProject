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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.answer2_label = new MaterialSkin.Controls.MaterialLabel();
            this.answer3_label = new MaterialSkin.Controls.MaterialLabel();
            this.answer4_label = new MaterialSkin.Controls.MaterialLabel();
            this.points_label = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.answer1_label = new MaterialSkin.Controls.MaterialLabel();
            this.pnl_Antworten = new System.Windows.Forms.Panel();
            this.pnl_Background = new System.Windows.Forms.Panel();
            this.pnl_Punkte = new System.Windows.Forms.Panel();
            this.pnl_Optionen = new System.Windows.Forms.Panel();
            this.pnl_Abstand = new System.Windows.Forms.Panel();
            this.pnl_Antworten.SuspendLayout();
            this.pnl_Background.SuspendLayout();
            this.pnl_Punkte.SuspendLayout();
            this.pnl_Optionen.SuspendLayout();
            this.SuspendLayout();
            // 
            // vocable_label
            // 
            this.vocable_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vocable_label.BackColor = System.Drawing.Color.Transparent;
            this.vocable_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vocable_label.ForeColor = System.Drawing.Color.White;
            this.vocable_label.Location = new System.Drawing.Point(33, 10);
            this.vocable_label.Name = "vocable_label";
            this.vocable_label.Size = new System.Drawing.Size(258, 25);
            this.vocable_label.TabIndex = 1;
            this.vocable_label.Text = "vocable";
            this.vocable_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exit_btn
            // 
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Depth = 0;
            this.exit_btn.Location = new System.Drawing.Point(215, 3);
            this.exit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Primary = true;
            this.exit_btn.Size = new System.Drawing.Size(76, 28);
            this.exit_btn.TabIndex = 8;
            this.exit_btn.Text = "zurück";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // skip_btn
            // 
            this.skip_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skip_btn.Depth = 0;
            this.skip_btn.Location = new System.Drawing.Point(129, 3);
            this.skip_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.skip_btn.Name = "skip_btn";
            this.skip_btn.Primary = true;
            this.skip_btn.Size = new System.Drawing.Size(76, 28);
            this.skip_btn.TabIndex = 7;
            this.skip_btn.Text = "Weiter";
            this.skip_btn.UseVisualStyleBackColor = true;
            this.skip_btn.Click += new System.EventHandler(this.skip_btn_Click);
            // 
            // help_btn
            // 
            this.help_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_btn.Depth = 0;
            this.help_btn.Location = new System.Drawing.Point(42, 3);
            this.help_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.help_btn.Name = "help_btn";
            this.help_btn.Primary = true;
            this.help_btn.Size = new System.Drawing.Size(76, 28);
            this.help_btn.TabIndex = 6;
            this.help_btn.Text = "50:50";
            this.help_btn.UseVisualStyleBackColor = true;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
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
            this.materialLabel2.Size = new System.Drawing.Size(0, 19);
            this.materialLabel2.TabIndex = 42;
            // 
            // answer2_label
            // 
            this.answer2_label.BackColor = System.Drawing.Color.Transparent;
            this.answer2_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer2_label.Depth = 0;
            this.answer2_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.answer2_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.answer2_label.Location = new System.Drawing.Point(3, 27);
            this.answer2_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.answer2_label.Name = "answer2_label";
            this.answer2_label.Size = new System.Drawing.Size(252, 19);
            this.answer2_label.TabIndex = 3;
            this.answer2_label.Text = "answer2";
            this.answer2_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.answer2_label.Click += new System.EventHandler(this.answer2_label_Click);
            // 
            // answer3_label
            // 
            this.answer3_label.BackColor = System.Drawing.Color.Transparent;
            this.answer3_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer3_label.Depth = 0;
            this.answer3_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.answer3_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.answer3_label.Location = new System.Drawing.Point(3, 54);
            this.answer3_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.answer3_label.Name = "answer3_label";
            this.answer3_label.Size = new System.Drawing.Size(252, 19);
            this.answer3_label.TabIndex = 4;
            this.answer3_label.Text = "answer3";
            this.answer3_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.answer3_label.Click += new System.EventHandler(this.answer3_label_Click);
            // 
            // answer4_label
            // 
            this.answer4_label.BackColor = System.Drawing.Color.Transparent;
            this.answer4_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer4_label.Depth = 0;
            this.answer4_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.answer4_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.answer4_label.Location = new System.Drawing.Point(3, 82);
            this.answer4_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.answer4_label.Name = "answer4_label";
            this.answer4_label.Size = new System.Drawing.Size(252, 19);
            this.answer4_label.TabIndex = 5;
            this.answer4_label.Text = "answer4";
            this.answer4_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.answer4_label.Click += new System.EventHandler(this.answer4_label_Click);
            // 
            // points_label
            // 
            this.points_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.points_label.AutoSize = true;
            this.points_label.BackColor = System.Drawing.Color.Transparent;
            this.points_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points_label.ForeColor = System.Drawing.Color.White;
            this.points_label.Location = new System.Drawing.Point(151, 3);
            this.points_label.Name = "points_label";
            this.points_label.Size = new System.Drawing.Size(90, 18);
            this.points_label.TabIndex = 49;
            this.points_label.Text = "Punktestand";
            this.points_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // answer1_label
            // 
            this.answer1_label.BackColor = System.Drawing.Color.Transparent;
            this.answer1_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer1_label.Depth = 0;
            this.answer1_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.answer1_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.answer1_label.Location = new System.Drawing.Point(3, 0);
            this.answer1_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.answer1_label.Name = "answer1_label";
            this.answer1_label.Size = new System.Drawing.Size(252, 19);
            this.answer1_label.TabIndex = 2;
            this.answer1_label.Text = "answer1";
            this.answer1_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.answer1_label.Click += new System.EventHandler(this.answer1_label_Click);
            // 
            // pnl_Antworten
            // 
            this.pnl_Antworten.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Antworten.Controls.Add(this.answer1_label);
            this.pnl_Antworten.Controls.Add(this.answer2_label);
            this.pnl_Antworten.Controls.Add(this.answer4_label);
            this.pnl_Antworten.Controls.Add(this.answer3_label);
            this.pnl_Antworten.Location = new System.Drawing.Point(33, 48);
            this.pnl_Antworten.Name = "pnl_Antworten";
            this.pnl_Antworten.Size = new System.Drawing.Size(258, 101);
            this.pnl_Antworten.TabIndex = 5;
            // 
            // pnl_Background
            // 
            this.pnl_Background.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Background.Controls.Add(this.pnl_Punkte);
            this.pnl_Background.Controls.Add(this.pnl_Optionen);
            this.pnl_Background.Controls.Add(this.pnl_Abstand);
            this.pnl_Background.Controls.Add(this.pnl_Antworten);
            this.pnl_Background.Controls.Add(this.vocable_label);
            this.pnl_Background.Location = new System.Drawing.Point(105, 46);
            this.pnl_Background.Name = "pnl_Background";
            this.pnl_Background.Size = new System.Drawing.Size(335, 229);
            this.pnl_Background.TabIndex = 52;
            // 
            // pnl_Punkte
            // 
            this.pnl_Punkte.Controls.Add(this.points_label);
            this.pnl_Punkte.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Punkte.Location = new System.Drawing.Point(0, 158);
            this.pnl_Punkte.Name = "pnl_Punkte";
            this.pnl_Punkte.Size = new System.Drawing.Size(335, 24);
            this.pnl_Punkte.TabIndex = 54;
            // 
            // pnl_Optionen
            // 
            this.pnl_Optionen.Controls.Add(this.help_btn);
            this.pnl_Optionen.Controls.Add(this.exit_btn);
            this.pnl_Optionen.Controls.Add(this.skip_btn);
            this.pnl_Optionen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Optionen.Location = new System.Drawing.Point(0, 182);
            this.pnl_Optionen.Name = "pnl_Optionen";
            this.pnl_Optionen.Size = new System.Drawing.Size(335, 34);
            this.pnl_Optionen.TabIndex = 53;
            // 
            // pnl_Abstand
            // 
            this.pnl_Abstand.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Abstand.Location = new System.Drawing.Point(0, 216);
            this.pnl_Abstand.Name = "pnl_Abstand";
            this.pnl_Abstand.Size = new System.Drawing.Size(335, 13);
            this.pnl_Abstand.TabIndex = 55;
            // 
            // VocableGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pnl_Background);
            this.Controls.Add(this.materialLabel2);
            this.Location = new System.Drawing.Point(3, 29);
            this.Name = "VocableGui";
            this.Size = new System.Drawing.Size(564, 318);
            this.pnl_Antworten.ResumeLayout(false);
            this.pnl_Background.ResumeLayout(false);
            this.pnl_Punkte.ResumeLayout(false);
            this.pnl_Punkte.PerformLayout();
            this.pnl_Optionen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label vocable_label;
        private MaterialSkin.Controls.MaterialRaisedButton exit_btn;
        private MaterialSkin.Controls.MaterialRaisedButton skip_btn;
        private MaterialSkin.Controls.MaterialRaisedButton help_btn;
        public MaterialSkin.Controls.MaterialLabel materialLabel2;
        public MaterialSkin.Controls.MaterialLabel answer2_label;
        public MaterialSkin.Controls.MaterialLabel answer3_label;
        public MaterialSkin.Controls.MaterialLabel answer4_label;
        public System.Windows.Forms.Label points_label;
        public System.Windows.Forms.Timer timer;
        public MaterialSkin.Controls.MaterialLabel answer1_label;
        private System.Windows.Forms.Panel pnl_Antworten;
        private System.Windows.Forms.Panel pnl_Background;
        private System.Windows.Forms.Panel pnl_Punkte;
        private System.Windows.Forms.Panel pnl_Optionen;
        private System.Windows.Forms.Panel pnl_Abstand;
    }
}
