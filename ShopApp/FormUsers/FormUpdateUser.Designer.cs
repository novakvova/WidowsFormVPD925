namespace ShopApp.FormUsers
{
    partial class FormUpdateUser
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
            this.newtxtCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.newbtnGetCode = new System.Windows.Forms.Button();
            this.newbntOk = new System.Windows.Forms.Button();
            this.newtxtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.newtxtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.newtxtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newbtnSelectUserImage = new System.Windows.Forms.Button();
            this.newuImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newtxtLN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newtxtFN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clbRoles = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.newuImage)).BeginInit();
            this.SuspendLayout();
            // 
            // newtxtCode
            // 
            this.newtxtCode.Location = new System.Drawing.Point(160, 511);
            this.newtxtCode.Name = "newtxtCode";
            this.newtxtCode.Size = new System.Drawing.Size(416, 20);
            this.newtxtCode.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(19, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Код";
            // 
            // newbtnGetCode
            // 
            this.newbtnGetCode.Location = new System.Drawing.Point(322, 430);
            this.newbtnGetCode.Name = "newbtnGetCode";
            this.newbtnGetCode.Size = new System.Drawing.Size(156, 49);
            this.newbtnGetCode.TabIndex = 35;
            this.newbtnGetCode.Text = "Отримати код перевірки пошти";
            this.newbtnGetCode.UseVisualStyleBackColor = true;
            this.newbtnGetCode.Click += new System.EventHandler(this.newbtnGetCode_Click);
            // 
            // newbntOk
            // 
            this.newbntOk.Location = new System.Drawing.Point(632, 80);
            this.newbntOk.Name = "newbntOk";
            this.newbntOk.Size = new System.Drawing.Size(156, 49);
            this.newbntOk.TabIndex = 34;
            this.newbntOk.Text = "Редагувати користувача";
            this.newbntOk.UseVisualStyleBackColor = true;
            this.newbntOk.Click += new System.EventHandler(this.newbntOk_Click);
            // 
            // newtxtPassword
            // 
            this.newtxtPassword.Location = new System.Drawing.Point(160, 386);
            this.newtxtPassword.Name = "newtxtPassword";
            this.newtxtPassword.Size = new System.Drawing.Size(416, 20);
            this.newtxtPassword.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(19, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Пароль";
            // 
            // newtxtEmail
            // 
            this.newtxtEmail.Location = new System.Drawing.Point(160, 347);
            this.newtxtEmail.Name = "newtxtEmail";
            this.newtxtEmail.Size = new System.Drawing.Size(416, 20);
            this.newtxtEmail.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(19, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Пошта";
            // 
            // newtxtPhone
            // 
            this.newtxtPhone.Location = new System.Drawing.Point(160, 307);
            this.newtxtPhone.Name = "newtxtPhone";
            this.newtxtPhone.Size = new System.Drawing.Size(416, 20);
            this.newtxtPhone.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(19, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Телефон";
            // 
            // newbtnSelectUserImage
            // 
            this.newbtnSelectUserImage.Location = new System.Drawing.Point(322, 172);
            this.newbtnSelectUserImage.Name = "newbtnSelectUserImage";
            this.newbtnSelectUserImage.Size = new System.Drawing.Size(156, 49);
            this.newbtnSelectUserImage.TabIndex = 27;
            this.newbtnSelectUserImage.Text = "Обрати фото";
            this.newbtnSelectUserImage.UseVisualStyleBackColor = true;
            this.newbtnSelectUserImage.Click += new System.EventHandler(this.newbtnSelectUserImage_Click);
            // 
            // newuImage
            // 
            this.newuImage.Location = new System.Drawing.Point(158, 159);
            this.newuImage.Name = "newuImage";
            this.newuImage.Size = new System.Drawing.Size(141, 122);
            this.newuImage.TabIndex = 26;
            this.newuImage.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(20, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Фото";
            // 
            // newtxtLN
            // 
            this.newtxtLN.Location = new System.Drawing.Point(160, 120);
            this.newtxtLN.Name = "newtxtLN";
            this.newtxtLN.Size = new System.Drawing.Size(416, 20);
            this.newtxtLN.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(19, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Прізвище";
            // 
            // newtxtFN
            // 
            this.newtxtFN.Location = new System.Drawing.Point(160, 80);
            this.newtxtFN.Name = "newtxtFN";
            this.newtxtFN.Size = new System.Drawing.Size(416, 20);
            this.newtxtFN.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ім\'я";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(246, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Редагування користувача";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(594, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "Ролі користувача";
            // 
            // clbRoles
            // 
            this.clbRoles.FormattingEnabled = true;
            this.clbRoles.Location = new System.Drawing.Point(604, 172);
            this.clbRoles.Name = "clbRoles";
            this.clbRoles.Size = new System.Drawing.Size(184, 214);
            this.clbRoles.TabIndex = 38;
            // 
            // FormUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 568);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.clbRoles);
            this.Controls.Add(this.newtxtCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.newbtnGetCode);
            this.Controls.Add(this.newbntOk);
            this.Controls.Add(this.newtxtPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.newtxtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newtxtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newbtnSelectUserImage);
            this.Controls.Add(this.newuImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newtxtLN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newtxtFN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateUser";
            this.Text = "FormUpdateUser";
            this.Load += new System.EventHandler(this.FormUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newuImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newtxtCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button newbtnGetCode;
        private System.Windows.Forms.Button newbntOk;
        private System.Windows.Forms.TextBox newtxtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox newtxtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newtxtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newbtnSelectUserImage;
        private System.Windows.Forms.PictureBox newuImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newtxtLN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newtxtFN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox clbRoles;
    }
}