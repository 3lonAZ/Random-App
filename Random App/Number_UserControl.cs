using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_App
{
    public partial class Number_UserControl : UserControl
    {
        public Number_UserControl()
        {
            InitializeComponent();
        }
        MyClass myClass = new MyClass();
        int second = 0;
        private void Check_pictureBox_Click(object sender, EventArgs e)
        {
            if (max_numericUpDown.Value > 1)
            {
                Check_gif_pictureBox.Visible = true;
                Check_pictureBox.Visible = false;
                giftimer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Maximum values must be more than 2","Warning !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Giftimer_Tick(object sender, EventArgs e)
        {
            second++;
            if (second == 3)
                RandomNumber();
        }

        private void RandomNumber()
        {
            giftimer.Stop();
            second = 0;
            Check_pictureBox.Visible = true;
            Check_gif_pictureBox.Visible = false;
            int randomnumber = myClass.RandomNumber((int)min_numericUpDown.Value, (int)max_numericUpDown.Value);
            results_label.Text = randomnumber.ToString();
        }

        private void Copy_BTN_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(results_label.Text);
            MessageBox.Show("Copied !","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Number_UserControl_Load(object sender, EventArgs e)
        {
        }

        private void Check_gif_pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
