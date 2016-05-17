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
        public List<String> encrypted_keys = new List<String>();
        public List<String> users_to_decode = new List<String>();
        DirectoryInfo public_keys_path = new DirectoryInfo(@"C:\Serpent\BSK\bin\Debug\Users\PublicKeys\"); //pamietaj by zmienic na
        DirectoryInfo private_keys_path = new DirectoryInfo(@"C:\Serpent\BSK\bin\Debug\Users\PrivateKeys\");//jakos defaultowo
        bool activated = false;
        String d_src = null;

        public Form1()
        {
            InitializeComponent();
            load_comboboxes();
            load_users();
            load_users_to_list();

            //ENCODE
            encode_button.Click += encode_button_click;
            e_mode_cb.SelectionChangeCommitted += e_change_restriction_mode;
            e_src_button.Click += e_src_button_click;
            e_dst_button.Click += e_dst_button_click;
            e_add_user.Click += add_authorized_user;
            e_delete_user.Click += delete_user;
            dodajOdbiorceToolStripMenuItem.Click += add_user_from_menu;

            //DECODE
            decode_button.Click += decode_button_click;
            d_src_button.Click += d_src_button_click;
            d_dst_button.Click += d_dst_button_click;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void load_comboboxes()
        {
            if (!activated)
            {
                e_box_length_cb.SelectedIndex = 0;
                e_box_length_cb.Enabled = false;
                e_key_length_cb.SelectedIndex = 0;
                e_length_subbox_cb.SelectedIndex = 15;
                e_length_subbox_cb.Enabled = false;
                e_mode_cb.SelectedIndex = 0;
                activated = true;
                
            }
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
                        //users_to_decode.Add(file.Name.ToString());
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

            ListAuthorizedUsersForm add_authorized_form = new ListAuthorizedUsersForm(users_to_encode);
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

        private void e_src_button_click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;

            String directoryPath;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                directoryPath = Path.GetFullPath(openFileDialog.FileName);
                object_to_encode.path = directoryPath;
                e_src_tb.Text = directoryPath;
            }

        }

        private void e_dst_button_click(object sender, EventArgs e)
        {

            SaveFileDialog openFileDialog = new SaveFileDialog();

            dynamic directoryPath;

            DialogResult r = openFileDialog.ShowDialog();
            if (DialogResult.OK == r)
            {
                e_dst_tb.Text = openFileDialog.FileName;
            }
        }

        private void e_change_restriction_mode(object sender, EventArgs e)
        {
            if (e_mode_cb.Text == "ECB" || e_mode_cb.Text == "CBC")
            {
                e_length_subbox_cb.Enabled = false;
                e_length_subbox_cb.SelectedIndex = 15;
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

            object_to_encode.subbox_lenght = Int32.Parse(subbox_lenght.Substring(0, subbox_lenght.IndexOf(" ")));


            e_status_lbl.Text = "Przygotowywanie do szyfrowania";

            if (correct == false)
                MessageBox.Show("Uzupelnij ustawienia!");
            else
            {                
                encrypt();
                MessageBox.Show("Szyfrowanie zakonczone sukcesem!");
                Application.Restart();
            }
        }

        private void decode_button_click(object sender, EventArgs e)
        {
            //string src = d_src_tb.Text;
            //string dst = d_dst_tb.Text;
            String password = d_password_tb.Text;
            String selected_user = d_users_list.SelectedItem.ToString();
            String private_key;

            IAlgorithm alg = decryptKey(private_keys_path.ToString() + selected_user, password);

            Int64 length = alg.getSrcLength();
            Int64 step = System.Convert.ToInt64(Math.Ceiling(length / (double)100));
            Int64 bytes = 1;

            d_status_lbl.Text = "Trwa przetwarzanie klucza prywatnego";
            while (bytes > 0)
            {
                // "unit work" szyfrowanie fragmentu pliku
                bytes = alg.encrypt(step);
            }
            alg.Dispose();

            d_status_lbl.Text = "Zaczeto odszyfrowanie";
            //szyfrowanie######################################## do oddzielnej funkcji decode
            private_key = get_private_key(selected_user);
            alg = decryptFile(d_src_tb.Text, d_dst_tb.Text, password, private_key, selected_user);

            length = alg.getSrcLength();
            step = System.Convert.ToInt64(Math.Ceiling(length / (double)100));
            bytes = 1;

            while (bytes > 0)
            {
                // "unit work" szyfrowanie fragmentu pliku
                bytes = alg.encrypt(step);
            }
            alg.Dispose();

            MessageBox.Show("Odszyfrowanie zakonczone sukcesem!");
            d_status_lbl.Text = "Odszyfrowanie zakonczone";
        } 

        private void encrypt()
        {
            String path = Path.GetDirectoryName(object_to_encode.path);         

            if (!File.Exists(object_to_encode.path))
            {
                MessageBox.Show("Podano nieistniejący plik źródłowy.");
                return;
            }

            block_controllers();

            IAlgorithm alg;
            e_status_lbl.Text = "Szyfrowanie";

            alg = encryptFile(object_to_encode.path, e_dst_tb.Text, object_to_encode.mode, object_to_encode.subbox_lenght, object_to_encode.key_length, "");

            Int64 length = alg.getSrcLength();
            Int64 step = System.Convert.ToInt64(Math.Ceiling(length / (double)100));
            Int64 bytes = 1;

            while (bytes > 0)
            {
                // "unit work" szyfrowanie fragmentu pliku
                bytes = alg.encrypt(step);
            }
            alg.Dispose();

            e_status_lbl.Text = "Szyfrowanie zakonczone!!!";
            restore_controllers();
            alg = null;
        }

        private void block_controllers()
        {
            e_add_user.Enabled = false;
            e_delete_user.Enabled = false;
            e_key_length_cb.Enabled = false;
            e_length_subbox_cb.Enabled = false;
            e_mode_cb.Enabled = false;
            e_src_button.Enabled = false;
        }

        private void restore_controllers()
        {
            e_add_user.Enabled = true;
            e_delete_user.Enabled = true;
            e_key_length_cb.Enabled = true;
            e_length_subbox_cb.Enabled = true;
            e_mode_cb.Enabled = true;
            e_src_button.Enabled = true;
        }

        private void d_src_button_click(object sender, EventArgs e)
        {
            d_users_list.Items.Clear();
            users_to_decode.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;

            String directoryPath;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                directoryPath = Path.GetFullPath(openFileDialog.FileName);
                object_to_encode.path = directoryPath;
                d_src_tb.Text = directoryPath;
                d_src = directoryPath;

                String xmlHeader = "";
                using (StreamReader sr = new StreamReader(d_src))
                {
                    String line;
                    while (sr.Peek() >= 0)
                    {
                        line = sr.ReadLine();
                        xmlHeader += line + "\r\n";

                        if (line.Equals("</EncryptedFileHeader>"))                        
                            break;
                        
                    }
                }
                
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xmlHeader);
                XmlNodeList xnList = doc.SelectNodes("/EncryptedFileHeader/Users/User");

                foreach (XmlNode user in xnList)
                    users_to_decode.Add(user["Name"].InnerText);
                load_users_to_list();
                    //if (!d_users_list.Items.Contains(user))
                    //    d_users_list.Items.Add(user);
                }

        }

        private void d_dst_button_click(object sender, EventArgs e)
        {

            SaveFileDialog openFileDialog = new SaveFileDialog();

            dynamic directoryPath;

            DialogResult r = openFileDialog.ShowDialog();
            if (DialogResult.OK == r)            
                d_dst_tb.Text = openFileDialog.FileName;
            
        }

        private String get_private_key(String selected_user)
        {
            String key;
            using (StreamReader sr = new StreamReader(private_keys_path.ToString() + selected_user + "tmp", true))
            {
                key = sr.ReadLine();
            }
            File.Delete(private_keys_path.ToString() + selected_user + "tmp");
            return key;
        }

        private IAlgorithm decryptKey(String src, String password)
        {
            IAlgorithm alg = null;
            String key;

            var SHA = SHA256.Create();
            byte[] hashed_password = SHA.ComputeHash(GetBytes(password)); //iv
            KeyParameter session_key = new KeyParameter(hashed_password); //skey
            String password_to_use = Convert.ToBase64String(hashed_password); //password

            alg = new Serpent(session_key, hashed_password, false);
            alg.init(src, src + "tmp", "ECB", 128, 0, 0);

            return alg;
        }

        private IAlgorithm decryptFile(String src, String dst, String password, String private_key, String selected_user)
        {
            // wykonanie algorytmu
            //  utworzenie obiektu klasy algorithm (IAlgorithm)
            //  wywołanie metody encrypt lub decrypt z odpowiednimi parametrami
            //  w tym obsługa paska postepu i przerwania operacji
            IAlgorithm alg;

            // wczytanie nagłówka
            String xmlHeader = "";
            using (StreamReader sr = new StreamReader(src))
            {
                String line;
                while (sr.Peek() >= 0)
                {
                    line = sr.ReadLine();
                    xmlHeader += line + "\r\n";

                    if (line.Equals("</EncryptedFileHeader>"))                    
                        break;                    
                }
            }

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlHeader);

            int headerOffset = xmlHeader.Length;

            // wyświetlenie nagłówka w GUI
            //fileHeader.Text = xmlHeader;

            // odczytanie parametrów z nagłówka
            XmlNode node = doc.DocumentElement.SelectSingleNode("/EncryptedFileHeader/KeySize");
            var keySize = Convert.ToInt32(node.InnerText);
            keySize = keySize >> 3;

            XmlNodeList xnList = doc.SelectNodes("/EncryptedFileHeader/Users/User");
            byte[] encryptedKey = null;
            bool znaleziony = false;

            foreach (XmlNode user in xnList)
            {
                if (user["Name"].InnerText == selected_user)
                {
                    encryptedKey = Convert.FromBase64String(user["EncryptedKey"].InnerText);
                    znaleziony = true;
                    break;
                }
                else
                    znaleziony = false;
            }
            if (znaleziony == false)
            {
                MessageBox.Show("Wybrany uzytkownik nie jest na liscie odbiorcow tego pliku");
                Application.Restart();
            }

            //node = doc.DocumentElement.SelectSingleNode("/EncryptedFileHeader/Users/User/"+ selected_user + "/EncryptedKey");
            //byte[] encryptedKey = Convert.FromBase64String(node.InnerText);

            // odszyfrowanie klucza sesyjnego kluczem prywatnym uzytnika
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(private_key);
            
            var sessionKey = rsa.Decrypt(encryptedKey, false);

            KeyParameter session_key_kp = new KeyParameter(sessionKey);

            //*************************************************************************

            node = doc.DocumentElement.SelectSingleNode("/EncryptedFileHeader/IV");
            byte[] iv = Convert.FromBase64String(node.InnerText);

            node = doc.DocumentElement.SelectSingleNode("/EncryptedFileHeader/SegmentSize");
            var segment = Convert.ToInt32(node.InnerText);

            node = doc.DocumentElement.SelectSingleNode("/EncryptedFileHeader/CipherMode");
            var cipherMode = node.InnerText;

            // odszyfrowywanie
            alg = new Serpent(session_key_kp, iv, false);
            alg.init(src, dst, cipherMode, segment, headerOffset, 0);

            return alg;
        }

        private IAlgorithm encryptFile(String src, String dst, String cipher_mode, int segment, int session_key_size, String password) // dodac uzytnikow
        {
            // wykonanie algorytmu
            //  utworzenie obiektu klasy algorithm (IAlgorithm)
            //  wywołanie metody encrypt z odpowiednimi parametrami
            //  w tym obsługa paska postepu i przerwania operacji
            IAlgorithm alg;
            //Dodaje tutaj naglowek userow, pomysl nad rozbiciem tego na funkcje############################################################
            
            var session_key = Serpent.generateKey(session_key_size);


            var iv = Serpent.generateIV();
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();   
            // zaszyfrowanie klucza sesyjnego algorytmem Serpent/ECB hasłem `password` // usun to, nie mozna haslem szyfrowac tylko kluczem!
            //sessionKeyAlg = getSessionKeyAlg(true, password);           // <--- podajesz password // i cisniesz dla usera
            //encryptedKey = sessionKeyAlg.encryptInMemory(key.GetKey()); //

            foreach (var user in users_to_encode)
            {
                using (StreamReader sr = new StreamReader(public_keys_path.ToString() + user))
                {
                    var public_key = sr.ReadToEnd();
                    rsa.FromXmlString(public_key);
                    var encrypted_key = rsa.Encrypt(session_key.GetKey(), false);
                    
                    encrypted_keys.Add(Convert.ToBase64String(encrypted_key));
                    //MessageBox.Show(Convert.ToBase64String(encrypted_key)); //tutaj messagebox
                }               
            }            

            XElement usersXML = new XElement("Users");

            for (int i = 0; i < users_to_encode.Count(); i++)
            {
                usersXML.Add(new XElement("User",
                    new XElement("Name", users_to_encode[i]),
                    new XElement("EncryptedKey", encrypted_keys[i])));
            }          
            //#################################################################################################################################
            // utworzenie nagłówka
            XDocument miXML = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("EncryptedFileHeader",
                    new XElement("Algorithm", "SERPENT"),
                    new XElement("CipherMode", cipher_mode),
                    new XElement("SegmentSize", segment),
                    new XElement("KeySize", session_key_size),
                    new XElement("IV", Convert.ToBase64String(iv)),
                    usersXML
                )
            );          
            

            using (StreamWriter sw = new StreamWriter(dst, false, Encoding.ASCII))
            {
                miXML.Save(sw);
                sw.WriteLine();
            }
            long xmlSize = new FileInfo(dst).Length;

            // zapisanie nagłówka
            var headerOffset = xmlSize;

            // szyfrowanie
            alg = new Serpent(session_key, iv, true);
            alg.init(src, dst, cipher_mode, segment, 0, headerOffset);

            return alg;
        }

        private IAlgorithm getSessionKeyAlg(bool encryption, string password)
        {
            var SKkey = Serpent.generateKeyFromBytes(computeHash(password));
            var SKiv = Serpent.generateIV(true);
            IAlgorithm sessionKeyAlg = new Serpent(SKkey, SKiv, encryption);
            sessionKeyAlg.init(null, null, "ECB", 128);

            return sessionKeyAlg;
        }

        private byte[] computeHash(String data)
        {
            using (var alg = SHA256.Create())
            {
                return alg.ComputeHash(GetBytes(data));
            }
        }

        static byte[] GetBytes(String str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        private void main_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }   

}
