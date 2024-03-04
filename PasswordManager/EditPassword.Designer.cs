namespace PasswordManager
{
    partial class EditPassword
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelPasswd = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPasswd = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(119, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Edit name";
            // 
            // labelPasswd
            // 
            this.labelPasswd.AutoSize = true;
            this.labelPasswd.Location = new System.Drawing.Point(119, 106);
            this.labelPasswd.Name = "labelPasswd";
            this.labelPasswd.Size = new System.Drawing.Size(93, 16);
            this.labelPasswd.TabIndex = 1;
            this.labelPasswd.Text = "Edit Password";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(122, 47);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxPasswd
            // 
            this.textBoxPasswd.Location = new System.Drawing.Point(122, 125);
            this.textBoxPasswd.Name = "textBoxPasswd";
            this.textBoxPasswd.Size = new System.Drawing.Size(150, 22);
            this.textBoxPasswd.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(153, 180);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // EditPassword
            // 
            this.AcceptButton = this.btnSubmit;
            this.ClientSize = new System.Drawing.Size(372, 311);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBoxPasswd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPasswd);
            this.Controls.Add(this.labelName);
            this.Name = "EditPassword";
            this.Load += new System.EventHandler(this.EditPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPasswd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPasswd;
        private System.Windows.Forms.Button btnSubmit;
    }
}