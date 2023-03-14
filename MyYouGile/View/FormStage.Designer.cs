namespace MyYouGile
{
    partial class FormStage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelTemplateName = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVStages = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelStage = new System.Windows.Forms.Label();
            this.LabelDateStart = new System.Windows.Forms.Label();
            this.LabelDateEnd = new System.Windows.Forms.Label();
            this.TextBoxDateStart = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxDateEnd = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxStage = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonSendRequest = new System.Windows.Forms.Button();
            this.ButtonStageDelete = new System.Windows.Forms.Button();
            this.ButtonStageChange = new System.Windows.Forms.Button();
            this.ButtonStageAdd = new System.Windows.Forms.Button();
            this.ButtonAcceptRequest = new System.Windows.Forms.Button();
            this.ButtonDeclineRequest = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.ComboBoxStatus = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStages)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(972, 55);
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
            this.LabelTemplateName.Location = new System.Drawing.Point(69, 0);
            this.LabelTemplateName.Name = "LabelTemplateName";
            this.LabelTemplateName.Size = new System.Drawing.Size(616, 55);
            this.LabelTemplateName.TabIndex = 1;
            this.LabelTemplateName.Text = "Запись на проект";
            this.LabelTemplateName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.Location = new System.Drawing.Point(691, 3);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(278, 49);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "Выйти";
            this.ButtonExit.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 589);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(972, 55);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.DGVStages, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.59176F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.40824F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(972, 534);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // DGVStages
            // 
            this.DGVStages.AllowUserToAddRows = false;
            this.DGVStages.AllowUserToDeleteRows = false;
            this.DGVStages.BackgroundColor = System.Drawing.Color.White;
            this.DGVStages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStages.ColumnHeadersVisible = false;
            this.DGVStages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3});
            this.DGVStages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVStages.GridColor = System.Drawing.Color.DarkGray;
            this.DGVStages.Location = new System.Drawing.Point(4, 4);
            this.DGVStages.Margin = new System.Windows.Forms.Padding(4);
            this.DGVStages.Name = "DGVStages";
            this.DGVStages.ReadOnly = true;
            this.DGVStages.RowHeadersWidth = 51;
            this.DGVStages.Size = new System.Drawing.Size(478, 401);
            this.DGVStages.TabIndex = 2;
            this.DGVStages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStages_CellContentClick);
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
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Format = "d";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 125;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Format = "d";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 125;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.45833F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.54166F));
            this.tableLayoutPanel4.Controls.Add(this.LabelStage, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.LabelDateStart, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.LabelDateEnd, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.TextBoxDateStart, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.TextBoxDateEnd, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.TextBoxStage, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(489, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.44414F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.53406F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.16894F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.85286F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(480, 403);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // LabelStage
            // 
            this.LabelStage.AutoSize = true;
            this.LabelStage.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.LabelStage.Location = new System.Drawing.Point(3, 0);
            this.LabelStage.Name = "LabelStage";
            this.LabelStage.Size = new System.Drawing.Size(50, 22);
            this.LabelStage.TabIndex = 3;
            this.LabelStage.Text = "Этап";
            this.LabelStage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelDateStart
            // 
            this.LabelDateStart.AutoSize = true;
            this.LabelDateStart.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.LabelDateStart.Location = new System.Drawing.Point(3, 46);
            this.LabelDateStart.Name = "LabelDateStart";
            this.LabelDateStart.Size = new System.Drawing.Size(70, 22);
            this.LabelDateStart.TabIndex = 5;
            this.LabelDateStart.Text = "Начало";
            this.LabelDateStart.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelDateEnd
            // 
            this.LabelDateEnd.AutoSize = true;
            this.LabelDateEnd.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.LabelDateEnd.Location = new System.Drawing.Point(3, 96);
            this.LabelDateEnd.Name = "LabelDateEnd";
            this.LabelDateEnd.Size = new System.Drawing.Size(60, 22);
            this.LabelDateEnd.TabIndex = 4;
            this.LabelDateEnd.Text = "Конец";
            this.LabelDateEnd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxDateStart
            // 
            this.TextBoxDateStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxDateStart.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.TextBoxDateStart.Location = new System.Drawing.Point(105, 49);
            this.TextBoxDateStart.Mask = "00/00/0000";
            this.TextBoxDateStart.Name = "TextBoxDateStart";
            this.TextBoxDateStart.Size = new System.Drawing.Size(372, 27);
            this.TextBoxDateStart.TabIndex = 6;
            this.TextBoxDateStart.ValidatingType = typeof(System.DateTime);
            // 
            // TextBoxDateEnd
            // 
            this.TextBoxDateEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxDateEnd.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.TextBoxDateEnd.Location = new System.Drawing.Point(105, 99);
            this.TextBoxDateEnd.Mask = "00/00/0000";
            this.TextBoxDateEnd.Name = "TextBoxDateEnd";
            this.TextBoxDateEnd.Size = new System.Drawing.Size(372, 27);
            this.TextBoxDateEnd.TabIndex = 7;
            this.TextBoxDateEnd.ValidatingType = typeof(System.DateTime);
            // 
            // TextBoxStage
            // 
            this.TextBoxStage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxStage.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.TextBoxStage.Location = new System.Drawing.Point(105, 3);
            this.TextBoxStage.Name = "TextBoxStage";
            this.TextBoxStage.Size = new System.Drawing.Size(372, 27);
            this.TextBoxStage.TabIndex = 8;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.ButtonDeclineRequest, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.ButtonStageDelete, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.ButtonSendRequest, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.ButtonStageChange, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.ButtonStageAdd, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.ButtonAcceptRequest, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(489, 412);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.42017F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.57983F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(480, 119);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // ButtonSendRequest
            // 
            this.ButtonSendRequest.AutoEllipsis = true;
            this.ButtonSendRequest.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonSendRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSendRequest.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ButtonSendRequest.ForeColor = System.Drawing.Color.White;
            this.ButtonSendRequest.Location = new System.Drawing.Point(4, 64);
            this.ButtonSendRequest.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSendRequest.Name = "ButtonSendRequest";
            this.ButtonSendRequest.Size = new System.Drawing.Size(151, 51);
            this.ButtonSendRequest.TabIndex = 8;
            this.ButtonSendRequest.Text = "Отправить";
            this.ButtonSendRequest.UseVisualStyleBackColor = false;
            this.ButtonSendRequest.Click += new System.EventHandler(this.ButtonSendRequest_Click);
            // 
            // ButtonStageDelete
            // 
            this.ButtonStageDelete.AutoEllipsis = true;
            this.ButtonStageDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonStageDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonStageDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonStageDelete.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ButtonStageDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonStageDelete.Location = new System.Drawing.Point(324, 4);
            this.ButtonStageDelete.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStageDelete.Name = "ButtonStageDelete";
            this.ButtonStageDelete.Size = new System.Drawing.Size(152, 52);
            this.ButtonStageDelete.TabIndex = 7;
            this.ButtonStageDelete.Text = "Удалить";
            this.ButtonStageDelete.UseVisualStyleBackColor = false;
            this.ButtonStageDelete.Click += new System.EventHandler(this.ButtonStageDelete_Click);
            // 
            // ButtonStageChange
            // 
            this.ButtonStageChange.AutoEllipsis = true;
            this.ButtonStageChange.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonStageChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonStageChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonStageChange.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ButtonStageChange.ForeColor = System.Drawing.Color.White;
            this.ButtonStageChange.Location = new System.Drawing.Point(164, 4);
            this.ButtonStageChange.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStageChange.Name = "ButtonStageChange";
            this.ButtonStageChange.Size = new System.Drawing.Size(152, 52);
            this.ButtonStageChange.TabIndex = 6;
            this.ButtonStageChange.Text = "Изменить";
            this.ButtonStageChange.UseVisualStyleBackColor = false;
            this.ButtonStageChange.Click += new System.EventHandler(this.ButtonStageChange_Click);
            // 
            // ButtonStageAdd
            // 
            this.ButtonStageAdd.AutoEllipsis = true;
            this.ButtonStageAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonStageAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonStageAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonStageAdd.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ButtonStageAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonStageAdd.Location = new System.Drawing.Point(4, 4);
            this.ButtonStageAdd.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStageAdd.Name = "ButtonStageAdd";
            this.ButtonStageAdd.Size = new System.Drawing.Size(152, 52);
            this.ButtonStageAdd.TabIndex = 5;
            this.ButtonStageAdd.Text = "Добавить";
            this.ButtonStageAdd.UseVisualStyleBackColor = false;
            this.ButtonStageAdd.Click += new System.EventHandler(this.ButtonStageAdd_Click);
            // 
            // ButtonAcceptRequest
            // 
            this.ButtonAcceptRequest.AutoEllipsis = true;
            this.ButtonAcceptRequest.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonAcceptRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAcceptRequest.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ButtonAcceptRequest.ForeColor = System.Drawing.Color.White;
            this.ButtonAcceptRequest.Location = new System.Drawing.Point(164, 64);
            this.ButtonAcceptRequest.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAcceptRequest.Name = "ButtonAcceptRequest";
            this.ButtonAcceptRequest.Size = new System.Drawing.Size(152, 51);
            this.ButtonAcceptRequest.TabIndex = 9;
            this.ButtonAcceptRequest.Text = "Принять";
            this.ButtonAcceptRequest.UseVisualStyleBackColor = false;
            this.ButtonAcceptRequest.Click += new System.EventHandler(this.ButtonAcceptRequest_Click);
            // 
            // ButtonDeclineRequest
            // 
            this.ButtonDeclineRequest.AutoEllipsis = true;
            this.ButtonDeclineRequest.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonDeclineRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDeclineRequest.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ButtonDeclineRequest.ForeColor = System.Drawing.Color.White;
            this.ButtonDeclineRequest.Location = new System.Drawing.Point(324, 64);
            this.ButtonDeclineRequest.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonDeclineRequest.Name = "ButtonDeclineRequest";
            this.ButtonDeclineRequest.Size = new System.Drawing.Size(152, 51);
            this.ButtonDeclineRequest.TabIndex = 10;
            this.ButtonDeclineRequest.Text = "Отменить";
            this.ButtonDeclineRequest.UseVisualStyleBackColor = false;
            this.ButtonDeclineRequest.Click += new System.EventHandler(this.ButtonDeclineRequest_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.Controls.Add(this.LabelStatus, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.ComboBoxStatus, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 412);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(480, 119);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.LabelStatus.Location = new System.Drawing.Point(3, 0);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(80, 22);
            this.LabelStatus.TabIndex = 5;
            this.LabelStatus.Text = "Статус:";
            this.LabelStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ComboBoxStatus
            // 
            this.ComboBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxStatus.Font = new System.Drawing.Font("Cascadia Mono", 10.2F);
            this.ComboBoxStatus.FormattingEnabled = true;
            this.ComboBoxStatus.Location = new System.Drawing.Point(99, 3);
            this.ComboBoxStatus.Name = "ComboBoxStatus";
            this.ComboBoxStatus.Size = new System.Drawing.Size(378, 30);
            this.ComboBoxStatus.TabIndex = 6;
            this.ComboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.ComboBoxStatus_SelectedIndexChanged);
            // 
            // FormStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 644);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStage";
            this.Text = "Этапы проекта";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStages)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelTemplateName;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView DGVStages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label LabelStage;
        private System.Windows.Forms.Label LabelDateStart;
        private System.Windows.Forms.Label LabelDateEnd;
        private System.Windows.Forms.MaskedTextBox TextBoxDateStart;
        private System.Windows.Forms.MaskedTextBox TextBoxDateEnd;
        private System.Windows.Forms.TextBox TextBoxStage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button ButtonStageDelete;
        private System.Windows.Forms.Button ButtonStageChange;
        private System.Windows.Forms.Button ButtonStageAdd;
        private System.Windows.Forms.Button ButtonSendRequest;
        private System.Windows.Forms.Button ButtonDeclineRequest;
        private System.Windows.Forms.Button ButtonAcceptRequest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.ComboBox ComboBoxStatus;
    }
}

