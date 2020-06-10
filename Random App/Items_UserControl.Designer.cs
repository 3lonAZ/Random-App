namespace Random_App
{
    partial class Items_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items_UserControl));
            this.items_textBox = new System.Windows.Forms.TextBox();
            this.items_listBox = new System.Windows.Forms.ListBox();
            this.controls_panel = new System.Windows.Forms.Panel();
            this.Add_BTN = new System.Windows.Forms.Button();
            this.Remove_Slc_BTN = new System.Windows.Forms.Button();
            this.Clear_Items_BTN = new System.Windows.Forms.Button();
            this.Read_Text_BTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Check_pictureBox = new System.Windows.Forms.PictureBox();
            this.Check_gif_pictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.giftimer = new System.Windows.Forms.Timer(this.components);
            this.controls_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_gif_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // items_textBox
            // 
            this.items_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.items_textBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.items_textBox.ForeColor = System.Drawing.Color.White;
            this.items_textBox.Location = new System.Drawing.Point(57, 11);
            this.items_textBox.Name = "items_textBox";
            this.items_textBox.Size = new System.Drawing.Size(260, 25);
            this.items_textBox.TabIndex = 0;
            this.items_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.İtems_textBox_KeyDown);
            // 
            // items_listBox
            // 
            this.items_listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.items_listBox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.items_listBox.ForeColor = System.Drawing.Color.Aqua;
            this.items_listBox.FormattingEnabled = true;
            this.items_listBox.ItemHeight = 17;
            this.items_listBox.Location = new System.Drawing.Point(57, 42);
            this.items_listBox.Name = "items_listBox";
            this.items_listBox.Size = new System.Drawing.Size(260, 191);
            this.items_listBox.TabIndex = 1;
            // 
            // controls_panel
            // 
            this.controls_panel.Controls.Add(this.Read_Text_BTN);
            this.controls_panel.Controls.Add(this.Clear_Items_BTN);
            this.controls_panel.Controls.Add(this.Remove_Slc_BTN);
            this.controls_panel.Controls.Add(this.Add_BTN);
            this.controls_panel.Location = new System.Drawing.Point(323, 51);
            this.controls_panel.Name = "controls_panel";
            this.controls_panel.Size = new System.Drawing.Size(43, 165);
            this.controls_panel.TabIndex = 2;
            // 
            // Add_BTN
            // 
            this.Add_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Add_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Add_BTN.Image")));
            this.Add_BTN.Location = new System.Drawing.Point(0, 3);
            this.Add_BTN.Name = "Add_BTN";
            this.Add_BTN.Size = new System.Drawing.Size(43, 34);
            this.Add_BTN.TabIndex = 3;
            this.toolTip1.SetToolTip(this.Add_BTN, "Add");
            this.Add_BTN.UseVisualStyleBackColor = false;
            this.Add_BTN.Click += new System.EventHandler(this.Add_BTN_Click);
            // 
            // Remove_Slc_BTN
            // 
            this.Remove_Slc_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Remove_Slc_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remove_Slc_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Remove_Slc_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Remove_Slc_BTN.Image")));
            this.Remove_Slc_BTN.Location = new System.Drawing.Point(0, 43);
            this.Remove_Slc_BTN.Name = "Remove_Slc_BTN";
            this.Remove_Slc_BTN.Size = new System.Drawing.Size(43, 34);
            this.Remove_Slc_BTN.TabIndex = 4;
            this.toolTip1.SetToolTip(this.Remove_Slc_BTN, "Remove Selected Items");
            this.Remove_Slc_BTN.UseVisualStyleBackColor = false;
            this.Remove_Slc_BTN.Click += new System.EventHandler(this.Remove_Slc_BTN_Click);
            // 
            // Clear_Items_BTN
            // 
            this.Clear_Items_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Clear_Items_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_Items_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear_Items_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Clear_Items_BTN.Image")));
            this.Clear_Items_BTN.Location = new System.Drawing.Point(0, 83);
            this.Clear_Items_BTN.Name = "Clear_Items_BTN";
            this.Clear_Items_BTN.Size = new System.Drawing.Size(43, 34);
            this.Clear_Items_BTN.TabIndex = 5;
            this.toolTip1.SetToolTip(this.Clear_Items_BTN, "Clear All Items");
            this.Clear_Items_BTN.UseVisualStyleBackColor = false;
            this.Clear_Items_BTN.Click += new System.EventHandler(this.Clear_Items_BTN_Click);
            // 
            // Read_Text_BTN
            // 
            this.Read_Text_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Read_Text_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Read_Text_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Read_Text_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Read_Text_BTN.Image")));
            this.Read_Text_BTN.Location = new System.Drawing.Point(0, 123);
            this.Read_Text_BTN.Name = "Read_Text_BTN";
            this.Read_Text_BTN.Size = new System.Drawing.Size(43, 34);
            this.Read_Text_BTN.TabIndex = 6;
            this.toolTip1.SetToolTip(this.Read_Text_BTN, "Read Text File");
            this.Read_Text_BTN.UseVisualStyleBackColor = false;
            this.Read_Text_BTN.Click += new System.EventHandler(this.Read_Text_BTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Check_pictureBox
            // 
            this.Check_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Check_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Check_pictureBox.Image")));
            this.Check_pictureBox.Location = new System.Drawing.Point(165, 234);
            this.Check_pictureBox.Name = "Check_pictureBox";
            this.Check_pictureBox.Size = new System.Drawing.Size(58, 35);
            this.Check_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Check_pictureBox.TabIndex = 3;
            this.Check_pictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.Check_pictureBox, "Check Random Item");
            this.Check_pictureBox.Click += new System.EventHandler(this.Check_pictureBox_Click);
            // 
            // Check_gif_pictureBox
            // 
            this.Check_gif_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Check_gif_pictureBox.Image")));
            this.Check_gif_pictureBox.Location = new System.Drawing.Point(165, 234);
            this.Check_gif_pictureBox.Name = "Check_gif_pictureBox";
            this.Check_gif_pictureBox.Size = new System.Drawing.Size(58, 35);
            this.Check_gif_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Check_gif_pictureBox.TabIndex = 4;
            this.Check_gif_pictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.Check_gif_pictureBox, "Checked Random Item...");
            this.Check_gif_pictureBox.Visible = false;
            // 
            // giftimer
            // 
            this.giftimer.Interval = 1000;
            this.giftimer.Tick += new System.EventHandler(this.Giftimer_Tick);
            // 
            // Items_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.Check_gif_pictureBox);
            this.Controls.Add(this.Check_pictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.controls_panel);
            this.Controls.Add(this.items_listBox);
            this.Controls.Add(this.items_textBox);
            this.Name = "Items_UserControl";
            this.Size = new System.Drawing.Size(379, 272);
            this.controls_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_gif_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox items_textBox;
        private System.Windows.Forms.ListBox items_listBox;
        private System.Windows.Forms.Panel controls_panel;
        private System.Windows.Forms.Button Remove_Slc_BTN;
        private System.Windows.Forms.Button Add_BTN;
        private System.Windows.Forms.Button Read_Text_BTN;
        private System.Windows.Forms.Button Clear_Items_BTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Check_pictureBox;
        private System.Windows.Forms.PictureBox Check_gif_pictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer giftimer;
    }
}
