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
            this.LblAddUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtBirthdate = new System.Windows.Forms.DateTimePicker();
            this.BtnUpdateUser = new System.Windows.Forms.Button();
            this.GroupsList = new System.Windows.Forms.ComboBox();
            this.BtnAddGroup = new System.Windows.Forms.Button();
            this.Group = new System.Windows.Forms.TextBox();
            this.LblAddGRoup = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
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
            this.BtnAddUser.Location = new System.Drawing.Point(145, 185);
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
            this.UsersGridView.Location = new System.Drawing.Point(0, 266);
            this.UsersGridView.MultiSelect = false;
            this.UsersGridView.Name = "UsersGridView";
            this.UsersGridView.ReadOnly = true;
            this.UsersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersGridView.Size = new System.Drawing.Size(602, 248);
            this.UsersGridView.TabIndex = 12;
            this.UsersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGridView_CellClick);
            // 
            // LblAddUser
            // 
            this.LblAddUser.AutoSize = true;
            this.LblAddUser.Location = new System.Drawing.Point(142, 9);
            this.LblAddUser.Name = "LblAddUser";
            this.LblAddUser.Size = new System.Drawing.Size(146, 13);
            this.LblAddUser.TabIndex = 13;
            this.LblAddUser.Text = "მომხმარებლის დამატება";
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
            this.BtnUpdateUser.Location = new System.Drawing.Point(145, 226);
            this.BtnUpdateUser.Name = "BtnUpdateUser";
            this.BtnUpdateUser.Size = new System.Drawing.Size(137, 23);
            this.BtnUpdateUser.TabIndex = 17;
            this.BtnUpdateUser.Text = "განახლება";
            this.BtnUpdateUser.UseVisualStyleBackColor = true;
            this.BtnUpdateUser.Click += new System.EventHandler(this.BtnUpdateUser_Click);
            // 
            // GroupsList
            // 
            this.GroupsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupsList.FormattingEnabled = true;
            this.GroupsList.Location = new System.Drawing.Point(145, 145);
            this.GroupsList.Name = "GroupsList";
            this.GroupsList.Size = new System.Drawing.Size(137, 21);
            this.GroupsList.TabIndex = 18;
            // 
            // BtnAddGroup
            // 
            this.BtnAddGroup.Location = new System.Drawing.Point(346, 72);
            this.BtnAddGroup.Name = "BtnAddGroup";
            this.BtnAddGroup.Size = new System.Drawing.Size(105, 23);
            this.BtnAddGroup.TabIndex = 22;
            this.BtnAddGroup.Text = "შენახვა";
            this.BtnAddGroup.UseVisualStyleBackColor = true;
            this.BtnAddGroup.Click += new System.EventHandler(this.BtnAddGroup_Click);
            // 
            // Group
            // 
            this.Group.Location = new System.Drawing.Point(346, 37);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(105, 20);
            this.Group.TabIndex = 23;
            // 
            // LblAddGRoup
            // 
            this.LblAddGRoup.AutoSize = true;
            this.LblAddGRoup.Location = new System.Drawing.Point(343, 9);
            this.LblAddGRoup.Name = "LblAddGRoup";
            this.LblAddGRoup.Size = new System.Drawing.Size(108, 13);
            this.LblAddGRoup.TabIndex = 24;
            this.LblAddGRoup.Text = "ჯგუფის დამატება";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(12, 148);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(45, 13);
            this.lblGroup.TabIndex = 25;
            this.lblGroup.Text = "ჯგუფი";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 514);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.LblAddGRoup);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.BtnAddGroup);
            this.Controls.Add(this.GroupsList);
            this.Controls.Add(this.BtnUpdateUser);
            this.Controls.Add(this.DtBirthdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblAddUser);
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
        private System.Windows.Forms.Label LblAddUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtBirthdate;
        private System.Windows.Forms.Button BtnUpdateUser;
        private System.Windows.Forms.ComboBox GroupsList;
      
       
        
        private System.Windows.Forms.Button BtnAddGroup;
        private System.Windows.Forms.TextBox Group;
        private System.Windows.Forms.Label LblAddGRoup;
        private System.Windows.Forms.Label lblGroup;
    }
}

