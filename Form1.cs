using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;



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
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    string message = "Please input a Password";
                    MessageBox.Show(message);
                }
                else
                {
                    if (string.IsNullOrEmpty(txtUsername.Text))
                    {
                        string message = "Please input a Username";
                        MessageBox.Show(message);
                    }
                    else
                    {
                        Properties.Settings.Default.UpdPWord = txtPassword.Text;
                        Properties.Settings.Default.UpdUsrName = txtUsername.Text;
                        pnlsettings.Visible = false;
                    }

                }
                Properties.Settings.Default.IntervalMin = Convert.ToInt32(txtUpdate.Text);
                //Update in seconds for Debugging Uncomment
                //Properties.Settings.Default.Intervalms = Properties.Settings.Default.IntervalMin * 1000;
                //update in min for Production uncomment
                Properties.Settings.Default.Intervalms = Properties.Settings.Default.IntervalMin * 60000;
                UpdateTimer.Interval = Properties.Settings.Default.Intervalms;
            }
            txtUpdate.Text = string.Empty;
            //Debug.WriteLine(Properties.Settings.Default.UpdPWord);
            //Debug.WriteLine(Properties.Settings.Default.UpdUsrName);
            Properties.Settings.Default.Save();

        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            Properties.Settings.Default.externIP = (new WebClient()).DownloadString("https://ipv4.icanhazip.com/");
            lblPubIP.Text = Properties.Settings.Default.externIP;
            WebClient webClient = new WebClient();
            //Properties.Settings.Default.URI = "http://@srtdyn.co.za"; Uncomment if Broken
            Properties.Settings.Default.URI = "http://srtdyn.co.za"; //Comment if Broken
            Properties.Settings.Default.AuthString = Convert.ToBase64String(Encoding.ASCII.GetBytes(Properties.Settings.Default.UpdUsrName + ":" + Properties.Settings.Default.UpdPWord));
            //Debug.WriteLine(Properties.Settings.Default.URI);
            Properties.Settings.Default.randomcount = Properties.Settings.Default.randomcount + 1;
            //Debug.WriteLine(Properties.Settings.Default.randomcount);
            webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            webClient.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", Properties.Settings.Default.AuthString);
            Stream stream = webClient.OpenRead(Properties.Settings.Default.URI);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHiddenDebug.Text = "";
            Properties.Settings.Default.externIP = (new WebClient()).DownloadString("https://ipv4.icanhazip.com/");
            lblPubIP.Text = Properties.Settings.Default.externIP;
            WebClient webClient = new WebClient();
            Properties.Settings.Default.URI = "http://" + Properties.Settings.Default.UpdUsrName + ":" + Properties.Settings.Default.UpdPWord + "@srtdyn.co.za";
            lblHiddenDebug.Text = Properties.Settings.Default.URI;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTimer.Interval = Properties.Settings.Default.Intervalms;
            lnklblActiveDomain.Text = Properties.Settings.Default.UpdUsrName + ".srtdyn.co.za";
            lblUpdTime.Text = Convert.ToString(Properties.Settings.Default.IntervalMin) + " Minutes.";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.UpdUsrName))
            {
                string message = "Please Check the Settings";
                MessageBox.Show(message);
            }
            else
            {
                UpdateTimer.Enabled = true;
                WebClient webClient = new WebClient();
                Properties.Settings.Default.URI = "http://srtdyn.co.za"; //Comment if Broken
                Properties.Settings.Default.AuthString = Convert.ToBase64String(Encoding.ASCII.GetBytes(Properties.Settings.Default.UpdUsrName + ":" + Properties.Settings.Default.UpdPWord));
                //Debug.WriteLine(Properties.Settings.Default.URI);
                Properties.Settings.Default.randomcount = Properties.Settings.Default.randomcount + 1;
                //Debug.WriteLine(Properties.Settings.Default.randomcount);
                webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                webClient.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", Properties.Settings.Default.AuthString);
                Stream stream = webClient.OpenRead(Properties.Settings.Default.URI);
                btnStop.Enabled = true;
                btnStart.Enabled = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            UpdateTimer.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            lblHiddenDebug.Visible = true;
            btnDebug.Visible = true;
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            lblHiddenDebug.Visible = false;
            btnDebug.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDomain_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlsettings.Visible = true;
        }

        private void lblHiddenDebug_Click(object sender, EventArgs e)
        {

        }
    }
}
