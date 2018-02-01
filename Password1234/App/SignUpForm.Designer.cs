namespace App
{
    partial class SignUpForm
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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbxLogin = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordStrength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnSignUp.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(141, 173);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "S\'inscrire";
            this.btnSignUp.UseVisualStyleBackColor = false;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(61, 136);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(155, 23);
            this.btnGeneratePassword.TabIndex = 1;
            this.btnGeneratePassword.Text = "Génerer mdp aléatoire";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(58, 43);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(58, 90);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Mot de passe :";
            // 
            // txtbxLogin
            // 
            this.txtbxLogin.Location = new System.Drawing.Point(61, 59);
            this.txtbxLogin.Name = "txtbxLogin";
            this.txtbxLogin.Size = new System.Drawing.Size(155, 20);
            this.txtbxLogin.TabIndex = 4;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.HideSelection = false;
            this.txtbxPassword.Location = new System.Drawing.Point(61, 107);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(155, 20);
            this.txtbxPassword.TabIndex = 5;
            this.txtbxPassword.TextChanged += new System.EventHandler(this.txtbxPassword_TextChanged);
            // 
            // lblPasswordStrength
            // 
            this.lblPasswordStrength.AutoSize = true;
            this.lblPasswordStrength.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPasswordStrength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPasswordStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordStrength.ForeColor = System.Drawing.Color.White;
            this.lblPasswordStrength.Location = new System.Drawing.Point(222, 110);
            this.lblPasswordStrength.Name = "lblPasswordStrength";
            this.lblPasswordStrength.Size = new System.Drawing.Size(41, 15);
            this.lblPasswordStrength.TabIndex = 6;
            this.lblPasswordStrength.Text = "Force";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 240);
            this.Controls.Add(this.lblPasswordStrength);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.txtbxLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.btnSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SignUpForm";
            this.Text = "Inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtbxLogin;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.Label lblPasswordStrength;
    }
}