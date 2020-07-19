﻿namespace ShopApp.FormUsers
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(17, 25);
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
            this.dgvUsers.Location = new System.Drawing.Point(21, 52);
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
            this.btnDelUser.Location = new System.Drawing.Point(904, 230);
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
            this.btnUpdateUser.Location = new System.Drawing.Point(904, 167);
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
            this.btnCreateUser.Location = new System.Drawing.Point(904, 52);
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
            this.btnMainAuth.Location = new System.Drawing.Point(904, 104);
            this.btnMainAuth.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainAuth.Name = "btnMainAuth";
            this.btnMainAuth.Size = new System.Drawing.Size(161, 44);
            this.btnMainAuth.TabIndex = 18;
            this.btnMainAuth.Text = "Авторизуватися";
            this.btnMainAuth.UseVisualStyleBackColor = true;
            this.btnMainAuth.Click += new System.EventHandler(this.btnMainAuth_Click);
            // 
            // ListUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 315);
            this.Controls.Add(this.btnMainAuth);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvUsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
    }
}
