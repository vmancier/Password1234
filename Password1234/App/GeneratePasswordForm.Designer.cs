namespace App
{
    partial class GeneratePasswordForm
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
            this.lblNbChar = new System.Windows.Forms.Label();
            this.lblNbNum = new System.Windows.Forms.Label();
            this.lblNbSym = new System.Windows.Forms.Label();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.numUDNbChar = new System.Windows.Forms.NumericUpDown();
            this.numUDNbNum = new System.Windows.Forms.NumericUpDown();
            this.numUDNbSym = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNbChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNbNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNbSym)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNbChar
            // 
            this.lblNbChar.AutoSize = true;
            this.lblNbChar.Location = new System.Drawing.Point(12, 54);
            this.lblNbChar.Name = "lblNbChar";
            this.lblNbChar.Size = new System.Drawing.Size(135, 13);
            this.lblNbChar.TabIndex = 0;
            this.lblNbChar.Text = "Nombre total de caractères";
            // 
            // lblNbNum
            // 
            this.lblNbNum.AutoSize = true;
            this.lblNbNum.Location = new System.Drawing.Point(12, 88);
            this.lblNbNum.Name = "lblNbNum";
            this.lblNbNum.Size = new System.Drawing.Size(96, 13);
            this.lblNbNum.TabIndex = 1;
            this.lblNbNum.Text = "Nombre de chiffres";
            // 
            // lblNbSym
            // 
            this.lblNbSym.AutoSize = true;
            this.lblNbSym.Location = new System.Drawing.Point(12, 125);
            this.lblNbSym.Name = "lblNbSym";
            this.lblNbSym.Size = new System.Drawing.Size(105, 13);
            this.lblNbSym.TabIndex = 2;
            this.lblNbSym.Text = "Nombre de symboles";
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnGeneratePassword.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGeneratePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneratePassword.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePassword.Location = new System.Drawing.Point(107, 166);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(75, 23);
            this.btnGeneratePassword.TabIndex = 6;
            this.btnGeneratePassword.Text = "Valider";
            this.btnGeneratePassword.UseVisualStyleBackColor = false;
            // 
            // numUDNbChar
            // 
            this.numUDNbChar.Location = new System.Drawing.Point(172, 52);
            this.numUDNbChar.Name = "numUDNbChar";
            this.numUDNbChar.Size = new System.Drawing.Size(100, 20);
            this.numUDNbChar.TabIndex = 7;
            this.numUDNbChar.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numUDNbNum
            // 
            this.numUDNbNum.Location = new System.Drawing.Point(172, 88);
            this.numUDNbNum.Name = "numUDNbNum";
            this.numUDNbNum.Size = new System.Drawing.Size(100, 20);
            this.numUDNbNum.TabIndex = 8;
            this.numUDNbNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numUDNbSym
            // 
            this.numUDNbSym.Location = new System.Drawing.Point(172, 123);
            this.numUDNbSym.Name = "numUDNbSym";
            this.numUDNbSym.Size = new System.Drawing.Size(100, 20);
            this.numUDNbSym.TabIndex = 9;
            this.numUDNbSym.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // GeneratePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.numUDNbSym);
            this.Controls.Add(this.numUDNbNum);
            this.Controls.Add(this.numUDNbChar);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.lblNbSym);
            this.Controls.Add(this.lblNbNum);
            this.Controls.Add(this.lblNbChar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GeneratePasswordForm";
            this.Text = "Générateur de mot de passe";
            ((System.ComponentModel.ISupportInitialize)(this.numUDNbChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNbNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNbSym)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNbChar;
        private System.Windows.Forms.Label lblNbNum;
        private System.Windows.Forms.Label lblNbSym;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.NumericUpDown numUDNbChar;
        private System.Windows.Forms.NumericUpDown numUDNbNum;
        private System.Windows.Forms.NumericUpDown numUDNbSym;
    }
}