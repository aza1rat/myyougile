namespace MyYouGile
{
    partial class FormChangeProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeProject));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelTemplateName = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonAddManager = new System.Windows.Forms.Button();
            this.ButtonProjectDelete = new System.Windows.Forms.Button();
            this.ButtonProjectUpdate = new System.Windows.Forms.Button();
            this.ButtonProjectAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxProjectName = new System.Windows.Forms.TextBox();
            this.TextBoxProjectID = new System.Windows.Forms.TextBox();
            this.LabelProjectID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RichTextBoxProjectDescription = new System.Windows.Forms.RichTextBox();
            this.TextBoxProjectPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonAddCategory = new System.Windows.Forms.Button();
            this.ComboBoxProjectCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonChangeImage = new System.Windows.Forms.Button();
            this.ButtonDefaultImage = new System.Windows.Forms.Button();
            this.PictureBoxProjectImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProjectImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.125F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelTemplateName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonExit, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(827, 55);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MyYouGile.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(50, 50);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(50, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
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
            this.LabelTemplateName.Location = new System.Drawing.Point(59, 0);
            this.LabelTemplateName.Name = "LabelTemplateName";
            this.LabelTemplateName.Size = new System.Drawing.Size(523, 55);
            this.LabelTemplateName.TabIndex = 1;
            this.LabelTemplateName.Text = "Редактирование проекта";
            this.LabelTemplateName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.Location = new System.Drawing.Point(588, 3);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(236, 49);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "Выйти";
            this.ButtonExit.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.25272F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.25272F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.ButtonAddManager, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonProjectDelete, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonProjectUpdate, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 647);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(827, 55);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ButtonAddManager
            // 
            this.ButtonAddManager.AutoEllipsis = true;
            this.ButtonAddManager.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonAddManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAddManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAddManager.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ButtonAddManager.ForeColor = System.Drawing.Color.White;
            this.ButtonAddManager.Location = new System.Drawing.Point(4, 4);
            this.ButtonAddManager.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAddManager.Name = "ButtonAddManager";
            this.ButtonAddManager.Size = new System.Drawing.Size(267, 47);
            this.ButtonAddManager.TabIndex = 9;
            this.ButtonAddManager.Text = "Добавить менеджера";
            this.ButtonAddManager.UseVisualStyleBackColor = false;
            this.ButtonAddManager.Click += new System.EventHandler(this.ButtonAddManager_Click);
            // 
            // ButtonProjectDelete
            // 
            this.ButtonProjectDelete.AutoEllipsis = true;
            this.ButtonProjectDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonProjectDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonProjectDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonProjectDelete.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ButtonProjectDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonProjectDelete.Location = new System.Drawing.Point(554, 4);
            this.ButtonProjectDelete.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonProjectDelete.Name = "ButtonProjectDelete";
            this.ButtonProjectDelete.Size = new System.Drawing.Size(269, 47);
            this.ButtonProjectDelete.TabIndex = 8;
            this.ButtonProjectDelete.Text = "Удалить";
            this.ButtonProjectDelete.UseVisualStyleBackColor = false;
            this.ButtonProjectDelete.Click += new System.EventHandler(this.ButtonProjectDelete_Click);
            // 
            // ButtonProjectUpdate
            // 
            this.ButtonProjectUpdate.AutoEllipsis = true;
            this.ButtonProjectUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonProjectUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonProjectUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonProjectUpdate.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ButtonProjectUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtonProjectUpdate.Location = new System.Drawing.Point(279, 4);
            this.ButtonProjectUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonProjectUpdate.Name = "ButtonProjectUpdate";
            this.ButtonProjectUpdate.Size = new System.Drawing.Size(267, 47);
            this.ButtonProjectUpdate.TabIndex = 7;
            this.ButtonProjectUpdate.Text = "Изменить";
            this.ButtonProjectUpdate.UseVisualStyleBackColor = false;
            this.ButtonProjectUpdate.Click += new System.EventHandler(this.ButtonProjectUpdate_Click);
            // 
            // ButtonProjectAdd
            // 
            this.ButtonProjectAdd.AutoEllipsis = true;
            this.ButtonProjectAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel4.SetColumnSpan(this.ButtonProjectAdd, 3);
            this.ButtonProjectAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonProjectAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonProjectAdd.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ButtonProjectAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonProjectAdd.Location = new System.Drawing.Point(4, 542);
            this.ButtonProjectAdd.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonProjectAdd.Name = "ButtonProjectAdd";
            this.ButtonProjectAdd.Size = new System.Drawing.Size(819, 46);
            this.ButtonProjectAdd.TabIndex = 6;
            this.ButtonProjectAdd.Text = "Добавить";
            this.ButtonProjectAdd.UseVisualStyleBackColor = false;
            this.ButtonProjectAdd.Click += new System.EventHandler(this.ButtonProjectAdd_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.44861F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.61548F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.05683F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.ButtonProjectAdd, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.TextBoxProjectName, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.TextBoxProjectID, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.LabelProjectID, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.RichTextBoxProjectDescription, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.TextBoxProjectPrice, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.213223F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.04446F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.3355F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.829268F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.69106F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(827, 592);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.label5.Location = new System.Drawing.Point(506, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 49);
            this.label5.TabIndex = 13;
            this.label5.Text = "Описание";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxProjectName
            // 
            this.TextBoxProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxProjectName.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.TextBoxProjectName.Location = new System.Drawing.Point(230, 53);
            this.TextBoxProjectName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxProjectName.MaxLength = 150;
            this.TextBoxProjectName.Multiline = true;
            this.TextBoxProjectName.Name = "TextBoxProjectName";
            this.TextBoxProjectName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxProjectName.Size = new System.Drawing.Size(269, 84);
            this.TextBoxProjectName.TabIndex = 7;
            // 
            // TextBoxProjectID
            // 
            this.TextBoxProjectID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxProjectID.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.TextBoxProjectID.Location = new System.Drawing.Point(230, 4);
            this.TextBoxProjectID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxProjectID.Name = "TextBoxProjectID";
            this.TextBoxProjectID.Size = new System.Drawing.Size(269, 27);
            this.TextBoxProjectID.TabIndex = 5;
            // 
            // LabelProjectID
            // 
            this.LabelProjectID.AutoSize = true;
            this.LabelProjectID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelProjectID.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.LabelProjectID.Location = new System.Drawing.Point(3, 0);
            this.LabelProjectID.Name = "LabelProjectID";
            this.LabelProjectID.Size = new System.Drawing.Size(220, 49);
            this.LabelProjectID.TabIndex = 1;
            this.LabelProjectID.Text = "ID проекта:";
            this.LabelProjectID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 92);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название проекта:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RichTextBoxProjectDescription
            // 
            this.RichTextBoxProjectDescription.BackColor = System.Drawing.SystemColors.Window;
            this.RichTextBoxProjectDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBoxProjectDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxProjectDescription.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBoxProjectDescription.Location = new System.Drawing.Point(506, 52);
            this.RichTextBoxProjectDescription.MaxLength = 500;
            this.RichTextBoxProjectDescription.Name = "RichTextBoxProjectDescription";
            this.tableLayoutPanel4.SetRowSpan(this.RichTextBoxProjectDescription, 4);
            this.RichTextBoxProjectDescription.Size = new System.Drawing.Size(318, 483);
            this.RichTextBoxProjectDescription.TabIndex = 9;
            this.RichTextBoxProjectDescription.Text = "";
            // 
            // TextBoxProjectPrice
            // 
            this.TextBoxProjectPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxProjectPrice.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.TextBoxProjectPrice.Location = new System.Drawing.Point(230, 260);
            this.TextBoxProjectPrice.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxProjectPrice.Name = "TextBoxProjectPrice";
            this.TextBoxProjectPrice.Size = new System.Drawing.Size(269, 27);
            this.TextBoxProjectPrice.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.label3.Location = new System.Drawing.Point(3, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Цена проекта:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.ButtonAddCategory, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ComboBoxProjectCategory, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(229, 144);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.48649F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.51351F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(271, 109);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // ButtonAddCategory
            // 
            this.ButtonAddCategory.AutoEllipsis = true;
            this.ButtonAddCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonAddCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAddCategory.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ButtonAddCategory.ForeColor = System.Drawing.Color.White;
            this.ButtonAddCategory.Location = new System.Drawing.Point(4, 71);
            this.ButtonAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAddCategory.Name = "ButtonAddCategory";
            this.ButtonAddCategory.Size = new System.Drawing.Size(263, 34);
            this.ButtonAddCategory.TabIndex = 12;
            this.ButtonAddCategory.Text = "Добавить категорию";
            this.ButtonAddCategory.UseVisualStyleBackColor = false;
            this.ButtonAddCategory.Click += new System.EventHandler(this.ButtonAddCategory_Click);
            // 
            // ComboBoxProjectCategory
            // 
            this.ComboBoxProjectCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxProjectCategory.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ComboBoxProjectCategory.FormattingEnabled = true;
            this.ComboBoxProjectCategory.Location = new System.Drawing.Point(3, 3);
            this.ComboBoxProjectCategory.Name = "ComboBoxProjectCategory";
            this.ComboBoxProjectCategory.Size = new System.Drawing.Size(265, 30);
            this.ComboBoxProjectCategory.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 115);
            this.label4.TabIndex = 4;
            this.label4.Text = "Категория проекта:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.label6.Location = new System.Drawing.Point(3, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 246);
            this.label6.TabIndex = 14;
            this.label6.Text = "Изображение";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.ButtonChangeImage, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.ButtonDefaultImage, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.PictureBoxProjectImage, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(229, 295);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.21344F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.78656F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(271, 240);
            this.tableLayoutPanel5.TabIndex = 15;
            // 
            // ButtonChangeImage
            // 
            this.ButtonChangeImage.AutoEllipsis = true;
            this.ButtonChangeImage.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonChangeImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonChangeImage.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ButtonChangeImage.ForeColor = System.Drawing.Color.White;
            this.ButtonChangeImage.Location = new System.Drawing.Point(139, 201);
            this.ButtonChangeImage.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonChangeImage.Name = "ButtonChangeImage";
            this.ButtonChangeImage.Size = new System.Drawing.Size(128, 35);
            this.ButtonChangeImage.TabIndex = 12;
            this.ButtonChangeImage.Text = "Выбрать";
            this.ButtonChangeImage.UseVisualStyleBackColor = false;
            this.ButtonChangeImage.Click += new System.EventHandler(this.ButtonChangeImage_Click);
            // 
            // ButtonDefaultImage
            // 
            this.ButtonDefaultImage.AutoEllipsis = true;
            this.ButtonDefaultImage.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonDefaultImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDefaultImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDefaultImage.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ButtonDefaultImage.ForeColor = System.Drawing.Color.White;
            this.ButtonDefaultImage.Location = new System.Drawing.Point(4, 201);
            this.ButtonDefaultImage.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonDefaultImage.Name = "ButtonDefaultImage";
            this.ButtonDefaultImage.Size = new System.Drawing.Size(127, 35);
            this.ButtonDefaultImage.TabIndex = 11;
            this.ButtonDefaultImage.Text = "Отмена";
            this.ButtonDefaultImage.UseVisualStyleBackColor = false;
            this.ButtonDefaultImage.Click += new System.EventHandler(this.ButtonDefaultImage_Click);
            // 
            // PictureBoxProjectImage
            // 
            this.PictureBoxProjectImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel5.SetColumnSpan(this.PictureBoxProjectImage, 2);
            this.PictureBoxProjectImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxProjectImage.Location = new System.Drawing.Point(3, 3);
            this.PictureBoxProjectImage.Name = "PictureBoxProjectImage";
            this.PictureBoxProjectImage.Size = new System.Drawing.Size(265, 191);
            this.PictureBoxProjectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxProjectImage.TabIndex = 10;
            this.PictureBoxProjectImage.TabStop = false;
            this.PictureBoxProjectImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBoxProjectImage_DragDrop);
            this.PictureBoxProjectImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBoxProjectImage_DragEnter);
            // 
            // FormChangeProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 702);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChangeProject";
            this.Text = "Редактирование проекта";
            this.Load += new System.EventHandler(this.FormChangeProject_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProjectImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelTemplateName;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label LabelProjectID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonProjectDelete;
        private System.Windows.Forms.Button ButtonProjectUpdate;
        private System.Windows.Forms.Button ButtonProjectAdd;
        private System.Windows.Forms.TextBox TextBoxProjectName;
        private System.Windows.Forms.TextBox TextBoxProjectPrice;
        private System.Windows.Forms.RichTextBox RichTextBoxProjectDescription;
        private System.Windows.Forms.PictureBox PictureBoxProjectImage;
        private System.Windows.Forms.ComboBox ComboBoxProjectCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button ButtonAddCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button ButtonChangeImage;
        private System.Windows.Forms.Button ButtonDefaultImage;
        private System.Windows.Forms.Button ButtonAddManager;
        public System.Windows.Forms.TextBox TextBoxProjectID;
    }
}

