namespace App
{
    partial class AddAccountForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbxUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.txtbxLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPasswordStrength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(247, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(104, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(104, 125);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(226, 20);
            this.txtbxPassword.TabIndex = 26;
            this.txtbxPassword.TextChanged += new System.EventHandler(this.txtbxPassword_TextChanged_1);
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(14, 123);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(84, 23);
            this.lblPassword.TabIndex = 25;
            this.lblPassword.Text = "Mot de passe :";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbxUrl
            // 
            this.txtbxUrl.Location = new System.Drawing.Point(104, 56);
            this.txtbxUrl.Name = "txtbxUrl";
            this.txtbxUrl.Size = new System.Drawing.Size(226, 20);
            this.txtbxUrl.TabIndex = 24;
            // 
            // lblUrl
            // 
            this.lblUrl.Location = new System.Drawing.Point(14, 54);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(84, 23);
            this.lblUrl.TabIndex = 23;
            this.lblUrl.Text = "URL :";
            this.lblUrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(104, 18);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(226, 20);
            this.txtbxName.TabIndex = 22;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(14, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 23);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Nom :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(175, 151);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(155, 23);
            this.btnGeneratePassword.TabIndex = 31;
            this.btnGeneratePassword.Text = "Génerer mdp aléatoire";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // txtbxLogin
            // 
            this.txtbxLogin.Location = new System.Drawing.Point(104, 90);
            this.txtbxLogin.Name = "txtbxLogin";
            this.txtbxLogin.Size = new System.Drawing.Size(226, 20);
            this.txtbxLogin.TabIndex = 33;
            // 
            // lblLogin
            // 
            this.lblLogin.Location = new System.Drawing.Point(12, 87);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(84, 23);
            this.lblLogin.TabIndex = 32;
            this.lblLogin.Text = "Login :";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPasswordStrength
            // 
            this.lblPasswordStrength.AutoSize = true;
            this.lblPasswordStrength.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPasswordStrength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPasswordStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordStrength.ForeColor = System.Drawing.Color.White;
            this.lblPasswordStrength.Location = new System.Drawing.Point(343, 128);
            this.lblPasswordStrength.Name = "lblPasswordStrength";
            this.lblPasswordStrength.Size = new System.Drawing.Size(41, 15);
            this.lblPasswordStrength.TabIndex = 34;
            this.lblPasswordStrength.Text = "Force";
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 232);
            this.Controls.Add(this.lblPasswordStrength);
            this.Controls.Add(this.txtbxLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtbxUrl);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddAccountForm";
            this.Text = "Ajout d\'un compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtbxUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.TextBox txtbxLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPasswordStrength;
    }
}