namespace LogReg_Minimum
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.felhasznalonev = new System.Windows.Forms.TextBox();
            this.jelszo = new System.Windows.Forms.TextBox();
            this.belepesGomb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelszó";
            // 
            // felhasznalonev
            // 
            this.felhasznalonev.Location = new System.Drawing.Point(3, 16);
            this.felhasznalonev.Name = "felhasznalonev";
            this.felhasznalonev.Size = new System.Drawing.Size(135, 20);
            this.felhasznalonev.TabIndex = 0;
            // 
            // jelszo
            // 
            this.jelszo.Location = new System.Drawing.Point(3, 67);
            this.jelszo.Name = "jelszo";
            this.jelszo.Size = new System.Drawing.Size(135, 20);
            this.jelszo.TabIndex = 1;
            // 
            // belepesGomb
            // 
            this.belepesGomb.Location = new System.Drawing.Point(3, 93);
            this.belepesGomb.Name = "belepesGomb";
            this.belepesGomb.Size = new System.Drawing.Size(53, 23);
            this.belepesGomb.TabIndex = 2;
            this.belepesGomb.Text = "belépés";
            this.belepesGomb.UseVisualStyleBackColor = true;
            this.belepesGomb.Click += new System.EventHandler(this.belepesGomb_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "regisztrálás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 125);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.belepesGomb);
            this.Controls.Add(this.jelszo);
            this.Controls.Add(this.felhasznalonev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox felhasznalonev;
        private System.Windows.Forms.TextBox jelszo;
        private System.Windows.Forms.Button belepesGomb;
        private System.Windows.Forms.Button button1;
    }
}

