namespace Bakery
{
    partial class inputBakeryProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inputBakeryProducts));
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.recipeSearchTextBox = new System.Windows.Forms.TextBox();
            this.recipeSearchLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.changeBakeryButton = new System.Windows.Forms.Button();
            this.addBakeryButton = new System.Windows.Forms.Button();
            this.typeLabel = new System.Windows.Forms.Label();
            this.bakeryDataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.recipeSearchButton = new System.Windows.Forms.Button();
            this.recipeNameComboBox = new System.Windows.Forms.ComboBox();
            this.recipeNameLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.expirationDateTextBox = new System.Windows.Forms.TextBox();
            this.expirationDateLabel = new System.Windows.Forms.Label();
            this.dateOfPreparationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfImplementationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfPreparationLabel = new System.Windows.Forms.Label();
            this.dateOfImplementationLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.rubLabel = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.addAndChangeButton = new System.Windows.Forms.Button();
            this.implementationButton = new System.Windows.Forms.Button();
            this.trashButton = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.printButton = new System.Windows.Forms.Button();
            this.recipeNameImplementationComboBox = new System.Windows.Forms.ComboBox();
            this.applyImplementationButton = new System.Windows.Forms.Button();
            this.applyTrashButton = new System.Windows.Forms.Button();
            this.finalCostTextBox = new System.Windows.Forms.TextBox();
            this.allRubLabel = new System.Windows.Forms.Label();
            this.finalCostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // codeTextBox
            // 
            this.codeTextBox.Enabled = false;
            this.codeTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeTextBox.Location = new System.Drawing.Point(633, 454);
            this.codeTextBox.MaxLength = 8;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(249, 26);
            this.codeTextBox.TabIndex = 6;
            this.codeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterNumber_KeyPress);
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeLabel.Location = new System.Drawing.Point(520, 454);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(44, 23);
            this.codeLabel.TabIndex = 115;
            this.codeLabel.Text = "Код";
            // 
            // recipeSearchTextBox
            // 
            this.recipeSearchTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeSearchTextBox.Location = new System.Drawing.Point(360, 35);
            this.recipeSearchTextBox.MaxLength = 100;
            this.recipeSearchTextBox.Name = "recipeSearchTextBox";
            this.recipeSearchTextBox.Size = new System.Drawing.Size(348, 26);
            this.recipeSearchTextBox.TabIndex = 11;
            // 
            // recipeSearchLabel
            // 
            this.recipeSearchLabel.AutoSize = true;
            this.recipeSearchLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeSearchLabel.Location = new System.Drawing.Point(411, 9);
            this.recipeSearchLabel.Name = "recipeSearchLabel";
            this.recipeSearchLabel.Size = new System.Drawing.Size(256, 23);
            this.recipeSearchLabel.TabIndex = 108;
            this.recipeSearchLabel.Text = "Поиск по названию рецепта";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(696, 573);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(343, 34);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // changeBakeryButton
            // 
            this.changeBakeryButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeBakeryButton.Location = new System.Drawing.Point(353, 573);
            this.changeBakeryButton.Name = "changeBakeryButton";
            this.changeBakeryButton.Size = new System.Drawing.Size(314, 34);
            this.changeBakeryButton.TabIndex = 9;
            this.changeBakeryButton.Text = "Изменить";
            this.changeBakeryButton.UseVisualStyleBackColor = true;
            this.changeBakeryButton.Click += new System.EventHandler(this.changeBakeryButton_Click);
            // 
            // addBakeryButton
            // 
            this.addBakeryButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBakeryButton.Location = new System.Drawing.Point(12, 573);
            this.addBakeryButton.Name = "addBakeryButton";
            this.addBakeryButton.Size = new System.Drawing.Size(314, 34);
            this.addBakeryButton.TabIndex = 8;
            this.addBakeryButton.Text = "Добавить";
            this.addBakeryButton.UseVisualStyleBackColor = true;
            this.addBakeryButton.Click += new System.EventHandler(this.addBakeryButton_Click);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(521, 531);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(43, 23);
            this.typeLabel.TabIndex = 103;
            this.typeLabel.Text = "Тип";
            // 
            // bakeryDataGridView
            // 
            this.bakeryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bakeryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bakeryDataGridView.Location = new System.Drawing.Point(4, 70);
            this.bakeryDataGridView.Name = "bakeryDataGridView";
            this.bakeryDataGridView.ReadOnly = true;
            this.bakeryDataGridView.Size = new System.Drawing.Size(1102, 330);
            this.bakeryDataGridView.TabIndex = 101;
            this.bakeryDataGridView.Click += new System.EventHandler(this.bakeryDataGridView_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(285, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // recipeSearchButton
            // 
            this.recipeSearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("recipeSearchButton.BackgroundImage")));
            this.recipeSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.recipeSearchButton.Location = new System.Drawing.Point(714, 32);
            this.recipeSearchButton.Name = "recipeSearchButton";
            this.recipeSearchButton.Size = new System.Drawing.Size(63, 32);
            this.recipeSearchButton.TabIndex = 12;
            this.recipeSearchButton.UseVisualStyleBackColor = true;
            this.recipeSearchButton.Click += new System.EventHandler(this.recipeSearchButton_Click);
            // 
            // recipeNameComboBox
            // 
            this.recipeNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recipeNameComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeNameComboBox.FormattingEnabled = true;
            this.recipeNameComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.recipeNameComboBox.Location = new System.Drawing.Point(233, 451);
            this.recipeNameComboBox.Name = "recipeNameComboBox";
            this.recipeNameComboBox.Size = new System.Drawing.Size(249, 27);
            this.recipeNameComboBox.TabIndex = 1;
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.AutoSize = true;
            this.recipeNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeNameLabel.Location = new System.Drawing.Point(39, 455);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(165, 23);
            this.recipeNameLabel.TabIndex = 117;
            this.recipeNameLabel.Text = "Название рецепта";
            // 
            // costTextBox
            // 
            this.costTextBox.Enabled = false;
            this.costTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costTextBox.Location = new System.Drawing.Point(634, 493);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(197, 26);
            this.costTextBox.TabIndex = 120;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(520, 496);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(108, 23);
            this.costLabel.TabIndex = 119;
            this.costLabel.Text = "Стоимость";
            // 
            // expirationDateTextBox
            // 
            this.expirationDateTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expirationDateTextBox.Location = new System.Drawing.Point(233, 488);
            this.expirationDateTextBox.MaxLength = 5;
            this.expirationDateTextBox.Name = "expirationDateTextBox";
            this.expirationDateTextBox.Size = new System.Drawing.Size(185, 26);
            this.expirationDateTextBox.TabIndex = 2;
            this.expirationDateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterNumber_KeyPress);
            // 
            // expirationDateLabel
            // 
            this.expirationDateLabel.AutoSize = true;
            this.expirationDateLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expirationDateLabel.Location = new System.Drawing.Point(39, 491);
            this.expirationDateLabel.Name = "expirationDateLabel";
            this.expirationDateLabel.Size = new System.Drawing.Size(141, 23);
            this.expirationDateLabel.TabIndex = 121;
            this.expirationDateLabel.Text = "Срок годности";
            // 
            // dateOfPreparationDateTimePicker
            // 
            this.dateOfPreparationDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfPreparationDateTimePicker.Location = new System.Drawing.Point(233, 529);
            this.dateOfPreparationDateTimePicker.Name = "dateOfPreparationDateTimePicker";
            this.dateOfPreparationDateTimePicker.Size = new System.Drawing.Size(249, 26);
            this.dateOfPreparationDateTimePicker.TabIndex = 3;
            // 
            // dateOfImplementationDateTimePicker
            // 
            this.dateOfImplementationDateTimePicker.Checked = false;
            this.dateOfImplementationDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfImplementationDateTimePicker.Location = new System.Drawing.Point(681, 455);
            this.dateOfImplementationDateTimePicker.Name = "dateOfImplementationDateTimePicker";
            this.dateOfImplementationDateTimePicker.Size = new System.Drawing.Size(202, 26);
            this.dateOfImplementationDateTimePicker.TabIndex = 4;
            this.dateOfImplementationDateTimePicker.Visible = false;
            // 
            // dateOfPreparationLabel
            // 
            this.dateOfPreparationLabel.AutoSize = true;
            this.dateOfPreparationLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfPreparationLabel.Location = new System.Drawing.Point(40, 533);
            this.dateOfPreparationLabel.Name = "dateOfPreparationLabel";
            this.dateOfPreparationLabel.Size = new System.Drawing.Size(187, 23);
            this.dateOfPreparationLabel.TabIndex = 125;
            this.dateOfPreparationLabel.Text = "Дата приготовления";
            // 
            // dateOfImplementationLabel
            // 
            this.dateOfImplementationLabel.AutoSize = true;
            this.dateOfImplementationLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfImplementationLabel.Location = new System.Drawing.Point(521, 455);
            this.dateOfImplementationLabel.Name = "dateOfImplementationLabel";
            this.dateOfImplementationLabel.Size = new System.Drawing.Size(154, 23);
            this.dateOfImplementationLabel.TabIndex = 126;
            this.dateOfImplementationLabel.Text = "Дата реализации";
            this.dateOfImplementationLabel.Visible = false;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Беляш",
            "Булочка",
            "Ватрушка",
            "Курник",
            "Пирожок",
            "Пирожное",
            "Пончик",
            "Сочник",
            "Кекс",
            "Слойка",
            "Круассан",
            "Хлеб",
            "Печенье"});
            this.typeComboBox.Location = new System.Drawing.Point(634, 531);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(249, 27);
            this.typeComboBox.TabIndex = 7;
            // 
            // rubLabel
            // 
            this.rubLabel.AutoSize = true;
            this.rubLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rubLabel.Location = new System.Drawing.Point(837, 496);
            this.rubLabel.Name = "rubLabel";
            this.rubLabel.Size = new System.Drawing.Size(45, 23);
            this.rubLabel.TabIndex = 127;
            this.rubLabel.Text = "руб.";
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hourLabel.Location = new System.Drawing.Point(424, 491);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(58, 23);
            this.hourLabel.TabIndex = 128;
            this.hourLabel.Text = "суток";
            // 
            // addAndChangeButton
            // 
            this.addAndChangeButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAndChangeButton.Location = new System.Drawing.Point(4, 406);
            this.addAndChangeButton.Name = "addAndChangeButton";
            this.addAndChangeButton.Size = new System.Drawing.Size(356, 34);
            this.addAndChangeButton.TabIndex = 129;
            this.addAndChangeButton.Text = "Добавление и изменение";
            this.addAndChangeButton.UseVisualStyleBackColor = true;
            this.addAndChangeButton.Click += new System.EventHandler(this.addAndChangeButton_Click);
            // 
            // implementationButton
            // 
            this.implementationButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.implementationButton.Location = new System.Drawing.Point(366, 406);
            this.implementationButton.Name = "implementationButton";
            this.implementationButton.Size = new System.Drawing.Size(363, 34);
            this.implementationButton.TabIndex = 130;
            this.implementationButton.Text = "Реализация";
            this.implementationButton.UseVisualStyleBackColor = true;
            this.implementationButton.Click += new System.EventHandler(this.implementationButton_Click);
            // 
            // trashButton
            // 
            this.trashButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trashButton.Location = new System.Drawing.Point(746, 406);
            this.trashButton.Name = "trashButton";
            this.trashButton.Size = new System.Drawing.Size(360, 34);
            this.trashButton.TabIndex = 131;
            this.trashButton.Text = "Списание";
            this.trashButton.UseVisualStyleBackColor = true;
            this.trashButton.Click += new System.EventHandler(this.trashButton_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLabel.Location = new System.Drawing.Point(521, 496);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(115, 23);
            this.quantityLabel.TabIndex = 132;
            this.quantityLabel.Text = "Количество";
            this.quantityLabel.Visible = false;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityTextBox.Location = new System.Drawing.Point(680, 493);
            this.quantityTextBox.MaxLength = 8;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(202, 26);
            this.quantityTextBox.TabIndex = 133;
            this.quantityTextBox.Visible = false;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterNumber_KeyPress);
            this.quantityTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.quantityTextBox_KeyUp);
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reasonLabel.Location = new System.Drawing.Point(40, 454);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(174, 23);
            this.reasonLabel.TabIndex = 134;
            this.reasonLabel.Text = "Причина списания";
            this.reasonLabel.Visible = false;
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.Enabled = false;
            this.reasonTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reasonTextBox.Location = new System.Drawing.Point(233, 452);
            this.reasonTextBox.MaxLength = 100;
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(249, 26);
            this.reasonTextBox.TabIndex = 135;
            this.reasonTextBox.Visible = false;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printButton.Location = new System.Drawing.Point(889, 451);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(217, 107);
            this.printButton.TabIndex = 136;
            this.printButton.Text = "Распечатать технологическую карту";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // recipeNameImplementationComboBox
            // 
            this.recipeNameImplementationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recipeNameImplementationComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeNameImplementationComboBox.FormattingEnabled = true;
            this.recipeNameImplementationComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.recipeNameImplementationComboBox.Location = new System.Drawing.Point(233, 451);
            this.recipeNameImplementationComboBox.Name = "recipeNameImplementationComboBox";
            this.recipeNameImplementationComboBox.Size = new System.Drawing.Size(249, 27);
            this.recipeNameImplementationComboBox.TabIndex = 137;
            this.recipeNameImplementationComboBox.Visible = false;
            // 
            // applyImplementationButton
            // 
            this.applyImplementationButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applyImplementationButton.Location = new System.Drawing.Point(353, 573);
            this.applyImplementationButton.Name = "applyImplementationButton";
            this.applyImplementationButton.Size = new System.Drawing.Size(314, 34);
            this.applyImplementationButton.TabIndex = 138;
            this.applyImplementationButton.Text = "Реализовать";
            this.applyImplementationButton.UseVisualStyleBackColor = true;
            this.applyImplementationButton.Visible = false;
            this.applyImplementationButton.Click += new System.EventHandler(this.applyImplementationButton_Click);
            // 
            // applyTrashButton
            // 
            this.applyTrashButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applyTrashButton.Location = new System.Drawing.Point(353, 573);
            this.applyTrashButton.Name = "applyTrashButton";
            this.applyTrashButton.Size = new System.Drawing.Size(314, 34);
            this.applyTrashButton.TabIndex = 139;
            this.applyTrashButton.Text = "Списать";
            this.applyTrashButton.UseVisualStyleBackColor = true;
            this.applyTrashButton.Visible = false;
            this.applyTrashButton.Click += new System.EventHandler(this.applyTrashButton_Click);
            // 
            // finalCostTextBox
            // 
            this.finalCostTextBox.Enabled = false;
            this.finalCostTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finalCostTextBox.Location = new System.Drawing.Point(233, 488);
            this.finalCostTextBox.Name = "finalCostTextBox";
            this.finalCostTextBox.ReadOnly = true;
            this.finalCostTextBox.Size = new System.Drawing.Size(197, 26);
            this.finalCostTextBox.TabIndex = 140;
            this.finalCostTextBox.Visible = false;
            // 
            // allRubLabel
            // 
            this.allRubLabel.AutoSize = true;
            this.allRubLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allRubLabel.Location = new System.Drawing.Point(437, 488);
            this.allRubLabel.Name = "allRubLabel";
            this.allRubLabel.Size = new System.Drawing.Size(45, 23);
            this.allRubLabel.TabIndex = 141;
            this.allRubLabel.Text = "руб.";
            this.allRubLabel.Visible = false;
            // 
            // finalCostLabel
            // 
            this.finalCostLabel.AutoSize = true;
            this.finalCostLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finalCostLabel.Location = new System.Drawing.Point(40, 491);
            this.finalCostLabel.Name = "finalCostLabel";
            this.finalCostLabel.Size = new System.Drawing.Size(87, 23);
            this.finalCostLabel.TabIndex = 142;
            this.finalCostLabel.Text = "К оплате";
            this.finalCostLabel.Visible = false;
            // 
            // inputBakeryProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 615);
            this.Controls.Add(this.finalCostLabel);
            this.Controls.Add(this.allRubLabel);
            this.Controls.Add(this.finalCostTextBox);
            this.Controls.Add(this.applyTrashButton);
            this.Controls.Add(this.applyImplementationButton);
            this.Controls.Add(this.recipeNameImplementationComboBox);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.reasonTextBox);
            this.Controls.Add(this.reasonLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.trashButton);
            this.Controls.Add(this.implementationButton);
            this.Controls.Add(this.addAndChangeButton);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.rubLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.dateOfImplementationLabel);
            this.Controls.Add(this.dateOfPreparationLabel);
            this.Controls.Add(this.dateOfImplementationDateTimePicker);
            this.Controls.Add(this.dateOfPreparationDateTimePicker);
            this.Controls.Add(this.expirationDateTextBox);
            this.Controls.Add(this.expirationDateLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.recipeNameComboBox);
            this.Controls.Add(this.recipeNameLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.recipeSearchButton);
            this.Controls.Add(this.recipeSearchTextBox);
            this.Controls.Add(this.recipeSearchLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.changeBakeryButton);
            this.Controls.Add(this.addBakeryButton);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.bakeryDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inputBakeryProducts";
            this.Text = "Управление выпечкой";
            this.Activated += new System.EventHandler(this.inputBakeryProducts_Activated);
            this.Load += new System.EventHandler(this.inputBakeryProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button recipeSearchButton;
        private System.Windows.Forms.TextBox recipeSearchTextBox;
        private System.Windows.Forms.Label recipeSearchLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button changeBakeryButton;
        private System.Windows.Forms.Button addBakeryButton;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.DataGridView bakeryDataGridView;
        private System.Windows.Forms.ComboBox recipeNameComboBox;
        private System.Windows.Forms.Label recipeNameLabel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox expirationDateTextBox;
        private System.Windows.Forms.Label expirationDateLabel;
        private System.Windows.Forms.DateTimePicker dateOfPreparationDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateOfImplementationDateTimePicker;
        private System.Windows.Forms.Label dateOfPreparationLabel;
        private System.Windows.Forms.Label dateOfImplementationLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label rubLabel;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Button addAndChangeButton;
        private System.Windows.Forms.Button implementationButton;
        private System.Windows.Forms.Button trashButton;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label reasonLabel;
        private System.Windows.Forms.TextBox reasonTextBox;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.ComboBox recipeNameImplementationComboBox;
        private System.Windows.Forms.Button applyImplementationButton;
        private System.Windows.Forms.Button applyTrashButton;
        private System.Windows.Forms.TextBox finalCostTextBox;
        private System.Windows.Forms.Label allRubLabel;
        private System.Windows.Forms.Label finalCostLabel;
    }
}