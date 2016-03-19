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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SzyfrowanieTab = new System.Windows.Forms.TabPage();
            this.OdszyfrowanieTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
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
            this.OdszyfrowanieTab.Location = new System.Drawing.Point(4, 22);
            this.OdszyfrowanieTab.Name = "OdszyfrowanieTab";
            this.OdszyfrowanieTab.Padding = new System.Windows.Forms.Padding(3);
            this.OdszyfrowanieTab.Size = new System.Drawing.Size(1029, 578);
            this.OdszyfrowanieTab.TabIndex = 1;
            this.OdszyfrowanieTab.Text = "Odszyfrowanie";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SzyfrowanieTab;
        private System.Windows.Forms.TabPage OdszyfrowanieTab;

    }
}

