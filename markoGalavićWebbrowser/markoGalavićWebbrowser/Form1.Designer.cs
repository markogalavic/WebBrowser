namespace markoGalavićWebbrowser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.buttonNatrag = new System.Windows.Forms.Button();
            this.buttonNaprijed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.buttonIdi = new System.Windows.Forms.Button();
            this.buttonGmail = new System.Windows.Forms.Button();
            this.buttonWebmail = new System.Windows.Forms.Button();
            this.buttonIspis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(23, 57);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1223, 553);
            this.webBrowser1.TabIndex = 0;
            // 
            // buttonNatrag
            // 
            this.buttonNatrag.Location = new System.Drawing.Point(36, 23);
            this.buttonNatrag.Name = "buttonNatrag";
            this.buttonNatrag.Size = new System.Drawing.Size(75, 23);
            this.buttonNatrag.TabIndex = 1;
            this.buttonNatrag.Text = "Natrag";
            this.buttonNatrag.UseVisualStyleBackColor = true;
            this.buttonNatrag.Click += new System.EventHandler(this.buttonNatrag_Click);
            // 
            // buttonNaprijed
            // 
            this.buttonNaprijed.Location = new System.Drawing.Point(139, 23);
            this.buttonNaprijed.Name = "buttonNaprijed";
            this.buttonNaprijed.Size = new System.Drawing.Size(75, 23);
            this.buttonNaprijed.TabIndex = 2;
            this.buttonNaprijed.Text = "Naprijed";
            this.buttonNaprijed.UseVisualStyleBackColor = true;
            this.buttonNaprijed.Click += new System.EventHandler(this.buttonNaprijed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adresa";
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(303, 25);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(495, 20);
            this.textBoxAdresa.TabIndex = 4;
            // 
            // buttonIdi
            // 
            this.buttonIdi.Location = new System.Drawing.Point(823, 23);
            this.buttonIdi.Name = "buttonIdi";
            this.buttonIdi.Size = new System.Drawing.Size(75, 23);
            this.buttonIdi.TabIndex = 5;
            this.buttonIdi.Text = "Idi";
            this.buttonIdi.UseVisualStyleBackColor = true;
            this.buttonIdi.Click += new System.EventHandler(this.buttonIdi_Click);
            // 
            // buttonGmail
            // 
            this.buttonGmail.Location = new System.Drawing.Point(919, 23);
            this.buttonGmail.Name = "buttonGmail";
            this.buttonGmail.Size = new System.Drawing.Size(75, 23);
            this.buttonGmail.TabIndex = 6;
            this.buttonGmail.Text = "Gmail";
            this.buttonGmail.UseVisualStyleBackColor = true;
            this.buttonGmail.Click += new System.EventHandler(this.buttonGmail_Click);
            // 
            // buttonWebmail
            // 
            this.buttonWebmail.Location = new System.Drawing.Point(1012, 23);
            this.buttonWebmail.Name = "buttonWebmail";
            this.buttonWebmail.Size = new System.Drawing.Size(75, 23);
            this.buttonWebmail.TabIndex = 7;
            this.buttonWebmail.Text = "Webmail";
            this.buttonWebmail.UseVisualStyleBackColor = true;
            // 
            // buttonIspis
            // 
            this.buttonIspis.Location = new System.Drawing.Point(1104, 23);
            this.buttonIspis.Name = "buttonIspis";
            this.buttonIspis.Size = new System.Drawing.Size(75, 23);
            this.buttonIspis.TabIndex = 8;
            this.buttonIspis.Text = "Ispis";
            this.buttonIspis.UseVisualStyleBackColor = true;
            this.buttonIspis.Click += new System.EventHandler(this.buttonIspis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 637);
            this.Controls.Add(this.buttonIspis);
            this.Controls.Add(this.buttonWebmail);
            this.Controls.Add(this.buttonGmail);
            this.Controls.Add(this.buttonIdi);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNaprijed);
            this.Controls.Add(this.buttonNatrag);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buttonNatrag;
        private System.Windows.Forms.Button buttonNaprijed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.Button buttonIdi;
        private System.Windows.Forms.Button buttonGmail;
        private System.Windows.Forms.Button buttonWebmail;
        private System.Windows.Forms.Button buttonIspis;
    }
}

