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
using System.Net.Http;
using System.Diagnostics;



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
                        Program.UpdPWord = txtPassword.Text;
                        Program.UpdUsrName = txtUsername.Text;
                    }

                }
                Program.Intervalsec = Convert.ToInt32(txtUpdate.Text);
                Program.Intervalms = Program.Intervalsec * 60000;
                UpdateTimer.Interval = Program.Intervalms;
            }
            txtUpdate.Text = string.Empty;

            Debug.WriteLine(Program.UpdPWord);
            Debug.WriteLine(Program.UpdUsrName);
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {

            Program.externIP = (new WebClient()).DownloadString("https://ipv4.icanhazip.com/");
            lblPubIP.Text = Program.externIP;
            WebClient webClient = new WebClient();
            Program.URI = "http://@dyn.srtech.org.za";
            Program.AuthString = Convert.ToBase64String(Encoding.ASCII.GetBytes(Program.UpdUsrName + ":" + Program.UpdPWord));
            Debug.WriteLine(Program.URI);
            webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            webClient.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", Program.AuthString);
            Stream stream = webClient.OpenRead(Program.URI);


            //Program.URI = "http://@dyn.srtech.org.za";
            //WebRequest request = WebRequest.Create(Program.URI);
            //string authInfo = Program.UpdUsrName + ":" + Program.UpdPWord;
            //authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            //request.Headers.Add("Authorization", "Basic " + authInfo);
            //request.ContentType = "application/json";
            //request.Method = WebRequestMethods.Http.Get;
            //request.Proxy = null;
            //HttpWebResponse httpWebResponse = (HttpWebResponse)request.GetResponse();
            //HttpWebResponse response = httpWebResponse;
            //Stream stream = response.GetResponseStream();
            //StreamReader streamreader = new StreamReader(stream);
            //string s = streamreader.ReadToEnd();
            //lblUpdate_Output.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            Program.externIP = (new WebClient()).DownloadString("https://ipv4.icanhazip.com/");
            lblPubIP.Text = Program.externIP;
            WebClient webClient = new WebClient();
            Program.URI = "http://" + Program.UpdUsrName + ":" + Program.UpdPWord + "@dyn.srtech.org.za";
            label3.Text = Program.URI;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTimer.Interval = 5000;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty (Program.UpdUsrName))
            {
                string message = "Please Check the Settings";
                MessageBox.Show(message);
            }
            else
            {
                UpdateTimer.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            UpdateTimer.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            label3.Visible = true;
            button1.Visible = true;
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            label3.Visible = false;
            button1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
