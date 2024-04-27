
namespace LogReg
{
    partial class RegisterPanel
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordAgain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Tw Cen MT", 24F);
            this.loginLabel.Location = new System.Drawing.Point(29, 9);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(173, 37);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Regisztrálás";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.username.Location = new System.Drawing.Point(12, 76);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(190, 31);
            this.username.TabIndex = 1;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.password.Location = new System.Drawing.Point(12, 190);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(190, 31);
            this.password.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(111, 304);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 32);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Vissza";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(12, 304);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(93, 32);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Regisztrálás";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Felhasználónév";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Jelszó";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jelszó újra";
            // 
            // passwordAgain
            // 
            this.passwordAgain.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.passwordAgain.Location = new System.Drawing.Point(12, 248);
            this.passwordAgain.Name = "passwordAgain";
            this.passwordAgain.PasswordChar = '*';
            this.passwordAgain.Size = new System.Drawing.Size(190, 31);
            this.passwordAgain.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.email.Location = new System.Drawing.Point(12, 132);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(190, 31);
            this.email.TabIndex = 2;
            // 
            // RegisterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 341);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordAgain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.loginLabel);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterPanel";
            this.Text = "Regisztrációs Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterPanel_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordAgain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email;
    }
}

