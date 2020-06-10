using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool move;
        int x;
        int y;
        private void Exit_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Exit the application ?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (DialogResult.Yes == dialog)
                Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Top_panel_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
            top_panel.Cursor = Cursors.Default;
        }

        private void Top_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
        }

        private void Top_panel_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            x = e.X;
            y = e.Y;
            top_panel.Cursor = Cursors.SizeAll;
        }

        private void İtems_RadioButton_Click(object sender, EventArgs e)
        {
            center_panel.Controls.Clear();
            Items_UserControl items_UserControl = new Items_UserControl();
            center_panel.Controls.Add(items_UserControl);
        }

        private void Number_RadioButton_Click(object sender, EventArgs e)
        {
            center_panel.Controls.Clear();
            Number_UserControl number_UserControl = new Number_UserControl();
            center_panel.Controls.Add(number_UserControl);
        }

        private void Top_panel_Paint(object sender, PaintEventArgs e)
        {
            //    AssemblyConfigurationAttribute d = new AssemblyConfigurationAttribute();
        }
    }
}
