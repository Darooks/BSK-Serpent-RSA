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
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System.Security;
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace BSK
{
    public partial class Form1 : Form
    {
        public List<String> users_to_encode = new List<String>();
        public List<String> users_to_decode = new List<String>();
        DirectoryInfo public_keys_path = new DirectoryInfo(@"C:\Serpent\BSK\bin\Debug\Users\PublicKeys\");

        public Form1()
        {
            InitializeComponent();
            load_users();
            load_users_to_list();
            encode_button.Click += encode_button_click;
            e_mode_cb.SelectionChangeCommitted += e_change_restriction_mode;
            e_path_button.Click += e_path_button_click;
            e_add_user.Click += add_authorized_user;
            e_delete_user.Click += delete_user;
            dodajOdbiorceToolStripMenuItem.Click += add_user_from_menu;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void load_users()
        {
            FileInfo[] Files = public_keys_path.GetFiles(); //Getting Text files

            if (Files != null)
            {
                foreach (FileInfo file in Files)
                {
                    if (!users_to_encode.Contains(file.Name.ToString()))
                    {
                        users_to_encode.Add(file.Name.ToString());
                        users_to_decode.Add(file.Name.ToString());
                    }
                }
            }            
        }

        private void load_users_to_list()
        {
            foreach (var user in users_to_encode)
                if (!e_users_list.Items.Contains(user))
                    e_users_list.Items.Add(user);

            foreach (var user in users_to_decode)
                if (!d_users_list.Items.Contains(user))
                    d_users_list.Items.Add(user);
        }

        private void add_user_from_menu(Object sender, EventArgs e)
        {
            AddUserForm add_user_form = new AddUserForm();
            add_user_form.ShowDialog();
            add_user_form.BringToFront();
            add_user_form.Focus();
            Application.DoEvents();
            
            load_users();
            load_users_to_list();
        }

        private void add_authorized_user(object sender, EventArgs e)
        {

            AddAuthorizedForm add_authorized_form = new AddAuthorizedForm(users_to_encode);
            add_authorized_form.ShowDialog();
            add_authorized_form.BringToFront();
            add_authorized_form.Focus();
            Application.DoEvents();
            String user_to_add = add_authorized_form.user;
            if (user_to_add != null)
            {
                users_to_encode.Add(user_to_add);
                e_users_list.Items.Add(user_to_add);
            }
        }

        private void delete_user(object sender, EventArgs e)
        {

            String selected_user = e_users_list.SelectedItem.ToString();
            users_to_encode.Remove(selected_user);
            e_users_list.Items.Remove(selected_user);
        }

        private void e_path_button_click(object sender, EventArgs e)
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
            if (e_mode_cb.Text == "ECB" || e_mode_cb.Text == "CBC")
            {
                e_length_subbox_cb.SelectedIndex = -1;
                e_length_subbox_cb.Enabled = false;
            }
            else
                e_length_subbox_cb.Enabled = true;
        }

        private void encode_button_click(object sender, EventArgs e)
        {
            bool correct = true;

            String key_lenght = e_key_length_cb.Text;
            if (key_lenght == "")
                correct = false;
            else
                object_to_encode.key_length = Int32.Parse(key_lenght.Substring(0, key_lenght.IndexOf(" ")));

            String block_lenght = e_box_length_cb.Text;
            if (block_lenght == "")
                correct = false;
            else
                object_to_encode.box_lenght = Int32.Parse(block_lenght.Substring(0, block_lenght.IndexOf(" ")));

            if (e_mode_cb.Text == "")
                correct = false;
            else
                object_to_encode.mode = e_mode_cb.Text;

            String subbox_lenght = e_length_subbox_cb.Text;
            if (subbox_lenght == "" && e_length_subbox_cb.Enabled == true)
                correct = false;
            else if (e_mode_cb.Text == "CFB" || e_mode_cb.Text == "OFB")
                object_to_encode.subbox_lenght = Int32.Parse(subbox_lenght.Substring(0, subbox_lenght.IndexOf(" ")));

            

            byte[] key = { 1, 2, 3, 4, 5 };

            if (correct == false)
                MessageBox.Show("Uzupelnij ustawienia!");
            else
                encrypt();
        }

        private void encrypt()
        {
            String path = Path.GetDirectoryName(object_to_encode.path);
            String name_of_file = Path.GetFileName(object_to_encode.path);
            String[] words = name_of_file.Split('.');
            name_of_file = "Zaszyfrowany" + words[0];
            path += @"\\" + name_of_file;

            XDocument myXML = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("EncryptedFileHeader",
                    new XElement("Algorithm", "SERPENT"),
                    new XElement("CipherMode", object_to_encode.mode),
                    new XElement("SubboxLength", object_to_encode.subbox_lenght),
                    new XElement("KeyLength", object_to_encode.key_length)
                    //new XElement("EncryptedKey", Convert.ToBase64String(encryptedKey)),
                    //new XElement("IV", Convert.ToBase64String(iv))
                )
            );
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.ASCII))
            {
                myXML.Save(sw);
                sw.WriteLine();
            }


        }
    }
}
