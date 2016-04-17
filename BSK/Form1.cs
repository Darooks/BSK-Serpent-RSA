using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            encode_button.Click += encode_button_click;
            e_mode_cb.SelectionChangeCommitted += change_restriction_mode;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void change_restriction_mode(object sender, EventArgs e)
        {
            if (e_mode_cb.Text == "CFB" || e_mode_cb.Text == "OFB")
            {
                e_length_subbox_cb.SelectedIndex = -1;
                e_length_subbox_cb.Enabled = false;
            }
            else            
                e_length_subbox_cb.Enabled = true;           

        }

        private void encode_button_click(object sender, EventArgs e)
        {
            String key_lenght = e_key_length_cb.Text;
            String block_lenght = e_box_length_cb.Text;
            String mode = e_mode_cb.Text;
            String subbox_lenght = e_length_subbox_cb.Text;
            String password = e_password_tb.Text;

            String choice = key_lenght + "\n" + block_lenght + "\n" + mode + "\n" + subbox_lenght + "\n" + password; 
            MessageBox.Show(choice);

        }
    }
}
