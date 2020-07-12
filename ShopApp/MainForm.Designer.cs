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
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColDescript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(875, 356);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(161, 44);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Додати категорію";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColImage,
            this.ColDescript});
            this.dgvCategories.Location = new System.Drawing.Point(66, 47);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowTemplate.Height = 80;
            this.dgvCategories.Size = new System.Drawing.Size(771, 294);
            this.dgvCategories.TabIndex = 1;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "ColId";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.HeaderText = "Назва";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColImage
            // 
            this.ColImage.HeaderText = "Фото";
            this.ColImage.Name = "ColImage";
            this.ColImage.ReadOnly = true;
            // 
            // ColDescript
            // 
            this.ColDescript.HeaderText = "Опис";
            this.ColDescript.Name = "ColDescript";
            this.ColDescript.ReadOnly = true;
            this.ColDescript.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDescript.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColDescript.Width = 250;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(875, 47);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(161, 69);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Редагувати категорію";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(875, 141);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 44);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 466);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddCategory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин одягу \"Шорти\"";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewImageColumn ColImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescript;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}

