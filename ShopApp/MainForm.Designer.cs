namespace ShopApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.headMenu = new System.Windows.Forms.MenuStrip();
            this.headMenu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.headMenu_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.headMenu_data = new System.Windows.Forms.ToolStripMenuItem();
            this.headMenu_data_users = new System.Windows.Forms.ToolStripMenuItem();
            this.headMenu_data_categories = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.headMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // headMenu
            // 
            this.headMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headMenu_file,
            this.headMenu_data});
            this.headMenu.Location = new System.Drawing.Point(0, 0);
            this.headMenu.Name = "headMenu";
            this.headMenu.Size = new System.Drawing.Size(800, 24);
            this.headMenu.TabIndex = 1;
            this.headMenu.Text = "menuStrip2";
            // 
            // headMenu_file
            // 
            this.headMenu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headMenu_file_exit});
            this.headMenu_file.Name = "headMenu_file";
            this.headMenu_file.Size = new System.Drawing.Size(48, 20);
            this.headMenu_file.Text = "Файл";
            // 
            // headMenu_file_exit
            // 
            this.headMenu_file_exit.Name = "headMenu_file_exit";
            this.headMenu_file_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.headMenu_file_exit.Size = new System.Drawing.Size(180, 22);
            this.headMenu_file_exit.Text = "Вихід";
            this.headMenu_file_exit.Click += new System.EventHandler(this.headMenu_file_exit_Click);
            // 
            // headMenu_data
            // 
            this.headMenu_data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headMenu_data_users,
            this.headMenu_data_categories});
            this.headMenu_data.Name = "headMenu_data";
            this.headMenu_data.Size = new System.Drawing.Size(43, 20);
            this.headMenu_data.Text = "Дані";
            // 
            // headMenu_data_users
            // 
            this.headMenu_data_users.Name = "headMenu_data_users";
            this.headMenu_data_users.Size = new System.Drawing.Size(180, 22);
            this.headMenu_data_users.Text = "Користувачі";
            this.headMenu_data_users.Click += new System.EventHandler(this.headMenu_data_users_Click);
            // 
            // headMenu_data_categories
            // 
            this.headMenu_data_categories.Name = "headMenu_data_categories";
            this.headMenu_data_categories.Size = new System.Drawing.Size(180, 22);
            this.headMenu_data_categories.Text = "Категорії";
            this.headMenu_data_categories.Click += new System.EventHandler(this.headMenu_data_categories_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.headMenu);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.headMenu.ResumeLayout(false);
            this.headMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip headMenu;
        private System.Windows.Forms.ToolStripMenuItem headMenu_file;
        private System.Windows.Forms.ToolStripMenuItem headMenu_file_exit;
        private System.Windows.Forms.ToolStripMenuItem headMenu_data;
        private System.Windows.Forms.ToolStripMenuItem headMenu_data_users;
        private System.Windows.Forms.ToolStripMenuItem headMenu_data_categories;
    }
}