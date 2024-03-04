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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.labelNewPasswdName = new System.Windows.Forms.Label();
            this.textBoxNewPasswd = new System.Windows.Forms.TextBox();
            this.labelAddNewPasswd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
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
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Password,
            this.Edit,
            this.Delete});
            this.dataGrid.Location = new System.Drawing.Point(40, 99);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(1015, 348);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 125;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 125;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
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
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.labelDataView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDataView;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label labelNewPasswdName;
        private System.Windows.Forms.TextBox textBoxNewPasswd;
        private System.Windows.Forms.Label labelAddNewPasswd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}