using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;

namespace BSK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            encode_button.Click += encode_button_click;
            e_mode_cb.SelectionChangeCommitted += e_change_restriction_mode;
            e_path_button.Click += e_path_button_click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void e_path_button_click (object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;

            String directoryPath;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                directoryPath = Path.GetFullPath(openFileDialog.FileName);
                object_to_encode.path = directoryPath;
                path_tb.Text = directoryPath;
            }

        }

        private void e_change_restriction_mode(object sender, EventArgs e)
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
            object_to_encode.key_length = Int32.Parse(key_lenght.Substring(0, key_lenght.IndexOf(" ")));

            String block_lenght = e_box_length_cb.Text;
            object_to_encode.box_lenght = Int32.Parse(block_lenght.Substring(0, block_lenght.IndexOf(" ")));

            object_to_encode.mode = e_mode_cb.Text;

            String subbox_lenght = e_length_subbox_cb.Text;
            object_to_encode.subbox_lenght = Int32.Parse(subbox_lenght.Substring(0, subbox_lenght.IndexOf(" ")));

            object_to_encode.password = e_password_tb.Text;

            //String choice = object_to_encode.key_lenght + "\n" + block_lenght + "\n" + mode + "\n" + subbox_lenght + "\n" + password; 
            //MessageBox.Show(choice);

        }
    }
}
