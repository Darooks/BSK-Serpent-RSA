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

namespace BSK
{
    class AddAuthorizedForm : Form
    {
        public List<String> all_users = new List<String>();
        public List<String> users_on_list = new List<String>();
        private ListBox users_list;
        private Button add_user_bt;
        private Button cancel_bt;
        public String user;
        DirectoryInfo public_keys_path = new DirectoryInfo(@"C:\Serpent\BSK\bin\Debug\Users\PublicKeys\");

        public AddAuthorizedForm(List<String> list_from_form)
        {
            FileInfo[] Files = public_keys_path.GetFiles(); //Getting Text files

            if (Files != null)            
                foreach (FileInfo file in Files)                
                    if (!all_users.Contains(file.Name.ToString()) && !list_from_form.Contains(file.Name.ToString()))                    
                        all_users.Add(file.Name.ToString());

            InitializeComponent();
            foreach (var item in all_users)            
                users_list.Items.Add(item);
            add_user_bt.Click += add_user_to_list;
            cancel_bt.Click += cancel;

        }

        private void InitializeComponent()
        {
            this.users_list = new System.Windows.Forms.ListBox();
            this.add_user_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // users_list
            // 
            this.users_list.FormattingEnabled = true;
            this.users_list.Location = new System.Drawing.Point(50, 40);
            this.users_list.Name = "users_list";
            this.users_list.Size = new System.Drawing.Size(171, 147);
            this.users_list.TabIndex = 0;
            // 
            // add_user_bt
            // 
            this.add_user_bt.Location = new System.Drawing.Point(50, 210);
            this.add_user_bt.Name = "add_user_bt";
            this.add_user_bt.Size = new System.Drawing.Size(75, 23);
            this.add_user_bt.TabIndex = 1;
            this.add_user_bt.Text = "Dodaj";
            this.add_user_bt.UseVisualStyleBackColor = true;
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(146, 210);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.cancel_bt.TabIndex = 2;
            this.cancel_bt.Text = "Anuluj";
            this.cancel_bt.UseVisualStyleBackColor = true;
            // 
            // AddAuthorizedForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.add_user_bt);
            this.Controls.Add(this.users_list);
            this.Name = "AddAuthorizedForm";
            this.ResumeLayout(false);

        }

        private void add_user_to_list(object sender, EventArgs e)
        {
            user = users_list.SelectedItem.ToString();
            this.Close();
        }

        private void cancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
