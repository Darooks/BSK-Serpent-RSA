using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Pkcs;
using System.Security;
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

using Org.BouncyCastle.OpenSsl;


namespace BSK
{
    class AddUserForm : Form
    {
        private Label label1;
        private Label label2;
        private Button add_user_bt;
        private TextBox user_name;
        private TextBox user_password;
        private Button cancel_bt;
        private String private_keys_path = @"C:\Serpent\BSK\bin\Debug\Users\PrivateKeys\";
        private String public_keys_path = @"C:\Serpent\BSK\bin\Debug\Users\PublicKeys\";
        private const int LENGHT_OF_KEY = 1024;

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_user_bt = new System.Windows.Forms.Button();
            this.user_name = new System.Windows.Forms.TextBox();
            this.user_password = new System.Windows.Forms.TextBox();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa uzytkownika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Haslo:";
            // 
            // add_user_bt
            // 
            this.add_user_bt.Location = new System.Drawing.Point(55, 108);
            this.add_user_bt.Name = "add_user_bt";
            this.add_user_bt.Size = new System.Drawing.Size(75, 23);
            this.add_user_bt.TabIndex = 3;
            this.add_user_bt.Text = "Dodaj odbiorce";
            this.add_user_bt.UseVisualStyleBackColor = true;
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(168, 36);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(100, 20);
            this.user_name.TabIndex = 4;
            // 
            // user_password
            // 
            this.user_password.Location = new System.Drawing.Point(168, 62);
            this.user_password.Name = "user_password";
            this.user_password.Size = new System.Drawing.Size(100, 20);
            this.user_password.TabIndex = 5;
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(193, 108);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.cancel_bt.TabIndex = 7;
            this.cancel_bt.Text = "Anuluj";
            this.cancel_bt.UseVisualStyleBackColor = true;
            // 
            // AddUserForm
            // 
            this.ClientSize = new System.Drawing.Size(336, 160);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.add_user_bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public AddUserForm()
        {
            InitializeComponent();
            cancel_bt.Click += cancel;
            add_user_bt.Click += add_user;
        }

        private void cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_user(object sender, EventArgs e)
        {
            String name = user_name.Text;
            string password = user_name.Text;          

            if (password == "" || name == "")
                MessageBox.Show("Wypelnij pole haslo");
            else
            {
                create_user(name, password);                
                this.Close();
            }
        }

        //TODO Zaszyfrowac klucz publiczny i prywatny za pomoca hasla!!!
        private void create_user(String name, String password)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(LENGHT_OF_KEY);
            var private_key = rsa.ToXmlString(true);
            var public_key = rsa.ToXmlString(false); // RSA.FromXmlString(publicKey);

            var SHA = SHA256.Create();
            byte[] hashed_password = SHA.ComputeHash(GetBytes(password));
            KeyParameter session_key = new KeyParameter(hashed_password);

            //szyfruje klucz prywatny za pomoca hasla, i skrotu funkcji SHA_256            

            using (StreamWriter sw = new StreamWriter(public_keys_path + name, true))
            {
                sw.Write(public_key);
                sw.Flush();
                sw.Close();
            }
            using (StreamWriter sw = new StreamWriter(private_keys_path + name + "tmp", true))
            {
                sw.Write(private_key);
                sw.Flush();
                sw.Close();
            }
            
            IAlgorithm alg = encryptFile(private_keys_path + name + "tmp", private_keys_path + name, "ECB", 128, 128, Convert.ToBase64String(hashed_password), session_key, hashed_password);
            Int64 length = alg.getSrcLength();
            Int64 step = System.Convert.ToInt64(Math.Ceiling(length / (double)100));
            Int64 bytes = 1;

            while (bytes > 0)
            {
                // "unit work" szyfrowanie fragmentu pliku
                bytes = alg.encrypt(step);
            }
            alg.Dispose();
            File.Delete(private_keys_path + name + "tmp");
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

        public IAlgorithm encryptFile(String src, String dst, String cipher_mode, int segment, int session_key_size, String password, KeyParameter key, byte[] iv) // dodac uzytnikow
        {
            IAlgorithm alg;

            //var key2 = Serpent.generateKey(session_key_size);

            //var iv2 = Serpent.generateIV();

            // szyfrowanie
            alg = new Serpent(key, iv, true);
            alg.init(src, dst, cipher_mode, segment, 0);

            return alg;
        }
    }
}
