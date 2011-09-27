using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SuperOffice;
using SuperOffice.Data;
using SuperOffice.CRM.Entities;

namespace SuperOfficeWinApp
{
    public partial class MainForm : Form
    {
        SoSession session;

        public MainForm()
        {
            InitializeComponent();

            this.AcceptButton = btnPopulate;
            lblStatus.Text = "Ready";
            txtUser.Focus();
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            if (!bwLogin.IsBusy)
            {
                tv.Nodes.Clear(); // clean up
                btnPopulate.Enabled = false;
                lblStatus.Text = "Requesting information...";
                bwLogin.RunWorkerAsync(new string[] { txtUser.Text.Trim(), txtPwd.Text.Trim() });
            }
        }

        private TreeNode[] AuthenticateAndPopulate(string user, string pwd)
        {
            TreeNode[] r = null;
            try
            {
                if (session == null || !session.IsOpen)
                    session = SoSession.Authenticate(user, pwd);

                r = PopulateData();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    while (ex.InnerException != null)
                        ex = ex.InnerException;

                MessageBox.Show("Error Authenticating", ex.Message, MessageBoxButtons.OK);
            }
            return r;
        }

        private TreeNode[] PopulateData()
        {
            List<string> r = new List<string>();

            // Session is Open
            if (session.IsOpen && session.Principal != null)
            {
                // Database info
                SoDatabase db = SoDatabase.GetCurrent();

                r.Add("Netserver in use:");
                r.Add("Name: " + SuperOffice.NetServerVersion.FullName);
                r.Add("Build: " + SuperOffice.NetServerVersion.Build.ToString());
                r.Add("Version: " + SuperOffice.NetServerVersion.Version.ToString());

                r.Add("*******************************");
                r.Add("Database information:");
                r.Add("Company Name: " + db.CompanyName);
                r.Add("Database Name: " + db.Database);
                r.Add("Serial Number: " + db.SerialNumber);

                // User info
                Contact c = Contact.GetFromIdxContactId(session.Principal.ContactId);

                r.Add("*******************************");
                r.Add("Associate information:");
                r.Add("Name: " + session.Principal.Associate);
                r.Add("Id: " + session.Principal.AssociateId.ToString());
                r.Add("Full Name: " + session.Principal.FullName);

                r.Add("*******************************");
                r.Add("Associate Company Information:");
                r.Add("Name: " + c.Name);
                r.Add("Country: " + c.Country.EnglishName);
                r.Add("OrgNr: " + c.OrgNr);
                r.Add("Total Persons: " + c.Persons.Count());
                r.Add("*******************************");

                session.Close();
                session = null;
            }

            // convert and return
            List<TreeNode> tnodes = new List<TreeNode>();
            foreach (var str in r)
                tnodes.Add(new TreeNode(str));

            return tnodes.ToArray();
        }

        private void bwLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            // do the work on a new thread
            string[] credentials = (string[])e.Argument;
            e.Result = AuthenticateAndPopulate(credentials[0], credentials[1]);
        }

        private void bwLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // populate using the main thread
            tv.Nodes.AddRange((TreeNode[])e.Result);

            btnPopulate.Enabled = true;
            lblStatus.Text = "Disconnected.";
        }

        private void btnClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // close app
            Application.Exit();
        }
    }
}
