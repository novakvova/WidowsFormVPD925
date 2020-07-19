namespace ShopApp.FormUsers
{
    partial class ListUsersForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserFN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataLL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnMainAuth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFindLastName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(12, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Користувачі";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserFN,
            this.UserLN,
            this.UserImage,
            this.UserPhone,
            this.DataReg,
            this.DataLL,
            this.UserEmail});
            this.dgvUsers.Location = new System.Drawing.Point(16, 148);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowTemplate.Height = 80;
            this.dgvUsers.Size = new System.Drawing.Size(866, 233);
            this.dgvUsers.TabIndex = 13;
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // UserFN
            // 
            this.UserFN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserFN.HeaderText = "UserFN";
            this.UserFN.Name = "UserFN";
            this.UserFN.ReadOnly = true;
            // 
            // UserLN
            // 
            this.UserLN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserLN.HeaderText = "UserLN";
            this.UserLN.Name = "UserLN";
            this.UserLN.ReadOnly = true;
            // 
            // UserImage
            // 
            this.UserImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserImage.HeaderText = "UserImage";
            this.UserImage.Name = "UserImage";
            this.UserImage.ReadOnly = true;
            // 
            // UserPhone
            // 
            this.UserPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserPhone.HeaderText = "UserPhone";
            this.UserPhone.Name = "UserPhone";
            this.UserPhone.ReadOnly = true;
            // 
            // DataReg
            // 
            this.DataReg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataReg.HeaderText = "DataReg";
            this.DataReg.Name = "DataReg";
            this.DataReg.ReadOnly = true;
            // 
            // DataLL
            // 
            this.DataLL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataLL.HeaderText = "DataLL";
            this.DataLL.Name = "DataLL";
            this.DataLL.ReadOnly = true;
            // 
            // UserEmail
            // 
            this.UserEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserEmail.HeaderText = "UserEmail";
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.ReadOnly = true;
            // 
            // btnDelUser
            // 
            this.btnDelUser.Location = new System.Drawing.Point(899, 326);
            this.btnDelUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(161, 44);
            this.btnDelUser.TabIndex = 17;
            this.btnDelUser.Text = "Видалити користувача";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(899, 263);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(161, 44);
            this.btnUpdateUser.TabIndex = 16;
            this.btnUpdateUser.Text = "Редагувати користувача";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(899, 148);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(161, 44);
            this.btnCreateUser.TabIndex = 15;
            this.btnCreateUser.Text = "Зареєструватися";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnMainAuth
            // 
            this.btnMainAuth.Location = new System.Drawing.Point(899, 200);
            this.btnMainAuth.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainAuth.Name = "btnMainAuth";
            this.btnMainAuth.Size = new System.Drawing.Size(161, 44);
            this.btnMainAuth.TabIndex = 18;
            this.btnMainAuth.Text = "Авторизуватися";
            this.btnMainAuth.UseVisualStyleBackColor = true;
            this.btnMainAuth.Click += new System.EventHandler(this.btnMainAuth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Прізвище";
            // 
            // txtFindLastName
            // 
            this.txtFindLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFindLastName.Location = new System.Drawing.Point(30, 44);
            this.txtFindLastName.Name = "txtFindLastName";
            this.txtFindLastName.Size = new System.Drawing.Size(290, 26);
            this.txtFindLastName.TabIndex = 20;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(908, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 39);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(346, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ім\'я";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirstName.Location = new System.Drawing.Point(350, 44);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(290, 26);
            this.txtFirstName.TabIndex = 20;
            // 
            // ListUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 404);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFindLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMainAuth);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvUsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Магазин одягу \"Шорти\"";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFN;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLN;
        private System.Windows.Forms.DataGridViewImageColumn UserImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataLL;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserEmail;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnMainAuth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFindLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
    }
}

