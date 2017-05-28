using System;
using System.Windows.Forms;
using WebKit;

namespace WinformChrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebKitBrowser browser = new WebKitBrowser();
            browser.Dock = DockStyle.Fill;//充满窗口  
            this.Controls.Add(browser);//添加到窗口  
            browser.Navigate("http://www.iot369.com");//跳转网页  
        }
    }
}
