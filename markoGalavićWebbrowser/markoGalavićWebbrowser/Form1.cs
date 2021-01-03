using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace markoGalavićWebbrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            webBrowser1.GoHome();
        }

        private void buttonIdi_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }
        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if(!address.StartsWith("http://")&& !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowser1.Navigate(new Uri(address));
            }
            catch
            {
                return;
            }
        }

        private void buttonNatrag_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void buttonNaprijed_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void buttonIspis_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }

        private void buttonGmail_Click(object sender, EventArgs e)
        {
           
        }
    }
}
