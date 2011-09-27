namespace SuperOfficeWinApp
{
    partial class MainForm
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
            this.lblNote = new System.Windows.Forms.Label();
            this.lblNoteDesc = new System.Windows.Forms.Label();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.groupBoxCredentials = new System.Windows.Forms.GroupBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.tv = new System.Windows.Forms.TreeView();
            this.bwLogin = new System.ComponentModel.BackgroundWorker();
            this.mainStatus = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxResponse = new System.Windows.Forms.GroupBox();
            this.lblCreator = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClose = new System.Windows.Forms.LinkLabel();
            this.lblOr = new System.Windows.Forms.Label();
            this.groupBoxCredentials.SuspendLayout();
            this.mainStatus.SuspendLayout();
            this.groupBoxResponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(297, 46);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(96, 20);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "Remember";
            // 
            // lblNoteDesc
            // 
            this.lblNoteDesc.Location = new System.Drawing.Point(298, 79);
            this.lblNoteDesc.Name = "lblNoteDesc";
            this.lblNoteDesc.Size = new System.Drawing.Size(138, 46);
            this.lblNoteDesc.TabIndex = 1;
            this.lblNoteDesc.Text = "Edit the database node in the app.config file, before build + run.";
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(9, 102);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(138, 37);
            this.btnPopulate.TabIndex = 3;
            this.btnPopulate.Text = "Populate Data";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(6, 32);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 13);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Username";
            // 
            // groupBoxCredentials
            // 
            this.groupBoxCredentials.Controls.Add(this.lblOr);
            this.groupBoxCredentials.Controls.Add(this.btnClose);
            this.groupBoxCredentials.Controls.Add(this.txtPwd);
            this.groupBoxCredentials.Controls.Add(this.lblPwd);
            this.groupBoxCredentials.Controls.Add(this.txtUser);
            this.groupBoxCredentials.Controls.Add(this.lblUser);
            this.groupBoxCredentials.Controls.Add(this.btnPopulate);
            this.groupBoxCredentials.Location = new System.Drawing.Point(15, 21);
            this.groupBoxCredentials.Name = "groupBoxCredentials";
            this.groupBoxCredentials.Size = new System.Drawing.Size(249, 148);
            this.groupBoxCredentials.TabIndex = 5;
            this.groupBoxCredentials.TabStop = false;
            this.groupBoxCredentials.Text = "Credentials";
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(67, 57);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(176, 24);
            this.txtPwd.TabIndex = 2;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(6, 64);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(53, 13);
            this.lblPwd.TabIndex = 6;
            this.lblPwd.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(67, 25);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(176, 24);
            this.txtUser.TabIndex = 1;
            // 
            // tv
            // 
            this.tv.Location = new System.Drawing.Point(6, 19);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(428, 182);
            this.tv.TabIndex = 0;
            // 
            // bwLogin
            // 
            this.bwLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLogin_DoWork);
            this.bwLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLogin_RunWorkerCompleted);
            // 
            // mainStatus
            // 
            this.mainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblCreator});
            this.mainStatus.Location = new System.Drawing.Point(0, 396);
            this.mainStatus.Name = "mainStatus";
            this.mainStatus.Size = new System.Drawing.Size(462, 22);
            this.mainStatus.TabIndex = 7;
            this.mainStatus.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBoxResponse
            // 
            this.groupBoxResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResponse.Controls.Add(this.tv);
            this.groupBoxResponse.Location = new System.Drawing.Point(12, 175);
            this.groupBoxResponse.Name = "groupBoxResponse";
            this.groupBoxResponse.Size = new System.Drawing.Size(440, 207);
            this.groupBoxResponse.TabIndex = 8;
            this.groupBoxResponse.TabStop = false;
            this.groupBoxResponse.Text = "System response";
            // 
            // lblCreator
            // 
            this.lblCreator.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreator.ForeColor = System.Drawing.Color.Silver;
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(447, 17);
            this.lblCreator.Spring = true;
            this.lblCreator.Text = "created by Bruno Alexandre, Sep 2010";
            this.lblCreator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(171, 112);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 16);
            this.btnClose.TabIndex = 7;
            this.btnClose.TabStop = true;
            this.btnClose.Text = "Close App";
            this.btnClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnClose_LinkClicked);
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(151, 114);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(16, 13);
            this.lblOr.TabIndex = 8;
            this.lblOr.Text = "or";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnPopulate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 418);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxResponse);
            this.Controls.Add(this.mainStatus);
            this.Controls.Add(this.groupBoxCredentials);
            this.Controls.Add(this.lblNoteDesc);
            this.Controls.Add(this.lblNote);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperOffice WinApp";
            this.groupBoxCredentials.ResumeLayout(false);
            this.groupBoxCredentials.PerformLayout();
            this.mainStatus.ResumeLayout(false);
            this.mainStatus.PerformLayout();
            this.groupBoxResponse.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblNoteDesc;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.GroupBox groupBoxCredentials;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TreeView tv;
        private System.ComponentModel.BackgroundWorker bwLogin;
        private System.Windows.Forms.StatusStrip mainStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox groupBoxResponse;
        private System.Windows.Forms.ToolStripStatusLabel lblCreator;
        private System.Windows.Forms.LinkLabel btnClose;
        private System.Windows.Forms.Label lblOr;
    }
}

