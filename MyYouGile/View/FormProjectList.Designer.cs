namespace MyYouGile
{
    partial class FormProjectList
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProjectList));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelTemplateName = new System.Windows.Forms.Label();
            this.ButtonProjectListBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonToAddProject = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVProject = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelProjectDisplay = new System.Windows.Forms.Label();
            this.ButtonListClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonListCostSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonListCategory = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProject)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.39462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.79081F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelTemplateName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonProjectListBack, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 55);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MyYouGile.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(51, 50);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(51, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LabelTemplateName
            // 
            this.LabelTemplateName.AutoSize = true;
            this.LabelTemplateName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTemplateName.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTemplateName.ForeColor = System.Drawing.Color.White;
            this.LabelTemplateName.Location = new System.Drawing.Point(89, 0);
            this.LabelTemplateName.Name = "LabelTemplateName";
            this.LabelTemplateName.Size = new System.Drawing.Size(895, 55);
            this.LabelTemplateName.TabIndex = 1;
            this.LabelTemplateName.Text = "Проекты";
            this.LabelTemplateName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonProjectListBack
            // 
            this.ButtonProjectListBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonProjectListBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProjectListBack.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonProjectListBack.ForeColor = System.Drawing.Color.White;
            this.ButtonProjectListBack.Location = new System.Drawing.Point(990, 2);
            this.ButtonProjectListBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonProjectListBack.Name = "ButtonProjectListBack";
            this.ButtonProjectListBack.Size = new System.Drawing.Size(271, 51);
            this.ButtonProjectListBack.TabIndex = 2;
            this.ButtonProjectListBack.Text = "Назад";
            this.ButtonProjectListBack.UseVisualStyleBackColor = true;
            this.ButtonProjectListBack.Click += new System.EventHandler(this.ButtonProjectListBack_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.ButtonToAddProject, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 626);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1264, 55);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ButtonToAddProject
            // 
            this.ButtonToAddProject.AutoEllipsis = true;
            this.ButtonToAddProject.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonToAddProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonToAddProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonToAddProject.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ButtonToAddProject.ForeColor = System.Drawing.Color.White;
            this.ButtonToAddProject.Location = new System.Drawing.Point(425, 4);
            this.ButtonToAddProject.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonToAddProject.Name = "ButtonToAddProject";
            this.ButtonToAddProject.Size = new System.Drawing.Size(413, 47);
            this.ButtonToAddProject.TabIndex = 5;
            this.ButtonToAddProject.Text = "Добавить проект";
            this.ButtonToAddProject.UseVisualStyleBackColor = false;
            this.ButtonToAddProject.Click += new System.EventHandler(this.ButtonToAddProject_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.DGVProject, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.807356F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.19264F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1264, 571);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // DGVProject
            // 
            this.DGVProject.AllowUserToAddRows = false;
            this.DGVProject.AllowUserToDeleteRows = false;
            this.DGVProject.BackgroundColor = System.Drawing.Color.White;
            this.DGVProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProject.ColumnHeadersVisible = false;
            this.DGVProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DGVProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVProject.GridColor = System.Drawing.Color.DarkGray;
            this.DGVProject.Location = new System.Drawing.Point(4, 60);
            this.DGVProject.Margin = new System.Windows.Forms.Padding(4);
            this.DGVProject.Name = "DGVProject";
            this.DGVProject.ReadOnly = true;
            this.DGVProject.RowHeadersWidth = 51;
            this.DGVProject.Size = new System.Drawing.Size(1256, 507);
            this.DGVProject.TabIndex = 2;
            this.DGVProject.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProject_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.007949F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.974563F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.81876F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.57523F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.472178F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.66773F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.29889F));
            this.tableLayoutPanel4.Controls.Add(this.LabelProjectDisplay, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.ButtonListClient, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ButtonListCostSort, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.TextBoxSearch, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.ButtonListCategory, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1258, 52);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // LabelProjectDisplay
            // 
            this.LabelProjectDisplay.AutoSize = true;
            this.LabelProjectDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelProjectDisplay.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.LabelProjectDisplay.Location = new System.Drawing.Point(903, 0);
            this.LabelProjectDisplay.Name = "LabelProjectDisplay";
            this.LabelProjectDisplay.Size = new System.Drawing.Size(352, 52);
            this.LabelProjectDisplay.TabIndex = 6;
            this.LabelProjectDisplay.Text = "Найдено";
            // 
            // ButtonListClient
            // 
            this.ButtonListClient.AutoEllipsis = true;
            this.ButtonListClient.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonListClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonListClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonListClient.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ButtonListClient.ForeColor = System.Drawing.Color.White;
            this.ButtonListClient.Location = new System.Drawing.Point(316, 4);
            this.ButtonListClient.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonListClient.Name = "ButtonListClient";
            this.ButtonListClient.Size = new System.Drawing.Size(226, 44);
            this.ButtonListClient.TabIndex = 5;
            this.ButtonListClient.Text = "Заказчик";
            this.ButtonListClient.UseVisualStyleBackColor = false;
            this.ButtonListClient.Click += new System.EventHandler(this.ButtonListClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цена";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonListCostSort
            // 
            this.ButtonListCostSort.AutoEllipsis = true;
            this.ButtonListCostSort.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonListCostSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonListCostSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonListCostSort.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ButtonListCostSort.ForeColor = System.Drawing.Color.White;
            this.ButtonListCostSort.Location = new System.Drawing.Point(66, 2);
            this.ButtonListCostSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonListCostSort.Name = "ButtonListCostSort";
            this.ButtonListCostSort.Size = new System.Drawing.Size(44, 48);
            this.ButtonListCostSort.TabIndex = 1;
            this.ButtonListCostSort.Text = "↑";
            this.ButtonListCostSort.UseVisualStyleBackColor = false;
            this.ButtonListCostSort.Click += new System.EventHandler(this.ButtonListCostSort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.label2.Location = new System.Drawing.Point(549, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поиск";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxSearch.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.TextBoxSearch.Location = new System.Drawing.Point(644, 4);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(252, 27);
            this.TextBoxSearch.TabIndex = 3;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // ButtonListCategory
            // 
            this.ButtonListCategory.AutoEllipsis = true;
            this.ButtonListCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonListCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonListCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonListCategory.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ButtonListCategory.ForeColor = System.Drawing.Color.White;
            this.ButtonListCategory.Location = new System.Drawing.Point(117, 4);
            this.ButtonListCategory.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonListCategory.Name = "ButtonListCategory";
            this.ButtonListCategory.Size = new System.Drawing.Size(191, 44);
            this.ButtonListCategory.TabIndex = 4;
            this.ButtonListCategory.Text = "Категория";
            this.ButtonListCategory.UseVisualStyleBackColor = false;
            this.ButtonListCategory.Click += new System.EventHandler(this.ButtonListCategory_Click);
            // 
            // FormProjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1279, 718);
            this.Name = "FormProjectList";
            this.Text = "Список проектов";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProject)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelTemplateName;
        private System.Windows.Forms.Button ButtonProjectListBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button ButtonListClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonListCostSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonListCategory;
        private System.Windows.Forms.DataGridView DGVProject;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label LabelProjectDisplay;
        public System.Windows.Forms.Button ButtonToAddProject;
    }
}

