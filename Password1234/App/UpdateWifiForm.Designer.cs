namespace App
{
    partial class UpdateWifiForm
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
            this.pwdWifiTB = new System.Windows.Forms.TextBox();
            this.pwdWifiLbl = new System.Windows.Forms.Label();
            this.ssidTB = new System.Windows.Forms.TextBox();
            this.ssidLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.lblPasswordStrength = new System.Windows.Forms.Label();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pwdWifiTB
            // 
            this.pwdWifiTB.Location = new System.Drawing.Point(95, 74);
            this.pwdWifiTB.Name = "pwdWifiTB";
            this.pwdWifiTB.Size = new System.Drawing.Size(180, 20);
            this.pwdWifiTB.TabIndex = 10;
            this.pwdWifiTB.TextChanged += new System.EventHandler(this.pwdWifiTB_TextChanged);
            // 
            // pwdWifiLbl
            // 
            this.pwdWifiLbl.Location = new System.Drawing.Point(5, 74);
            this.pwdWifiLbl.Name = "pwdWifiLbl";
            this.pwdWifiLbl.Size = new System.Drawing.Size(84, 23);
            this.pwdWifiLbl.TabIndex = 9;
            this.pwdWifiLbl.Text = "Mot de passe :";
            this.pwdWifiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ssidTB
            // 
            this.ssidTB.Location = new System.Drawing.Point(95, 34);
            this.ssidTB.Name = "ssidTB";
            this.ssidTB.Size = new System.Drawing.Size(180, 20);
            this.ssidTB.TabIndex = 8;
            // 
            // ssidLbl
            // 
            this.ssidLbl.Location = new System.Drawing.Point(5, 32);
            this.ssidLbl.Name = "ssidLbl";
            this.ssidLbl.Size = new System.Drawing.Size(84, 23);
            this.ssidLbl.TabIndex = 7;
            this.ssidLbl.Text = "SSID :";
            this.ssidLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(95, 145);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Annuler";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(192, 145);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(83, 23);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Sauvegarder";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // lblPasswordStrength
            // 
            this.lblPasswordStrength.AutoSize = true;
            this.lblPasswordStrength.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPasswordStrength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPasswordStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordStrength.ForeColor = System.Drawing.Color.White;
            this.lblPasswordStrength.Location = new System.Drawing.Point(281, 79);
            this.lblPasswordStrength.Name = "lblPasswordStrength";
            this.lblPasswordStrength.Size = new System.Drawing.Size(41, 15);
            this.lblPasswordStrength.TabIndex = 44;
            this.lblPasswordStrength.Text = "Force";
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(120, 100);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(155, 23);
            this.btnGeneratePassword.TabIndex = 45;
            this.btnGeneratePassword.Text = "Génerer mdp aléatoire";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click_1);
            // 
            // UpdateWifiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 189);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.lblPasswordStrength);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.pwdWifiTB);
            this.Controls.Add(this.pwdWifiLbl);
            this.Controls.Add(this.ssidTB);
            this.Controls.Add(this.ssidLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateWifiForm";
            this.Text = "Modifer un point d\'accès Wifi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwdWifiTB;
        private System.Windows.Forms.Label pwdWifiLbl;
        private System.Windows.Forms.TextBox ssidTB;
        private System.Windows.Forms.Label ssidLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label lblPasswordStrength;
        private System.Windows.Forms.Button btnGeneratePassword;
    }
}