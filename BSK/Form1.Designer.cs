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
            this.OdszyfrowanieTab = new System.Windows.Forms.TabPage();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.path_tb = new System.Windows.Forms.TextBox();
            this.e_path_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.e_key_lendth_cb = new System.Windows.Forms.ComboBox();
            this.e_box_length_cb = new System.Windows.Forms.ComboBox();
            this.e_mode_tb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.e_length_subbox_cb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.e_password_tb = new System.Windows.Forms.TextBox();
            this.encode_button = new System.Windows.Forms.Button();
            this.status_lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.d_path_tb = new System.Windows.Forms.TextBox();
            this.d_password_tb = new System.Windows.Forms.TextBox();
            this.d_path_button = new System.Windows.Forms.Button();
            this.decode_button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SzyfrowanieTab.SuspendLayout();
            this.OdszyfrowanieTab.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1037, 604);
            this.tabControl1.TabIndex = 0;
            // 
            // SzyfrowanieTab
            // 
            this.SzyfrowanieTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SzyfrowanieTab.Controls.Add(this.status_lbl);
            this.SzyfrowanieTab.Controls.Add(this.encode_button);
            this.SzyfrowanieTab.Controls.Add(this.e_password_tb);
            this.SzyfrowanieTab.Controls.Add(this.label7);
            this.SzyfrowanieTab.Controls.Add(this.e_length_subbox_cb);
            this.SzyfrowanieTab.Controls.Add(this.label6);
            this.SzyfrowanieTab.Controls.Add(this.e_mode_tb);
            this.SzyfrowanieTab.Controls.Add(this.e_box_length_cb);
            this.SzyfrowanieTab.Controls.Add(this.e_key_lendth_cb);
            this.SzyfrowanieTab.Controls.Add(this.label5);
            this.SzyfrowanieTab.Controls.Add(this.label4);
            this.SzyfrowanieTab.Controls.Add(this.label3);
            this.SzyfrowanieTab.Controls.Add(this.label2);
            this.SzyfrowanieTab.Controls.Add(this.e_path_button);
            this.SzyfrowanieTab.Controls.Add(this.path_tb);
            this.SzyfrowanieTab.Controls.Add(this.label1);
            this.SzyfrowanieTab.Location = new System.Drawing.Point(4, 22);
            this.SzyfrowanieTab.Name = "SzyfrowanieTab";
            this.SzyfrowanieTab.Padding = new System.Windows.Forms.Padding(3);
            this.SzyfrowanieTab.Size = new System.Drawing.Size(1029, 578);
            this.SzyfrowanieTab.TabIndex = 0;
            this.SzyfrowanieTab.Text = "Szyfrowanie";
            // 
            // OdszyfrowanieTab
            // 
            this.OdszyfrowanieTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OdszyfrowanieTab.Controls.Add(this.decode_button);
            this.OdszyfrowanieTab.Controls.Add(this.d_path_button);
            this.OdszyfrowanieTab.Controls.Add(this.d_password_tb);
            this.OdszyfrowanieTab.Controls.Add(this.d_path_tb);
            this.OdszyfrowanieTab.Controls.Add(this.label9);
            this.OdszyfrowanieTab.Controls.Add(this.label8);
            this.OdszyfrowanieTab.Location = new System.Drawing.Point(4, 22);
            this.OdszyfrowanieTab.Name = "OdszyfrowanieTab";
            this.OdszyfrowanieTab.Padding = new System.Windows.Forms.Padding(3);
            this.OdszyfrowanieTab.Size = new System.Drawing.Size(1029, 578);
            this.OdszyfrowanieTab.TabIndex = 1;
            this.OdszyfrowanieTab.Text = "Odszyfrowanie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plik wejsciowy:";
            // 
            // path_tb
            // 
            this.path_tb.Location = new System.Drawing.Point(171, 79);
            this.path_tb.Name = "path_tb";
            this.path_tb.Size = new System.Drawing.Size(184, 20);
            this.path_tb.TabIndex = 1;
            this.path_tb.Text = "Wybierz plik";
            // 
            // e_path_button
            // 
            this.e_path_button.Location = new System.Drawing.Point(371, 76);
            this.e_path_button.Name = "e_path_button";
            this.e_path_button.Size = new System.Drawing.Size(75, 23);
            this.e_path_button.TabIndex = 2;
            this.e_path_button.Text = "Wybierz plik";
            this.e_path_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ustawienia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dlugosc klucza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dlugosc bloku";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tryb";
            // 
            // e_key_lendth_cb
            // 
            this.e_key_lendth_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_key_lendth_cb.FormattingEnabled = true;
            this.e_key_lendth_cb.Items.AddRange(new object[] {
            "128 bit",
            "192 bit",
            "256 bit"});
            this.e_key_lendth_cb.Location = new System.Drawing.Point(193, 195);
            this.e_key_lendth_cb.Name = "e_key_lendth_cb";
            this.e_key_lendth_cb.Size = new System.Drawing.Size(78, 21);
            this.e_key_lendth_cb.TabIndex = 7;
            // 
            // e_box_length_cb
            // 
            this.e_box_length_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_box_length_cb.FormattingEnabled = true;
            this.e_box_length_cb.Items.AddRange(new object[] {
            "128bit"});
            this.e_box_length_cb.Location = new System.Drawing.Point(193, 229);
            this.e_box_length_cb.Name = "e_box_length_cb";
            this.e_box_length_cb.Size = new System.Drawing.Size(78, 21);
            this.e_box_length_cb.TabIndex = 8;
            // 
            // e_mode_tb
            // 
            this.e_mode_tb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.e_mode_tb.FormattingEnabled = true;
            this.e_mode_tb.Items.AddRange(new object[] {
            "ECB",
            "CBC",
            "CFB",
            "OFB"});
            this.e_mode_tb.Location = new System.Drawing.Point(193, 262);
            this.e_mode_tb.Name = "e_mode_tb";
            this.e_mode_tb.Size = new System.Drawing.Size(78, 21);
            this.e_mode_tb.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dlugosc podbloku";
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
            this.e_length_subbox_cb.Location = new System.Drawing.Point(415, 261);
            this.e_length_subbox_cb.Name = "e_length_subbox_cb";
            this.e_length_subbox_cb.Size = new System.Drawing.Size(63, 21);
            this.e_length_subbox_cb.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Haslo:";
            // 
            // e_password_tb
            // 
            this.e_password_tb.Location = new System.Drawing.Point(119, 376);
            this.e_password_tb.Name = "e_password_tb";
            this.e_password_tb.Size = new System.Drawing.Size(100, 20);
            this.e_password_tb.TabIndex = 13;
            // 
            // encode_button
            // 
            this.encode_button.Location = new System.Drawing.Point(64, 444);
            this.encode_button.Name = "encode_button";
            this.encode_button.Size = new System.Drawing.Size(75, 23);
            this.encode_button.TabIndex = 14;
            this.encode_button.Text = "Szyfruj";
            this.encode_button.UseVisualStyleBackColor = true;
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Location = new System.Drawing.Point(64, 494);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(98, 13);
            this.status_lbl.TabIndex = 15;
            this.status_lbl.Text = "Wybierz ustawienia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Plik wejsciowy:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Haslo:";
            // 
            // d_path_tb
            // 
            this.d_path_tb.Location = new System.Drawing.Point(144, 70);
            this.d_path_tb.Name = "d_path_tb";
            this.d_path_tb.Size = new System.Drawing.Size(132, 20);
            this.d_path_tb.TabIndex = 2;
            this.d_path_tb.Text = "Wybierz plik";
            // 
            // d_password_tb
            // 
            this.d_password_tb.Location = new System.Drawing.Point(144, 126);
            this.d_password_tb.Name = "d_password_tb";
            this.d_password_tb.Size = new System.Drawing.Size(132, 20);
            this.d_password_tb.TabIndex = 3;
            // 
            // d_path_button
            // 
            this.d_path_button.Location = new System.Drawing.Point(291, 68);
            this.d_path_button.Name = "d_path_button";
            this.d_path_button.Size = new System.Drawing.Size(75, 23);
            this.d_path_button.TabIndex = 4;
            this.d_path_button.Text = "Wybierz plik";
            this.d_path_button.UseVisualStyleBackColor = true;
            // 
            // decode_button
            // 
            this.decode_button.Location = new System.Drawing.Point(62, 225);
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
            this.ClientSize = new System.Drawing.Size(1061, 628);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Serpent";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.SzyfrowanieTab.ResumeLayout(false);
            this.SzyfrowanieTab.PerformLayout();
            this.OdszyfrowanieTab.ResumeLayout(false);
            this.OdszyfrowanieTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SzyfrowanieTab;
        private System.Windows.Forms.TabPage OdszyfrowanieTab;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox e_mode_tb;
        private System.Windows.Forms.ComboBox e_box_length_cb;
        private System.Windows.Forms.ComboBox e_key_lendth_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button e_path_button;
        private System.Windows.Forms.TextBox path_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox e_length_subbox_cb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.Button encode_button;
        private System.Windows.Forms.TextBox e_password_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button decode_button;
        private System.Windows.Forms.Button d_path_button;
        private System.Windows.Forms.TextBox d_password_tb;
        private System.Windows.Forms.TextBox d_path_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;

    }
}

