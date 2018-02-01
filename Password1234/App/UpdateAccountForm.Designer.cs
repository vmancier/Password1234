namespace App
{
    partial class UpdateAccountForm
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
            this.pwdAccountTB = new System.Windows.Forms.TextBox();
            this.pwdAccountLbl = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.loginLbl = new System.Windows.Forms.Label();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.urlLbl = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.lblPasswordStrength = new System.Windows.Forms.Label();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pwdAccountTB
            // 
            this.pwdAccountTB.Location = new System.Drawing.Point(103, 180);
            this.pwdAccountTB.Name = "pwdAccountTB";
            this.pwdAccountTB.Size = new System.Drawing.Size(224, 20);
            this.pwdAccountTB.TabIndex = 18;
            this.pwdAccountTB.TextChanged += new System.EventHandler(this.pwdAccountTB_TextChanged);
            // 
            // pwdAccountLbl
            // 
            this.pwdAccountLbl.Location = new System.Drawing.Point(13, 177);
            this.pwdAccountLbl.Name = "pwdAccountLbl";
            this.pwdAccountLbl.Size = new System.Drawing.Size(84, 23);
            this.pwdAccountLbl.TabIndex = 17;
            this.pwdAccountLbl.Text = "Mot de passe :";
            this.pwdAccountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(103, 130);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(224, 20);
            this.loginTB.TabIndex = 16;
            // 
            // loginLbl
            // 
            this.loginLbl.Location = new System.Drawing.Point(12, 130);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(84, 23);
            this.loginLbl.TabIndex = 15;
            this.loginLbl.Text = "Login :";
            this.loginLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // urlTB
            // 
            this.urlTB.Location = new System.Drawing.Point(103, 80);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(224, 20);
            this.urlTB.TabIndex = 14;
            // 
            // urlLbl
            // 
            this.urlLbl.Location = new System.Drawing.Point(13, 77);
            this.urlLbl.Name = "urlLbl";
            this.urlLbl.Size = new System.Drawing.Size(84, 23);
            this.urlLbl.TabIndex = 13;
            this.urlLbl.Text = "URL :";
            this.urlLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(103, 30);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(224, 20);
            this.nameTB.TabIndex = 12;
            // 
            // nameLbl
            // 
            this.nameLbl.Location = new System.Drawing.Point(13, 28);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(84, 23);
            this.nameLbl.TabIndex = 11;
            this.nameLbl.Text = "Nom :";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(245, 260);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(83, 23);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Sauvegarder";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(103, 260);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 19;
            this.cancelBtn.Text = "Annuler";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // lblPasswordStrength
            // 
            this.lblPasswordStrength.AutoSize = true;
            this.lblPasswordStrength.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPasswordStrength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPasswordStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordStrength.ForeColor = System.Drawing.Color.White;
            this.lblPasswordStrength.Location = new System.Drawing.Point(334, 183);
            this.lblPasswordStrength.Name = "lblPasswordStrength";
            this.lblPasswordStrength.Size = new System.Drawing.Size(41, 15);
            this.lblPasswordStrength.TabIndex = 21;
            this.lblPasswordStrength.Text = "Force";
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(173, 206);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(155, 23);
            this.btnGeneratePassword.TabIndex = 22;
            this.btnGeneratePassword.Text = "Génerer mdp aléatoire";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // UpdateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 319);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.lblPasswordStrength);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.pwdAccountTB);
            this.Controls.Add(this.pwdAccountLbl);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.urlTB);
            this.Controls.Add(this.urlLbl);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.nameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateAccountForm";
            this.Text = "Modifier un compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwdAccountTB;
        private System.Windows.Forms.Label pwdAccountLbl;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.TextBox urlTB;
        private System.Windows.Forms.Label urlLbl;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label lblPasswordStrength;
        private System.Windows.Forms.Button btnGeneratePassword;
    }
}