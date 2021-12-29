
namespace DDNS_Updater
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
            this.lblPubIP = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.btnDebug = new System.Windows.Forms.Button();
            this.lblExternalIP = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblHiddenDebug = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlsettings = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblUpdateInterval = new System.Windows.Forms.Label();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbldom = new System.Windows.Forms.Label();
            this.lnklblActiveDomain = new System.Windows.Forms.LinkLabel();
            this.lblactivedomain = new System.Windows.Forms.Label();
            this.lblUpdInterval = new System.Windows.Forms.Label();
            this.lblUpdTime = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlsettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPubIP
            // 
            resources.ApplyResources(this.lblPubIP, "lblPubIP");
            this.lblPubIP.Name = "lblPubIP";
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // btnDebug
            // 
            resources.ApplyResources(this.btnDebug, "btnDebug");
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblExternalIP
            // 
            resources.ApplyResources(this.lblExternalIP, "lblExternalIP");
            this.lblExternalIP.Name = "lblExternalIP";
            this.lblExternalIP.Click += new System.EventHandler(this.label2_Click);
            this.lblExternalIP.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblHiddenDebug
            // 
            resources.ApplyResources(this.lblHiddenDebug, "lblHiddenDebug");
            this.lblHiddenDebug.Name = "lblHiddenDebug";
            this.lblHiddenDebug.Click += new System.EventHandler(this.lblHiddenDebug_Click);
            this.lblHiddenDebug.DoubleClick += new System.EventHandler(this.label3_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // pnlsettings
            // 
            resources.ApplyResources(this.pnlsettings, "pnlsettings");
            this.pnlsettings.Controls.Add(this.txtPassword);
            this.pnlsettings.Controls.Add(this.txtUsername);
            this.pnlsettings.Controls.Add(this.lblPassword);
            this.pnlsettings.Controls.Add(this.lblDomain);
            this.pnlsettings.Controls.Add(this.lblUpdateInterval);
            this.pnlsettings.Controls.Add(this.txtUpdate);
            this.pnlsettings.Controls.Add(this.btnUpdate);
            this.pnlsettings.Controls.Add(this.lbldom);
            this.pnlsettings.Name = "pnlsettings";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // lblDomain
            // 
            resources.ApplyResources(this.lblDomain, "lblDomain");
            this.lblDomain.Name = "lblDomain";
            // 
            // lblUpdateInterval
            // 
            resources.ApplyResources(this.lblUpdateInterval, "lblUpdateInterval");
            this.lblUpdateInterval.Name = "lblUpdateInterval";
            // 
            // txtUpdate
            // 
            resources.ApplyResources(this.txtUpdate, "txtUpdate");
            this.txtUpdate.Name = "txtUpdate";
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbldom
            // 
            resources.ApplyResources(this.lbldom, "lbldom");
            this.lbldom.Name = "lbldom";
            // 
            // lnklblActiveDomain
            // 
            resources.ApplyResources(this.lnklblActiveDomain, "lnklblActiveDomain");
            this.lnklblActiveDomain.Name = "lnklblActiveDomain";
            this.lnklblActiveDomain.TabStop = true;
            // 
            // lblactivedomain
            // 
            resources.ApplyResources(this.lblactivedomain, "lblactivedomain");
            this.lblactivedomain.Name = "lblactivedomain";
            // 
            // lblUpdInterval
            // 
            resources.ApplyResources(this.lblUpdInterval, "lblUpdInterval");
            this.lblUpdInterval.Name = "lblUpdInterval";
            // 
            // lblUpdTime
            // 
            resources.ApplyResources(this.lblUpdTime, "lblUpdTime");
            this.lblUpdTime.Name = "lblUpdTime";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlsettings);
            this.Controls.Add(this.lblUpdTime);
            this.Controls.Add(this.lblUpdInterval);
            this.Controls.Add(this.lblactivedomain);
            this.Controls.Add(this.lnklblActiveDomain);
            this.Controls.Add(this.lblHiddenDebug);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblExternalIP);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.lblPubIP);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlsettings.ResumeLayout(false);
            this.pnlsettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPubIP;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Label lblExternalIP;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblHiddenDebug;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlsettings;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblUpdateInterval;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbldom;
        private System.Windows.Forms.LinkLabel lnklblActiveDomain;
        private System.Windows.Forms.Label lblactivedomain;
        private System.Windows.Forms.Label lblUpdInterval;
        private System.Windows.Forms.Label lblUpdTime;
    }
}

