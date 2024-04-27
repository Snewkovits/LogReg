namespace LogReg
{
    partial class UserList
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
            this.UserListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UserListBox
            // 
            this.UserListBox.FormattingEnabled = true;
            this.UserListBox.ItemHeight = 19;
            this.UserListBox.Location = new System.Drawing.Point(16, 18);
            this.UserListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.Size = new System.Drawing.Size(351, 612);
            this.UserListBox.TabIndex = 0;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 658);
            this.Controls.Add(this.UserListBox);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserList";
            this.Text = "Felhasználó lista";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserList_FormClosed);
            this.Load += new System.EventHandler(this.UserList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UserListBox;
    }
}