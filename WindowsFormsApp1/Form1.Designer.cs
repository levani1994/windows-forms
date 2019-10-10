namespace WindowsFormsApp1
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
            this.Number1 = new System.Windows.Forms.Label();
            this.Number2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserLastName = new System.Windows.Forms.TextBox();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.UsersGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtBirthdate = new System.Windows.Forms.DateTimePicker();
            this.BtnUpdateUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Number1
            // 
            this.Number1.AutoSize = true;
            this.Number1.Location = new System.Drawing.Point(12, 40);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(49, 13);
            this.Number1.TabIndex = 0;
            this.Number1.Text = "სახელი";
            // 
            // Number2
            // 
            this.Number2.AutoSize = true;
            this.Number2.Location = new System.Drawing.Point(12, 72);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(39, 13);
            this.Number2.TabIndex = 1;
            this.Number2.Text = "გვარი";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(145, 37);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(137, 20);
            this.UserName.TabIndex = 7;
            // 
            // UserLastName
            // 
            this.UserLastName.Location = new System.Drawing.Point(145, 69);
            this.UserLastName.Name = "UserLastName";
            this.UserLastName.Size = new System.Drawing.Size(137, 20);
            this.UserLastName.TabIndex = 8;
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Location = new System.Drawing.Point(145, 143);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(137, 23);
            this.BtnAddUser.TabIndex = 10;
            this.BtnAddUser.Text = "შენახვა";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(91, 172);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(0, 13);
            this.LblResult.TabIndex = 3;
            // 
            // UsersGridView
            // 
            this.UsersGridView.AllowUserToAddRows = false;
            this.UsersGridView.AllowUserToDeleteRows = false;
            this.UsersGridView.AllowUserToOrderColumns = true;
            this.UsersGridView.AllowUserToResizeColumns = false;
            this.UsersGridView.AllowUserToResizeRows = false;
            this.UsersGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.UsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UsersGridView.Location = new System.Drawing.Point(0, 233);
            this.UsersGridView.MultiSelect = false;
            this.UsersGridView.Name = "UsersGridView";
            this.UsersGridView.ReadOnly = true;
            this.UsersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersGridView.Size = new System.Drawing.Size(602, 281);
            this.UsersGridView.TabIndex = 12;
            this.UsersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGridView_CellClick);
      
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "მომხმარებლის დამატება";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "დაბადების თარიღი";
            // 
            // DtBirthdate
            // 
            this.DtBirthdate.Location = new System.Drawing.Point(145, 102);
            this.DtBirthdate.Name = "DtBirthdate";
            this.DtBirthdate.Size = new System.Drawing.Size(137, 20);
            this.DtBirthdate.TabIndex = 16;
            this.DtBirthdate.UseWaitCursor = true;
            // 
            // BtnUpdateUser
            // 
            this.BtnUpdateUser.Location = new System.Drawing.Point(145, 185);
            this.BtnUpdateUser.Name = "BtnUpdateUser";
            this.BtnUpdateUser.Size = new System.Drawing.Size(137, 23);
            this.BtnUpdateUser.TabIndex = 17;
            this.BtnUpdateUser.Text = "განახლება";
            this.BtnUpdateUser.UseVisualStyleBackColor = true;
            this.BtnUpdateUser.Click += new System.EventHandler(this.BtnUpdateUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 514);
            this.Controls.Add(this.BtnUpdateUser);
            this.Controls.Add(this.DtBirthdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsersGridView);
            this.Controls.Add(this.BtnAddUser);
            this.Controls.Add(this.UserLastName);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Number1;
        private System.Windows.Forms.Label Number2;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserLastName;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.DataGridView UsersGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtBirthdate;
        private System.Windows.Forms.Button BtnUpdateUser;
    }
}

