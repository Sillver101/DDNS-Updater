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
using System.IO;
using System.Text.RegularExpressions;



namespace DDNS_Updater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUpdate.Text))
            {
                string message = "Please input an Update Value";
                MessageBox.Show(message);
            }
            else
            {
                Program.Intervalsec = Convert.ToInt32(txtUpdate.Text);
                Program.Intervalms = Program.Intervalsec * 1000;
                UpdateTimer.Interval = Program.Intervalms;
            }
            txtUpdate.Text = string.Empty;
            //lblPubIP.Text = Convert.ToString(UpdateTimer.Interval);
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {

            //externIP = GetUserIPAddress();
            Program.externIP = (new WebClient()).DownloadString("https://ipv4.icanhazip.com/");
            //Program.externIP = (new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")).Matches(Program.externIP)[0].ToString();
            lblPubIP.Text = Program.externIP;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.externIP = (new WebClient()).DownloadString("https://ipv4.icanhazip.com/");
            lblPubIP.Text = Program.externIP;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTimer.Interval = 5000;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            UpdateTimer.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            UpdateTimer.Enabled = false;
        }
    }
}
