namespace BSK
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SzyfrowanieTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.e_status_lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.e_delete_user = new System.Windows.Forms.Button();
            this.e_add_user = new System.Windows.Forms.Button();
            this.e_users_list = new System.Windows.Forms.ListBox();
            this.e_key_length_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.e_box_length_cb = new System.Windows.Forms.ComboBox();
            this.e_mode_cb = new System.Windows.Forms.ComboBox();
            this.e_length_subbox_cb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.e_dst_button = new System.Windows.Forms.Button();
            this.e_dst_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.e_src_button = new System.Windows.Forms.Button();
            this.e_src_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.encode_button = new System.Windows.Forms.Button();
            this.OdszyfrowanieTab = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.d_status_lbl = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.d_users_list = new System.Windows.Forms.ListBox();
            this.d_password_tb = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.d_src_tb = new System.Windows.Forms.TextBox();
            this.d_src_button = new System.Windows.Forms.Button();
            this.decode_button = new System.Windows.Forms.Button();
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.odbiorcyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajOdbiorceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.d_dst_tb = new System.Windows.Forms.TextBox();
            this.d_dst_button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SzyfrowanieTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.OdszyfrowanieTab.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.main_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SzyfrowanieTab);
            this.tabControl1.Controls.Add(this.OdszyfrowanieTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 533);
            this.tabControl1.TabIndex = 0;
            // 
            // SzyfrowanieTab
            // 
            this.SzyfrowanieTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SzyfrowanieTab.Controls.Add(this.groupBox3);
            this.SzyfrowanieTab.Controls.Add(this.groupBox2);
            this.SzyfrowanieTab.Controls.Add(this.groupBox1);
            this.SzyfrowanieTab.Controls.Add(this.encode_button);
            this.SzyfrowanieTab.Location = new System.Drawing.Point(4, 22);
            this.SzyfrowanieTab.Name = "SzyfrowanieTab";
            this.SzyfrowanieTab.Padding = new System.Windows.Forms.Padding(3);
            this.SzyfrowanieTab.Size = new System.Drawing.Size(545, 507);
            this.SzyfrowanieTab.TabIndex = 0;
            this.SzyfrowanieTab.Text = "Szyfrowanie";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.e_status_lbl);
            this.groupBox3.Location = new System.Drawing.Point(52, 409);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 72);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aktualny status";
            // 
            // e_status_lbl
            // 
            this.e_status_lbl.AutoSize = true;
            this.e_status_lbl.Location = new System.Drawing.Point(89, 33);
            this.e_status_lbl.Name = "e_status_lbl";
            this.e_status_lbl.Size = new System.Drawing.Size(98, 13);
            this.e_status_lbl.TabIndex = 15;
            this.e_status_lbl.Text = "Wybierz ustawienia";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.e_delete_user);
            this.groupBox2.Controls.Add(this.e_add_user);
            this.groupBox2.Controls.Add(this.e_users_list);
            this.groupBox2.Controls.Add(this.e_key_length_cb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.e_box_length_cb);
            this.groupBox2.Controls.Add(this.e_mode_cb);
            this.groupBox2.Controls.Add(this.e_length_subbox_cb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(52, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 226);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ustawienia";
            // 
            // e_delete_user
            // 
            this.e_delete_user.Location = new System.Drawing.Point(333, 165);
            this.e_delete_user.Name = "e_delete_user";
            this.e_delete_user.Size = new System.Drawing.Size(91, 23);
            this.e_delete_user.TabIndex = 16;
            this.e_delete_user.Text = "Usun";
            this.e_delete_user.UseVisualStyleBackColor = true;
            // 
            // e_add_user
            // 
            this.e_add_user.Location = new System.Drawing.Point(226, 165);
            this.e_add_user.Name = "e_add_user";
            this.e_add_user.Size = new System.Drawing.Size(88, 23);
            this.e_add_user.TabIndex = 15;
            this.e_add_user.Text = "Dodaj";
            this.e_add_user.UseVisualStyleBackColor = true;
            // 
            // e_users_list
            // 
            this.e_users_list.FormattingEnabled = true;
            this.e_users_list.Location = new System.Drawing.Point(226, 51);
            this.e_users_list.Name = "e_users_list";
            this.e_users_list.Size = new System.Drawing.Size(198, 108);
            this.e_users_list.TabIndex = 14;
            // 
            // e_key_length_cb
            // 
            this.e_key_length_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_key_length_cb.FormattingEnabled = true;
            this.e_key_length_cb.Items.AddRange(new object[] {
            "128 bit",
            "192 bit",
            "256 bit"});
            this.e_key_length_cb.Location = new System.Drawing.Point(124, 78);
            this.e_key_length_cb.Name = "e_key_length_cb";
            this.e_key_length_cb.Size = new System.Drawing.Size(50, 21);
            this.e_key_length_cb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dlugosc klucza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dlugosc bloku";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tryb";
            // 
            // e_box_length_cb
            // 
            this.e_box_length_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_box_length_cb.FormattingEnabled = true;
            this.e_box_length_cb.Items.AddRange(new object[] {
            "128 bit",
            "192 bit",
            "256 bit"});
            this.e_box_length_cb.Location = new System.Drawing.Point(124, 105);
            this.e_box_length_cb.Name = "e_box_length_cb";
            this.e_box_length_cb.Size = new System.Drawing.Size(50, 21);
            this.e_box_length_cb.TabIndex = 8;
            // 
            // e_mode_cb
            // 
            this.e_mode_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_mode_cb.FormattingEnabled = true;
            this.e_mode_cb.Items.AddRange(new object[] {
            "ECB",
            "CBC",
            "CFB",
            "OFB"});
            this.e_mode_cb.Location = new System.Drawing.Point(124, 51);
            this.e_mode_cb.Name = "e_mode_cb";
            this.e_mode_cb.Size = new System.Drawing.Size(50, 21);
            this.e_mode_cb.TabIndex = 9;
            // 
            // e_length_subbox_cb
            // 
            this.e_length_subbox_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_length_subbox_cb.FormattingEnabled = true;
            this.e_length_subbox_cb.Items.AddRange(new object[] {
            "8 bit",
            "16 bit",
            "24 bit",
            "32 bit",
            "40 bit",
            "48 bit",
            "56 bit",
            "64 bit",
            "72 bit",
            "80 bit",
            "88 bit",
            "96 bit",
            "104 bit",
            "112 bit",
            "120 bit",
            "128 bit"});
            this.e_length_subbox_cb.Location = new System.Drawing.Point(124, 132);
            this.e_length_subbox_cb.Name = "e_length_subbox_cb";
            this.e_length_subbox_cb.Size = new System.Drawing.Size(50, 21);
            this.e_length_subbox_cb.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dlugosc podbloku";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.e_dst_button);
            this.groupBox1.Controls.Add(this.e_dst_tb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.e_src_button);
            this.groupBox1.Controls.Add(this.e_src_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 115);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plik wejsciowy";
            // 
            // e_dst_button
            // 
            this.e_dst_button.Location = new System.Drawing.Point(354, 69);
            this.e_dst_button.Name = "e_dst_button";
            this.e_dst_button.Size = new System.Drawing.Size(75, 23);
            this.e_dst_button.TabIndex = 5;
            this.e_dst_button.Text = "Wybierz plik";
            this.e_dst_button.UseVisualStyleBackColor = true;
            // 
            // e_dst_tb
            // 
            this.e_dst_tb.Location = new System.Drawing.Point(135, 71);
            this.e_dst_tb.Name = "e_dst_tb";
            this.e_dst_tb.Size = new System.Drawing.Size(184, 20);
            this.e_dst_tb.TabIndex = 4;
            this.e_dst_tb.Text = "Wybierz plik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plik wyjsciowy:";
            // 
            // e_src_button
            // 
            this.e_src_button.Location = new System.Drawing.Point(354, 33);
            this.e_src_button.Name = "e_src_button";
            this.e_src_button.Size = new System.Drawing.Size(75, 23);
            this.e_src_button.TabIndex = 2;
            this.e_src_button.Text = "Wybierz plik";
            this.e_src_button.UseVisualStyleBackColor = true;
            // 
            // e_src_tb
            // 
            this.e_src_tb.Location = new System.Drawing.Point(135, 35);
            this.e_src_tb.Name = "e_src_tb";
            this.e_src_tb.Size = new System.Drawing.Size(184, 20);
            this.e_src_tb.TabIndex = 1;
            this.e_src_tb.Text = "Wybierz plik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plik wejsciowy:";
            // 
            // encode_button
            // 
            this.encode_button.Location = new System.Drawing.Point(417, 458);
            this.encode_button.Name = "encode_button";
            this.encode_button.Size = new System.Drawing.Size(75, 23);
            this.encode_button.TabIndex = 14;
            this.encode_button.Text = "Szyfruj";
            this.encode_button.UseVisualStyleBackColor = true;
            // 
            // OdszyfrowanieTab
            // 
            this.OdszyfrowanieTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OdszyfrowanieTab.Controls.Add(this.groupBox6);
            this.OdszyfrowanieTab.Controls.Add(this.groupBox5);
            this.OdszyfrowanieTab.Controls.Add(this.groupBox4);
            this.OdszyfrowanieTab.Controls.Add(this.decode_button);
            this.OdszyfrowanieTab.Location = new System.Drawing.Point(4, 22);
            this.OdszyfrowanieTab.Name = "OdszyfrowanieTab";
            this.OdszyfrowanieTab.Padding = new System.Windows.Forms.Padding(3);
            this.OdszyfrowanieTab.Size = new System.Drawing.Size(545, 507);
            this.OdszyfrowanieTab.TabIndex = 1;
            this.OdszyfrowanieTab.Text = "Odszyfrowanie";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.d_status_lbl);
            this.groupBox6.Location = new System.Drawing.Point(27, 360);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(246, 100);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Aktualny stan";
            // 
            // d_status_lbl
            // 
            this.d_status_lbl.AutoSize = true;
            this.d_status_lbl.Location = new System.Drawing.Point(66, 47);
            this.d_status_lbl.Name = "d_status_lbl";
            this.d_status_lbl.Size = new System.Drawing.Size(98, 13);
            this.d_status_lbl.TabIndex = 0;
            this.d_status_lbl.Text = "Wybierz ustawienia";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.d_users_list);
            this.groupBox5.Controls.Add(this.d_password_tb);
            this.groupBox5.Location = new System.Drawing.Point(27, 175);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(485, 161);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ustawienia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Haslo:";
            // 
            // d_users_list
            // 
            this.d_users_list.FormattingEnabled = true;
            this.d_users_list.Location = new System.Drawing.Point(239, 28);
            this.d_users_list.Name = "d_users_list";
            this.d_users_list.Size = new System.Drawing.Size(224, 108);
            this.d_users_list.TabIndex = 8;
            // 
            // d_password_tb
            // 
            this.d_password_tb.Location = new System.Drawing.Point(57, 28);
            this.d_password_tb.Name = "d_password_tb";
            this.d_password_tb.Size = new System.Drawing.Size(132, 20);
            this.d_password_tb.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.d_dst_button);
            this.groupBox4.Controls.Add(this.d_dst_tb);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.d_src_tb);
            this.groupBox4.Controls.Add(this.d_src_button);
            this.groupBox4.Location = new System.Drawing.Point(27, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 121);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Plik wejsciowy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Plik wejsciowy:";
            // 
            // d_src_tb
            // 
            this.d_src_tb.Location = new System.Drawing.Point(135, 33);
            this.d_src_tb.Name = "d_src_tb";
            this.d_src_tb.Size = new System.Drawing.Size(132, 20);
            this.d_src_tb.TabIndex = 2;
            this.d_src_tb.Text = "Wybierz plik";
            // 
            // d_src_button
            // 
            this.d_src_button.Location = new System.Drawing.Point(315, 31);
            this.d_src_button.Name = "d_src_button";
            this.d_src_button.Size = new System.Drawing.Size(75, 23);
            this.d_src_button.TabIndex = 4;
            this.d_src_button.Text = "Wybierz plik";
            this.d_src_button.UseVisualStyleBackColor = true;
            // 
            // decode_button
            // 
            this.decode_button.Location = new System.Drawing.Point(437, 437);
            this.decode_button.Name = "decode_button";
            this.decode_button.Size = new System.Drawing.Size(75, 23);
            this.decode_button.TabIndex = 5;
            this.decode_button.Text = "Odszyfruj";
            this.decode_button.UseVisualStyleBackColor = true;
            // 
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odbiorcyToolStripMenuItem});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(575, 24);
            this.main_menu.TabIndex = 1;
            this.main_menu.Text = "menuStrip1";
            this.main_menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.main_menu_ItemClicked);
            // 
            // odbiorcyToolStripMenuItem
            // 
            this.odbiorcyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajOdbiorceToolStripMenuItem});
            this.odbiorcyToolStripMenuItem.Name = "odbiorcyToolStripMenuItem";
            this.odbiorcyToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.odbiorcyToolStripMenuItem.Text = "Odbiorcy";
            // 
            // dodajOdbiorceToolStripMenuItem
            // 
            this.dodajOdbiorceToolStripMenuItem.Name = "dodajOdbiorceToolStripMenuItem";
            this.dodajOdbiorceToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.dodajOdbiorceToolStripMenuItem.Text = "Dodaj Odbiorce";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Plik wyjsciowy";
            // 
            // d_dst_tb
            // 
            this.d_dst_tb.Location = new System.Drawing.Point(135, 74);
            this.d_dst_tb.Name = "d_dst_tb";
            this.d_dst_tb.Size = new System.Drawing.Size(132, 20);
            this.d_dst_tb.TabIndex = 6;
            this.d_dst_tb.Text = "Wybierz plik";
            // 
            // d_dst_button
            // 
            this.d_dst_button.Location = new System.Drawing.Point(315, 72);
            this.d_dst_button.Name = "d_dst_button";
            this.d_dst_button.Size = new System.Drawing.Size(75, 23);
            this.d_dst_button.TabIndex = 7;
            this.d_dst_button.Text = "Wybierz plik";
            this.d_dst_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 587);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.main_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.main_menu;
            this.Name = "Form1";
            this.Text = "Serpent";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.SzyfrowanieTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.OdszyfrowanieTab.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SzyfrowanieTab;
        private System.Windows.Forms.TabPage OdszyfrowanieTab;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox e_mode_cb;
        private System.Windows.Forms.ComboBox e_box_length_cb;
        private System.Windows.Forms.ComboBox e_key_length_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox e_src_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox e_length_subbox_cb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label e_status_lbl;
        private System.Windows.Forms.Button encode_button;
        private System.Windows.Forms.Button decode_button;
        private System.Windows.Forms.Button d_src_button;
        private System.Windows.Forms.TextBox d_password_tb;
        private System.Windows.Forms.TextBox d_src_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button e_src_button;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox d_users_list;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label d_status_lbl;

        EncodingProperties object_to_encode = new EncodingProperties();
        private System.Windows.Forms.Button e_delete_user;
        private System.Windows.Forms.Button e_add_user;
        private System.Windows.Forms.ListBox e_users_list;
        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem odbiorcyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajOdbiorceToolStripMenuItem;
        private System.Windows.Forms.Button e_dst_button;
        private System.Windows.Forms.TextBox e_dst_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button d_dst_button;
        private System.Windows.Forms.TextBox d_dst_tb;
        private System.Windows.Forms.Label label7;
    }
}

