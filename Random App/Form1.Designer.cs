namespace Random_App
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.top_panel = new System.Windows.Forms.Panel();
            this.Number_RadioButton = new System.Windows.Forms.RadioButton();
            this.items_RadioButton = new System.Windows.Forms.RadioButton();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.center_panel = new System.Windows.Forms.Panel();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.Number_RadioButton);
            this.top_panel.Controls.Add(this.items_RadioButton);
            this.top_panel.Controls.Add(this.Minimize);
            this.top_panel.Controls.Add(this.Exit);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(379, 51);
            this.top_panel.TabIndex = 0;
            this.top_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Top_panel_Paint);
            this.top_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top_panel_MouseDown);
            this.top_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Top_panel_MouseMove);
            this.top_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Top_panel_MouseUp);
            // 
            // Number_RadioButton
            // 
            this.Number_RadioButton.AutoSize = true;
            this.Number_RadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Number_RadioButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Number_RadioButton.ForeColor = System.Drawing.Color.White;
            this.Number_RadioButton.Location = new System.Drawing.Point(74, 23);
            this.Number_RadioButton.Name = "Number_RadioButton";
            this.Number_RadioButton.Size = new System.Drawing.Size(77, 23);
            this.Number_RadioButton.TabIndex = 2;
            this.Number_RadioButton.Text = "Number";
            this.Number_RadioButton.UseVisualStyleBackColor = true;
            this.Number_RadioButton.Click += new System.EventHandler(this.Number_RadioButton_Click);
            // 
            // items_RadioButton
            // 
            this.items_RadioButton.AutoSize = true;
            this.items_RadioButton.Checked = true;
            this.items_RadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.items_RadioButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.items_RadioButton.ForeColor = System.Drawing.Color.White;
            this.items_RadioButton.Location = new System.Drawing.Point(8, 23);
            this.items_RadioButton.Name = "items_RadioButton";
            this.items_RadioButton.Size = new System.Drawing.Size(60, 23);
            this.items_RadioButton.TabIndex = 0;
            this.items_RadioButton.TabStop = true;
            this.items_RadioButton.Text = "Items";
            this.items_RadioButton.UseVisualStyleBackColor = true;
            this.items_RadioButton.Click += new System.EventHandler(this.İtems_RadioButton_Click);
            // 
            // Minimize
            // 
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(291, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(41, 29);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize.TabIndex = 1;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(338, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(41, 29);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 0;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // center_panel
            // 
            this.center_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.center_panel.Location = new System.Drawing.Point(0, 51);
            this.center_panel.Name = "center_panel";
            this.center_panel.Size = new System.Drawing.Size(379, 272);
            this.center_panel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(379, 323);
            this.Controls.Add(this.center_panel);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel center_panel;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.RadioButton Number_RadioButton;
        private System.Windows.Forms.RadioButton items_RadioButton;
    }
}

