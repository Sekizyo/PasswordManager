namespace PasswordManager
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
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
            this.labelDataView = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.labelNewPasswdName = new System.Windows.Forms.Label();
            this.textBoxNewPasswd = new System.Windows.Forms.TextBox();
            this.labelAddNewPasswd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDataView
            // 
            this.labelDataView.AutoSize = true;
            this.labelDataView.Location = new System.Drawing.Point(37, 80);
            this.labelDataView.Name = "labelDataView";
            this.labelDataView.Size = new System.Drawing.Size(107, 16);
            this.labelDataView.TabIndex = 1;
            this.labelDataView.Text = "Your passwords:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(887, 302);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(339, 36);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(40, 36);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(132, 22);
            this.textBoxNewName.TabIndex = 4;
            // 
            // labelNewPasswdName
            // 
            this.labelNewPasswdName.AutoSize = true;
            this.labelNewPasswdName.Location = new System.Drawing.Point(37, 17);
            this.labelNewPasswdName.Name = "labelNewPasswdName";
            this.labelNewPasswdName.Size = new System.Drawing.Size(44, 16);
            this.labelNewPasswdName.TabIndex = 5;
            this.labelNewPasswdName.Text = "Name";
            // 
            // textBoxNewPasswd
            // 
            this.textBoxNewPasswd.Location = new System.Drawing.Point(202, 36);
            this.textBoxNewPasswd.Name = "textBoxNewPasswd";
            this.textBoxNewPasswd.Size = new System.Drawing.Size(131, 22);
            this.textBoxNewPasswd.TabIndex = 6;
            // 
            // labelAddNewPasswd
            // 
            this.labelAddNewPasswd.AutoSize = true;
            this.labelAddNewPasswd.Location = new System.Drawing.Point(199, 17);
            this.labelAddNewPasswd.Name = "labelAddNewPasswd";
            this.labelAddNewPasswd.Size = new System.Drawing.Size(67, 16);
            this.labelAddNewPasswd.TabIndex = 7;
            this.labelAddNewPasswd.Text = "Password";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelAddNewPasswd);
            this.Controls.Add(this.textBoxNewPasswd);
            this.Controls.Add(this.labelNewPasswdName);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelDataView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDataView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label labelNewPasswdName;
        private System.Windows.Forms.TextBox textBoxNewPasswd;
        private System.Windows.Forms.Label labelAddNewPasswd;
    }
}