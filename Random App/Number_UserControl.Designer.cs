namespace Random_App
{
    partial class Number_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Number_UserControl));
            this.Results_groupBox = new System.Windows.Forms.GroupBox();
            this.Copy_BTN = new System.Windows.Forms.PictureBox();
            this.results_label = new System.Windows.Forms.Label();
            this.max_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.min_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Check_pictureBox = new System.Windows.Forms.PictureBox();
            this.Check_gif_pictureBox = new System.Windows.Forms.PictureBox();
            this.giftimer = new System.Windows.Forms.Timer(this.components);
            this.Results_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Copy_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_gif_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Results_groupBox
            // 
            this.Results_groupBox.Controls.Add(this.Copy_BTN);
            this.Results_groupBox.Controls.Add(this.results_label);
            this.Results_groupBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Results_groupBox.ForeColor = System.Drawing.Color.White;
            this.Results_groupBox.Location = new System.Drawing.Point(4, 60);
            this.Results_groupBox.Name = "Results_groupBox";
            this.Results_groupBox.Size = new System.Drawing.Size(185, 100);
            this.Results_groupBox.TabIndex = 0;
            this.Results_groupBox.TabStop = false;
            this.Results_groupBox.Text = "Results";
            // 
            // Copy_BTN
            // 
            this.Copy_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Copy_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Copy_BTN.Image")));
            this.Copy_BTN.Location = new System.Drawing.Point(148, 14);
            this.Copy_BTN.Name = "Copy_BTN";
            this.Copy_BTN.Size = new System.Drawing.Size(31, 23);
            this.Copy_BTN.TabIndex = 6;
            this.Copy_BTN.TabStop = false;
            this.toolTip1.SetToolTip(this.Copy_BTN, "Copy");
            this.Copy_BTN.Click += new System.EventHandler(this.Copy_BTN_Click);
            // 
            // results_label
            // 
            this.results_label.AutoSize = true;
            this.results_label.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.results_label.ForeColor = System.Drawing.Color.Aqua;
            this.results_label.Location = new System.Drawing.Point(6, 43);
            this.results_label.Name = "results_label";
            this.results_label.Size = new System.Drawing.Size(28, 31);
            this.results_label.TabIndex = 1;
            this.results_label.Text = "0";
            // 
            // max_numericUpDown
            // 
            this.max_numericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.max_numericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.max_numericUpDown.ForeColor = System.Drawing.Color.White;
            this.max_numericUpDown.Location = new System.Drawing.Point(207, 74);
            this.max_numericUpDown.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.max_numericUpDown.Name = "max_numericUpDown";
            this.max_numericUpDown.Size = new System.Drawing.Size(172, 26);
            this.max_numericUpDown.TabIndex = 1;
            this.max_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(210, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(208, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min";
            // 
            // min_numericUpDown
            // 
            this.min_numericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.min_numericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.min_numericUpDown.ForeColor = System.Drawing.Color.White;
            this.min_numericUpDown.Location = new System.Drawing.Point(205, 134);
            this.min_numericUpDown.Name = "min_numericUpDown";
            this.min_numericUpDown.Size = new System.Drawing.Size(172, 26);
            this.min_numericUpDown.TabIndex = 3;
            this.min_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Check_pictureBox
            // 
            this.Check_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Check_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Check_pictureBox.Image")));
            this.Check_pictureBox.Location = new System.Drawing.Point(162, 207);
            this.Check_pictureBox.Name = "Check_pictureBox";
            this.Check_pictureBox.Size = new System.Drawing.Size(66, 52);
            this.Check_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Check_pictureBox.TabIndex = 5;
            this.Check_pictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.Check_pictureBox, "Checked random number...");
            this.Check_pictureBox.Click += new System.EventHandler(this.Check_pictureBox_Click);
            // 
            // Check_gif_pictureBox
            // 
            this.Check_gif_pictureBox.AccessibleDescription = "";
            this.Check_gif_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Check_gif_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Check_gif_pictureBox.Image")));
            this.Check_gif_pictureBox.Location = new System.Drawing.Point(162, 207);
            this.Check_gif_pictureBox.Name = "Check_gif_pictureBox";
            this.Check_gif_pictureBox.Size = new System.Drawing.Size(66, 52);
            this.Check_gif_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Check_gif_pictureBox.TabIndex = 6;
            this.Check_gif_pictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.Check_gif_pictureBox, "Checking random number...");
            this.Check_gif_pictureBox.Visible = false;
            this.Check_gif_pictureBox.Click += new System.EventHandler(this.Check_gif_pictureBox_Click);
            // 
            // giftimer
            // 
            this.giftimer.Interval = 1000;
            this.giftimer.Tick += new System.EventHandler(this.Giftimer_Tick);
            // 
            // Number_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.Check_gif_pictureBox);
            this.Controls.Add(this.Check_pictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.min_numericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.max_numericUpDown);
            this.Controls.Add(this.Results_groupBox);
            this.Name = "Number_UserControl";
            this.Size = new System.Drawing.Size(379, 272);
            this.Load += new System.EventHandler(this.Number_UserControl_Load);
            this.Results_groupBox.ResumeLayout(false);
            this.Results_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Copy_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_gif_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Results_groupBox;
        private System.Windows.Forms.Label results_label;
        private System.Windows.Forms.NumericUpDown max_numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown min_numericUpDown;
        private System.Windows.Forms.PictureBox Copy_BTN;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer giftimer;
        private System.Windows.Forms.PictureBox Check_pictureBox;
        private System.Windows.Forms.PictureBox Check_gif_pictureBox;
    }
}
