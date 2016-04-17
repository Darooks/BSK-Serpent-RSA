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
            this.e_key_length_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.e_password_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.e_box_length_cb = new System.Windows.Forms.ComboBox();
            this.e_mode_cb = new System.Windows.Forms.ComboBox();
            this.e_length_subbox_cb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.e_path_button = new System.Windows.Forms.Button();
            this.path_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.encode_button = new System.Windows.Forms.Button();
            this.OdszyfrowanieTab = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.d_status_lbl = new System.Windows.Forms.Label();
            this.d_delete_receiver = new System.Windows.Forms.Button();
            this.d_add_receiver = new System.Windows.Forms.Button();
            this.receiver_lb = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.d_password_tb = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.d_path_tb = new System.Windows.Forms.TextBox();
            this.d_path_button = new System.Windows.Forms.Button();
            this.decode_button = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.SzyfrowanieTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.OdszyfrowanieTab.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SzyfrowanieTab);
            this.tabControl1.Controls.Add(this.OdszyfrowanieTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 541);
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
            this.SzyfrowanieTab.Size = new System.Drawing.Size(545, 515);
            this.SzyfrowanieTab.TabIndex = 0;
            this.SzyfrowanieTab.Text = "Szyfrowanie";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.e_status_lbl);
            this.groupBox3.Location = new System.Drawing.Point(54, 391);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 100);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aktualny status";
            // 
            // e_status_lbl
            // 
            this.e_status_lbl.AutoSize = true;
            this.e_status_lbl.Location = new System.Drawing.Point(92, 44);
            this.e_status_lbl.Name = "e_status_lbl";
            this.e_status_lbl.Size = new System.Drawing.Size(98, 13);
            this.e_status_lbl.TabIndex = 15;
            this.e_status_lbl.Text = "Wybierz ustawienia";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.e_key_length_cb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.e_password_tb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.e_box_length_cb);
            this.groupBox2.Controls.Add(this.e_mode_cb);
            this.groupBox2.Controls.Add(this.e_length_subbox_cb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(52, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 188);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ustawienia";
            // 
            // e_key_length_cb
            // 
            this.e_key_length_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_key_length_cb.FormattingEnabled = true;
            this.e_key_length_cb.Items.AddRange(new object[] {
            "128 bit",
            "192 bit",
            "256 bit"});
            this.e_key_length_cb.Location = new System.Drawing.Point(124, 40);
            this.e_key_length_cb.Name = "e_key_length_cb";
            this.e_key_length_cb.Size = new System.Drawing.Size(78, 21);
            this.e_key_length_cb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dlugosc klucza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dlugosc bloku";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tryb";
            // 
            // e_password_tb
            // 
            this.e_password_tb.Location = new System.Drawing.Point(124, 142);
            this.e_password_tb.Name = "e_password_tb";
            this.e_password_tb.Size = new System.Drawing.Size(78, 20);
            this.e_password_tb.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Haslo:";
            // 
            // e_box_length_cb
            // 
            this.e_box_length_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_box_length_cb.FormattingEnabled = true;
            this.e_box_length_cb.Items.AddRange(new object[] {
            "128 bit",
            "192 bit",
            "256 bit"});
            this.e_box_length_cb.Location = new System.Drawing.Point(124, 74);
            this.e_box_length_cb.Name = "e_box_length_cb";
            this.e_box_length_cb.Size = new System.Drawing.Size(78, 21);
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
            this.e_mode_cb.Location = new System.Drawing.Point(124, 107);
            this.e_mode_cb.Name = "e_mode_cb";
            this.e_mode_cb.Size = new System.Drawing.Size(78, 21);
            this.e_mode_cb.TabIndex = 9;
            // 
            // e_length_subbox_cb
            // 
            this.e_length_subbox_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_length_subbox_cb.FormattingEnabled = true;
            this.e_length_subbox_cb.Items.AddRange(new object[] {
            "2 bit",
            "4 bit",
            "8 bit",
            "16 bit",
            "32 bit",
            "64 bit"});
            this.e_length_subbox_cb.Location = new System.Drawing.Point(346, 106);
            this.e_length_subbox_cb.Name = "e_length_subbox_cb";
            this.e_length_subbox_cb.Size = new System.Drawing.Size(63, 21);
            this.e_length_subbox_cb.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dlugosc podbloku";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.e_path_button);
            this.groupBox1.Controls.Add(this.path_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 115);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plik wejsciowy";
            // 
            // e_path_button
            // 
            this.e_path_button.Location = new System.Drawing.Point(354, 53);
            this.e_path_button.Name = "e_path_button";
            this.e_path_button.Size = new System.Drawing.Size(75, 23);
            this.e_path_button.TabIndex = 2;
            this.e_path_button.Text = "Wybierz plik";
            this.e_path_button.UseVisualStyleBackColor = true;
            // 
            // path_tb
            // 
            this.path_tb.Location = new System.Drawing.Point(135, 55);
            this.path_tb.Name = "path_tb";
            this.path_tb.Size = new System.Drawing.Size(184, 20);
            this.path_tb.TabIndex = 1;
            this.path_tb.Text = "Wybierz plik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plik wejsciowy:";
            // 
            // encode_button
            // 
            this.encode_button.Location = new System.Drawing.Point(417, 468);
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
            this.OdszyfrowanieTab.Controls.Add(this.d_delete_receiver);
            this.OdszyfrowanieTab.Controls.Add(this.d_add_receiver);
            this.OdszyfrowanieTab.Controls.Add(this.receiver_lb);
            this.OdszyfrowanieTab.Controls.Add(this.groupBox5);
            this.OdszyfrowanieTab.Controls.Add(this.groupBox4);
            this.OdszyfrowanieTab.Controls.Add(this.decode_button);
            this.OdszyfrowanieTab.Location = new System.Drawing.Point(4, 22);
            this.OdszyfrowanieTab.Name = "OdszyfrowanieTab";
            this.OdszyfrowanieTab.Padding = new System.Windows.Forms.Padding(3);
            this.OdszyfrowanieTab.Size = new System.Drawing.Size(545, 515);
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
            // d_delete_receiver
            // 
            this.d_delete_receiver.Location = new System.Drawing.Point(403, 275);
            this.d_delete_receiver.Name = "d_delete_receiver";
            this.d_delete_receiver.Size = new System.Drawing.Size(109, 23);
            this.d_delete_receiver.TabIndex = 10;
            this.d_delete_receiver.Text = "Usun";
            this.d_delete_receiver.UseVisualStyleBackColor = true;
            // 
            // d_add_receiver
            // 
            this.d_add_receiver.Location = new System.Drawing.Point(288, 275);
            this.d_add_receiver.Name = "d_add_receiver";
            this.d_add_receiver.Size = new System.Drawing.Size(109, 23);
            this.d_add_receiver.TabIndex = 9;
            this.d_add_receiver.Text = "Dodaj";
            this.d_add_receiver.UseVisualStyleBackColor = true;
            // 
            // receiver_lb
            // 
            this.receiver_lb.FormattingEnabled = true;
            this.receiver_lb.Items.AddRange(new object[] {
            "Karol",
            "Karolina"});
            this.receiver_lb.Location = new System.Drawing.Point(288, 160);
            this.receiver_lb.Name = "receiver_lb";
            this.receiver_lb.Size = new System.Drawing.Size(224, 108);
            this.receiver_lb.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.d_password_tb);
            this.groupBox5.Location = new System.Drawing.Point(27, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(246, 100);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ustawienia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Haslo:";
            // 
            // d_password_tb
            // 
            this.d_password_tb.Location = new System.Drawing.Point(79, 44);
            this.d_password_tb.Name = "d_password_tb";
            this.d_password_tb.Size = new System.Drawing.Size(132, 20);
            this.d_password_tb.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.d_path_tb);
            this.groupBox4.Controls.Add(this.d_path_button);
            this.groupBox4.Location = new System.Drawing.Point(27, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Plik wejsciowy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Plik wejsciowy:";
            // 
            // d_path_tb
            // 
            this.d_path_tb.Location = new System.Drawing.Point(114, 45);
            this.d_path_tb.Name = "d_path_tb";
            this.d_path_tb.Size = new System.Drawing.Size(132, 20);
            this.d_path_tb.TabIndex = 2;
            this.d_path_tb.Text = "Wybierz plik";
            // 
            // d_path_button
            // 
            this.d_path_button.Location = new System.Drawing.Point(261, 43);
            this.d_path_button.Name = "d_path_button";
            this.d_path_button.Size = new System.Drawing.Size(75, 23);
            this.d_path_button.TabIndex = 4;
            this.d_path_button.Text = "Wybierz plik";
            this.d_path_button.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 564);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox path_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox e_length_subbox_cb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label e_status_lbl;
        private System.Windows.Forms.Button encode_button;
        private System.Windows.Forms.TextBox e_password_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button decode_button;
        private System.Windows.Forms.Button d_path_button;
        private System.Windows.Forms.TextBox d_password_tb;
        private System.Windows.Forms.TextBox d_path_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button e_path_button;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button d_delete_receiver;
        private System.Windows.Forms.Button d_add_receiver;
        private System.Windows.Forms.ListBox receiver_lb;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label d_status_lbl;
    }
}

