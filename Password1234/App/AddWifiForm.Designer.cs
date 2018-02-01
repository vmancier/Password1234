namespace App
{
    partial class AddWifiForm
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
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbxSsid = new System.Windows.Forms.TextBox();
            this.lblSsid = new System.Windows.Forms.Label();
            this.lblPasswordStrength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(200, 95);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(155, 23);
            this.btnGeneratePassword.TabIndex = 42;
            this.btnGeneratePassword.Text = "Génerer mdp aléatoire";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(272, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 23);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(132, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(132, 69);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(223, 20);
            this.txtbxPassword.TabIndex = 37;
            this.txtbxPassword.TextChanged += new System.EventHandler(this.txtbxPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(42, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(84, 23);
            this.lblPassword.TabIndex = 36;
            this.lblPassword.Text = "Mot de passe :";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbxSsid
            // 
            this.txtbxSsid.Location = new System.Drawing.Point(132, 29);
            this.txtbxSsid.Name = "txtbxSsid";
            this.txtbxSsid.Size = new System.Drawing.Size(223, 20);
            this.txtbxSsid.TabIndex = 33;
            // 
            // lblSsid
            // 
            this.lblSsid.Location = new System.Drawing.Point(42, 29);
            this.lblSsid.Name = "lblSsid";
            this.lblSsid.Size = new System.Drawing.Size(84, 23);
            this.lblSsid.TabIndex = 32;
            this.lblSsid.Text = "SSID :";
            this.lblSsid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPasswordStrength
            // 
            this.lblPasswordStrength.AutoSize = true;
            this.lblPasswordStrength.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPasswordStrength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPasswordStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordStrength.ForeColor = System.Drawing.Color.White;
            this.lblPasswordStrength.Location = new System.Drawing.Point(361, 72);
            this.lblPasswordStrength.Name = "lblPasswordStrength";
            this.lblPasswordStrength.Size = new System.Drawing.Size(41, 15);
            this.lblPasswordStrength.TabIndex = 43;
            this.lblPasswordStrength.Text = "Force";
            // 
            // AddWifiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 182);
            this.Controls.Add(this.lblPasswordStrength);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtbxSsid);
            this.Controls.Add(this.lblSsid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddWifiForm";
            this.Text = "Ajout d\'un point wifi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtbxSsid;
        private System.Windows.Forms.Label lblSsid;
        private System.Windows.Forms.Label lblPasswordStrength;
    }
}