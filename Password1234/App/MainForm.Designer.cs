namespace App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabCtrlListes = new System.Windows.Forms.TabControl();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.oldPwdLbl = new System.Windows.Forms.Label();
            this.weakPwdLbl = new System.Windows.Forms.Label();
            this.AddAccountBtn = new System.Windows.Forms.Button();
            this.deleteAccountBtn = new System.Windows.Forms.Button();
            this.updateAccountBtn = new System.Windows.Forms.Button();
            this.pwdAccountTB = new System.Windows.Forms.TextBox();
            this.pwdAccountLbl = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.loginLbl = new System.Windows.Forms.Label();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.urlLbl = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.oldPwdLB = new System.Windows.Forms.ListBox();
            this.weakPwdLB = new System.Windows.Forms.ListBox();
            this.pwdLB = new System.Windows.Forms.ListBox();
            this.tabWifi = new System.Windows.Forms.TabPage();
            this.AddWifiBtn = new System.Windows.Forms.Button();
            this.deleteWifiBtn = new System.Windows.Forms.Button();
            this.updateWifiBtn = new System.Windows.Forms.Button();
            this.pwdWifiTB = new System.Windows.Forms.TextBox();
            this.pwdWifiLbl = new System.Windows.Forms.Label();
            this.ssidTB = new System.Windows.Forms.TextBox();
            this.ssidLbl = new System.Windows.Forms.Label();
            this.wifiLB = new System.Windows.Forms.ListBox();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.tabCtrlListes.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.tabWifi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlListes
            // 
            this.tabCtrlListes.Controls.Add(this.tabAccount);
            this.tabCtrlListes.Controls.Add(this.tabWifi);
            this.tabCtrlListes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlListes.Location = new System.Drawing.Point(1, 31);
            this.tabCtrlListes.Name = "tabCtrlListes";
            this.tabCtrlListes.SelectedIndex = 0;
            this.tabCtrlListes.Size = new System.Drawing.Size(509, 370);
            this.tabCtrlListes.TabIndex = 0;
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.oldPwdLbl);
            this.tabAccount.Controls.Add(this.weakPwdLbl);
            this.tabAccount.Controls.Add(this.AddAccountBtn);
            this.tabAccount.Controls.Add(this.deleteAccountBtn);
            this.tabAccount.Controls.Add(this.updateAccountBtn);
            this.tabAccount.Controls.Add(this.pwdAccountTB);
            this.tabAccount.Controls.Add(this.pwdAccountLbl);
            this.tabAccount.Controls.Add(this.loginTB);
            this.tabAccount.Controls.Add(this.loginLbl);
            this.tabAccount.Controls.Add(this.urlTB);
            this.tabAccount.Controls.Add(this.urlLbl);
            this.tabAccount.Controls.Add(this.nameTB);
            this.tabAccount.Controls.Add(this.nameLbl);
            this.tabAccount.Controls.Add(this.oldPwdLB);
            this.tabAccount.Controls.Add(this.weakPwdLB);
            this.tabAccount.Controls.Add(this.pwdLB);
            this.tabAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(501, 344);
            this.tabAccount.TabIndex = 0;
            this.tabAccount.Text = "Comptes";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // oldPwdLbl
            // 
            this.oldPwdLbl.AutoSize = true;
            this.oldPwdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPwdLbl.Location = new System.Drawing.Point(6, 205);
            this.oldPwdLbl.Name = "oldPwdLbl";
            this.oldPwdLbl.Size = new System.Drawing.Size(72, 13);
            this.oldPwdLbl.TabIndex = 18;
            this.oldPwdLbl.Text = "+ de 6 mois";
            // 
            // weakPwdLbl
            // 
            this.weakPwdLbl.AutoSize = true;
            this.weakPwdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weakPwdLbl.Location = new System.Drawing.Point(6, 101);
            this.weakPwdLbl.Name = "weakPwdLbl";
            this.weakPwdLbl.Size = new System.Drawing.Size(47, 13);
            this.weakPwdLbl.TabIndex = 17;
            this.weakPwdLbl.Text = "Faibles";
            // 
            // AddAccountBtn
            // 
            this.AddAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.AddAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAccountBtn.ForeColor = System.Drawing.Color.White;
            this.AddAccountBtn.Location = new System.Drawing.Point(3, 320);
            this.AddAccountBtn.Name = "AddAccountBtn";
            this.AddAccountBtn.Size = new System.Drawing.Size(120, 23);
            this.AddAccountBtn.TabIndex = 16;
            this.AddAccountBtn.Text = "+ Ajouter";
            this.AddAccountBtn.UseVisualStyleBackColor = false;
            this.AddAccountBtn.Click += new System.EventHandler(this.AddAccountBtn_Click);
            // 
            // deleteAccountBtn
            // 
            this.deleteAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.deleteAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAccountBtn.ForeColor = System.Drawing.Color.White;
            this.deleteAccountBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteAccountBtn.Image")));
            this.deleteAccountBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteAccountBtn.Location = new System.Drawing.Point(373, 274);
            this.deleteAccountBtn.Name = "deleteAccountBtn";
            this.deleteAccountBtn.Size = new System.Drawing.Size(79, 23);
            this.deleteAccountBtn.TabIndex = 12;
            this.deleteAccountBtn.Text = "Supprimer";
            this.deleteAccountBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteAccountBtn.UseVisualStyleBackColor = false;
            this.deleteAccountBtn.Click += new System.EventHandler(this.deleteAccountBtn_Click);
            // 
            // updateAccountBtn
            // 
            this.updateAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.updateAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateAccountBtn.ForeColor = System.Drawing.Color.White;
            this.updateAccountBtn.Image = ((System.Drawing.Image)(resources.GetObject("updateAccountBtn.Image")));
            this.updateAccountBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateAccountBtn.Location = new System.Drawing.Point(252, 274);
            this.updateAccountBtn.Name = "updateAccountBtn";
            this.updateAccountBtn.Size = new System.Drawing.Size(72, 23);
            this.updateAccountBtn.TabIndex = 11;
            this.updateAccountBtn.Text = "Modifier";
            this.updateAccountBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateAccountBtn.UseVisualStyleBackColor = false;
            this.updateAccountBtn.Click += new System.EventHandler(this.updateAccountBtn_Click);
            // 
            // pwdAccountTB
            // 
            this.pwdAccountTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pwdAccountTB.Enabled = false;
            this.pwdAccountTB.Location = new System.Drawing.Point(252, 220);
            this.pwdAccountTB.Name = "pwdAccountTB";
            this.pwdAccountTB.Size = new System.Drawing.Size(200, 20);
            this.pwdAccountTB.TabIndex = 10;
            // 
            // pwdAccountLbl
            // 
            this.pwdAccountLbl.Location = new System.Drawing.Point(162, 218);
            this.pwdAccountLbl.Name = "pwdAccountLbl";
            this.pwdAccountLbl.Size = new System.Drawing.Size(84, 23);
            this.pwdAccountLbl.TabIndex = 9;
            this.pwdAccountLbl.Text = "Mot de passe :";
            this.pwdAccountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loginTB
            // 
            this.loginTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTB.Enabled = false;
            this.loginTB.Location = new System.Drawing.Point(252, 160);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(200, 20);
            this.loginTB.TabIndex = 8;
            // 
            // loginLbl
            // 
            this.loginLbl.Location = new System.Drawing.Point(162, 160);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(84, 23);
            this.loginLbl.TabIndex = 7;
            this.loginLbl.Text = "Login :";
            this.loginLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // urlTB
            // 
            this.urlTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTB.Enabled = false;
            this.urlTB.Location = new System.Drawing.Point(252, 100);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(200, 20);
            this.urlTB.TabIndex = 6;
            // 
            // urlLbl
            // 
            this.urlLbl.Location = new System.Drawing.Point(162, 102);
            this.urlLbl.Name = "urlLbl";
            this.urlLbl.Size = new System.Drawing.Size(84, 23);
            this.urlLbl.TabIndex = 5;
            this.urlLbl.Text = "URL :";
            this.urlLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTB
            // 
            this.nameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTB.Enabled = false;
            this.nameTB.Location = new System.Drawing.Point(252, 40);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(200, 20);
            this.nameTB.TabIndex = 4;
            // 
            // nameLbl
            // 
            this.nameLbl.Location = new System.Drawing.Point(162, 39);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(84, 23);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Nom :";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // oldPwdLB
            // 
            this.oldPwdLB.FormattingEnabled = true;
            this.oldPwdLB.Location = new System.Drawing.Point(3, 223);
            this.oldPwdLB.Name = "oldPwdLB";
            this.oldPwdLB.Size = new System.Drawing.Size(120, 95);
            this.oldPwdLB.TabIndex = 2;
            this.oldPwdLB.SelectedIndexChanged += new System.EventHandler(this.oldPwdLB_SelectedIndexChanged);
            // 
            // weakPwdLB
            // 
            this.weakPwdLB.FormattingEnabled = true;
            this.weakPwdLB.Location = new System.Drawing.Point(3, 118);
            this.weakPwdLB.Name = "weakPwdLB";
            this.weakPwdLB.Size = new System.Drawing.Size(120, 82);
            this.weakPwdLB.TabIndex = 1;
            this.weakPwdLB.SelectedIndexChanged += new System.EventHandler(this.weakPwdLB_SelectedIndexChanged);
            // 
            // pwdLB
            // 
            this.pwdLB.FormattingEnabled = true;
            this.pwdLB.Location = new System.Drawing.Point(3, 3);
            this.pwdLB.Name = "pwdLB";
            this.pwdLB.Size = new System.Drawing.Size(120, 95);
            this.pwdLB.TabIndex = 0;
            this.pwdLB.SelectedIndexChanged += new System.EventHandler(this.pwdLB_SelectedIndexChanged);
            // 
            // tabWifi
            // 
            this.tabWifi.Controls.Add(this.AddWifiBtn);
            this.tabWifi.Controls.Add(this.deleteWifiBtn);
            this.tabWifi.Controls.Add(this.updateWifiBtn);
            this.tabWifi.Controls.Add(this.pwdWifiTB);
            this.tabWifi.Controls.Add(this.pwdWifiLbl);
            this.tabWifi.Controls.Add(this.ssidTB);
            this.tabWifi.Controls.Add(this.ssidLbl);
            this.tabWifi.Controls.Add(this.wifiLB);
            this.tabWifi.Location = new System.Drawing.Point(4, 22);
            this.tabWifi.Name = "tabWifi";
            this.tabWifi.Padding = new System.Windows.Forms.Padding(3);
            this.tabWifi.Size = new System.Drawing.Size(505, 344);
            this.tabWifi.TabIndex = 1;
            this.tabWifi.Text = "Points d\'accès wifi";
            this.tabWifi.UseVisualStyleBackColor = true;
            // 
            // AddWifiBtn
            // 
            this.AddWifiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.AddWifiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWifiBtn.ForeColor = System.Drawing.Color.White;
            this.AddWifiBtn.Location = new System.Drawing.Point(3, 321);
            this.AddWifiBtn.Name = "AddWifiBtn";
            this.AddWifiBtn.Size = new System.Drawing.Size(145, 23);
            this.AddWifiBtn.TabIndex = 15;
            this.AddWifiBtn.Text = "+ Ajouter";
            this.AddWifiBtn.UseVisualStyleBackColor = false;
            this.AddWifiBtn.Click += new System.EventHandler(this.AddWifiBtn_Click);
            // 
            // deleteWifiBtn
            // 
            this.deleteWifiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.deleteWifiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteWifiBtn.ForeColor = System.Drawing.Color.White;
            this.deleteWifiBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteWifiBtn.Image")));
            this.deleteWifiBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteWifiBtn.Location = new System.Drawing.Point(380, 168);
            this.deleteWifiBtn.Name = "deleteWifiBtn";
            this.deleteWifiBtn.Size = new System.Drawing.Size(78, 23);
            this.deleteWifiBtn.TabIndex = 14;
            this.deleteWifiBtn.Text = "Supprimer";
            this.deleteWifiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteWifiBtn.UseVisualStyleBackColor = false;
            this.deleteWifiBtn.Click += new System.EventHandler(this.deleteWifiBtn_Click);
            // 
            // updateWifiBtn
            // 
            this.updateWifiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.updateWifiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateWifiBtn.ForeColor = System.Drawing.Color.White;
            this.updateWifiBtn.Image = ((System.Drawing.Image)(resources.GetObject("updateWifiBtn.Image")));
            this.updateWifiBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateWifiBtn.Location = new System.Drawing.Point(258, 168);
            this.updateWifiBtn.Name = "updateWifiBtn";
            this.updateWifiBtn.Size = new System.Drawing.Size(72, 23);
            this.updateWifiBtn.TabIndex = 13;
            this.updateWifiBtn.Text = "Modifier";
            this.updateWifiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateWifiBtn.UseVisualStyleBackColor = false;
            this.updateWifiBtn.Click += new System.EventHandler(this.updateWifiBtn_Click);
            // 
            // pwdWifiTB
            // 
            this.pwdWifiTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pwdWifiTB.Enabled = false;
            this.pwdWifiTB.Location = new System.Drawing.Point(258, 104);
            this.pwdWifiTB.Name = "pwdWifiTB";
            this.pwdWifiTB.Size = new System.Drawing.Size(200, 20);
            this.pwdWifiTB.TabIndex = 6;
            // 
            // pwdWifiLbl
            // 
            this.pwdWifiLbl.Location = new System.Drawing.Point(168, 102);
            this.pwdWifiLbl.Name = "pwdWifiLbl";
            this.pwdWifiLbl.Size = new System.Drawing.Size(84, 23);
            this.pwdWifiLbl.TabIndex = 5;
            this.pwdWifiLbl.Text = "Mot de passe :";
            this.pwdWifiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ssidTB
            // 
            this.ssidTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ssidTB.Enabled = false;
            this.ssidTB.Location = new System.Drawing.Point(258, 46);
            this.ssidTB.Name = "ssidTB";
            this.ssidTB.Size = new System.Drawing.Size(200, 20);
            this.ssidTB.TabIndex = 4;
            // 
            // ssidLbl
            // 
            this.ssidLbl.Location = new System.Drawing.Point(168, 44);
            this.ssidLbl.Name = "ssidLbl";
            this.ssidLbl.Size = new System.Drawing.Size(84, 23);
            this.ssidLbl.TabIndex = 3;
            this.ssidLbl.Text = "SSID :";
            this.ssidLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wifiLB
            // 
            this.wifiLB.FormattingEnabled = true;
            this.wifiLB.Location = new System.Drawing.Point(0, 1);
            this.wifiLB.Name = "wifiLB";
            this.wifiLB.Size = new System.Drawing.Size(148, 316);
            this.wifiLB.TabIndex = 0;
            this.wifiLB.SelectedIndexChanged += new System.EventHandler(this.wifiLB_SelectedIndexChanged);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.Location = new System.Drawing.Point(413, 12);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(93, 23);
            this.btnSignOut.TabIndex = 1;
            this.btnSignOut.Text = "Déconnexion";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 400);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.tabCtrlListes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Password1234";
            this.tabCtrlListes.ResumeLayout(false);
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            this.tabWifi.ResumeLayout(false);
            this.tabWifi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlListes;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.TabPage tabWifi;
        private System.Windows.Forms.ListBox oldPwdLB;
        private System.Windows.Forms.ListBox weakPwdLB;
        private System.Windows.Forms.ListBox pwdLB;
        private System.Windows.Forms.ListBox wifiLB;
        private System.Windows.Forms.TextBox urlTB;
        private System.Windows.Forms.Label urlLbl;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox pwdWifiTB;
        private System.Windows.Forms.Label pwdWifiLbl;
        private System.Windows.Forms.TextBox ssidTB;
        private System.Windows.Forms.Label ssidLbl;
        private System.Windows.Forms.TextBox pwdAccountTB;
        private System.Windows.Forms.Label pwdAccountLbl;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Button deleteAccountBtn;
        private System.Windows.Forms.Button updateAccountBtn;
        private System.Windows.Forms.Button deleteWifiBtn;
        private System.Windows.Forms.Button updateWifiBtn;
        private System.Windows.Forms.Button AddAccountBtn;
        private System.Windows.Forms.Button AddWifiBtn;
        private System.Windows.Forms.Label weakPwdLbl;
        private System.Windows.Forms.Label oldPwdLbl;
        private System.Windows.Forms.Button btnSignOut;
    }
}