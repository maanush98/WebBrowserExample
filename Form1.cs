using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currency_converter
{
    public partial class currencyconvert : Form
    {
        public currencyconvert()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btnconverter_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.engvid.com/english-exams/ielts/");

        }
    }
}
