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
    public partial class Items_UserControl : UserControl
    {
        public Items_UserControl()
        {
            InitializeComponent();
        }
        int second = 0;
        MyClass myClass = new MyClass();
        private void Check_pictureBox_Click(object sender, EventArgs e)
        {
            if (items_listBox.Items.Count > 1)
            {
                Check_gif_pictureBox.Visible = true;
                Check_pictureBox.Visible = false;
                controls_panel.Enabled = false;
                items_textBox.Enabled = false;
                giftimer.Enabled = true;
            }
            else
                MessageBox.Show("Items must be at least 2","Warning !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void Giftimer_Tick(object sender, EventArgs e)
        {
            second++;
            if (second == 3)
                RandomItems();
        }

        private void RandomItems()
        {
            giftimer.Stop();
            second = 0;
            Check_pictureBox.Visible = true;
            Check_gif_pictureBox.Visible = false;
            controls_panel.Enabled = true;
            items_textBox.Enabled = true;
            var randomitems = myClass.RandomItems(items_listBox.Items);
            MessageBox.Show($"Random Items: '{randomitems}'","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            var dialog = MessageBox.Show("Do you want to copy the random item ?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Clipboard.SetText(randomitems);
                MessageBox.Show("Successfully Copied !","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void İtems_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string txt = items_textBox.Text.Trim();
                if (txt != "")
                {
                    items_textBox.Clear();
                    items_listBox.Items.Add(txt);
                }
            }
        }

        private void Add_BTN_Click(object sender, EventArgs e)
        {
            string txt = items_textBox.Text.Trim();
            if (txt != "")
            {
                items_textBox.Clear();
                items_listBox.Items.Add(txt);
            }
        }

        private void Remove_Slc_BTN_Click(object sender, EventArgs e)
        {
            int index = items_listBox.SelectedIndex;
            if (index >= 0)
                items_listBox.Items.RemoveAt(index);
        }

        private void Clear_Items_BTN_Click(object sender, EventArgs e)
        {
            if (items_listBox.Items.Count > 0)
            {
                var dialog = MessageBox.Show("Delete all items ?","Warning !",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                    items_listBox.Items.Clear();
            }
        }

        private void Read_Text_BTN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog=new OpenFileDialog ())
            {
                dialog.Filter="Text files (*.txt)|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string[] data = myClass.ReadTextFile(dialog.FileName);
                    items_listBox.Items.Clear();
                    foreach (var item in data)
                    {
                        items_listBox.Items.Add(item);
                    }
                    MessageBox.Show("File Successfully Read !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
