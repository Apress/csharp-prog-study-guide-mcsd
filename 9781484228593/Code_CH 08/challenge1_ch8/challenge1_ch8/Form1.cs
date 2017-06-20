using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;


namespace challenge1_ch8
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event of the Download button
        /// </summary>
        private async void btnDownload_Click(object sender, EventArgs e)
        {
            btnDownload.Enabled = !btnDownload.Enabled;

            lblHTML.Text = await GetHTML(txtbxInput.Text);
                  
            btnDownload.Enabled = !btnDownload.Enabled;

        }

        /// <summary>
        /// Asyncronously gets the html from url
        /// </summary>
        /// <param name="url">url whose html needs to be extracted</param>
        /// <returns>returns html code of url</returns>
        private async Task<string> GetHTML(string url)
        {
            WebClient client = new WebClient();

            string htmlcode = await client.DownloadStringTaskAsync(url);

            return htmlcode;
        }

       
    }
}
