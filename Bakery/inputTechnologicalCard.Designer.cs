namespace Bakery
{
    partial class inputTechnologicalCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inputTechnologicalCard));
            this.recipeSearchButton = new System.Windows.Forms.Button();
            this.recipeSearchTextBox = new System.Windows.Forms.TextBox();
            this.recipeSearchLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.changeCardButton = new System.Windows.Forms.Button();
            this.saveCardButton = new System.Windows.Forms.Button();
            this.cookingTechnologyTextBox = new System.Windows.Forms.TextBox();
            this.cookingTechnologyLabel = new System.Windows.Forms.Label();
            this.recipeNameLabel = new System.Windows.Forms.Label();
            this.cardDataGridView = new System.Windows.Forms.DataGridView();
            this.typeOfProcessingLabel = new System.Windows.Forms.Label();
            this.recipeNameComboBox = new System.Windows.Forms.ComboBox();
            this.typeOfProcessingComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contentDataGridView = new System.Windows.Forms.DataGridView();
            this.addIngredientLabel = new System.Windows.Forms.Label();
            this.ingredientComboBox = new System.Windows.Forms.ComboBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.ingredientDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cardDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // recipeSearchButton
            // 
            this.recipeSearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("recipeSearchButton.BackgroundImage")));
            this.recipeSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.recipeSearchButton.Location = new System.Drawing.Point(513, 35);
            this.recipeSearchButton.Name = "recipeSearchButton";
            this.recipeSearchButton.Size = new System.Drawing.Size(43, 32);
            this.recipeSearchButton.TabIndex = 12;
            this.recipeSearchButton.UseVisualStyleBackColor = true;
            this.recipeSearchButton.Click += new System.EventHandler(this.recipeSearchButton_Click);
            // 
            // recipeSearchTextBox
            // 
            this.recipeSearchTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeSearchTextBox.Location = new System.Drawing.Point(159, 35);
            this.recipeSearchTextBox.MaxLength = 100;
            this.recipeSearchTextBox.Name = "recipeSearchTextBox";
            this.recipeSearchTextBox.Size = new System.Drawing.Size(348, 32);
            this.recipeSearchTextBox.TabIndex = 11;
            // 
            // recipeSearchLabel
            // 
            this.recipeSearchLabel.AutoSize = true;
            this.recipeSearchLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeSearchLabel.Location = new System.Drawing.Point(217, 9);
            this.recipeSearchLabel.Name = "recipeSearchLabel";
            this.recipeSearchLabel.Size = new System.Drawing.Size(256, 23);
            this.recipeSearchLabel.TabIndex = 27;
            this.recipeSearchLabel.Text = "Поиск по названию рецепта";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(553, 396);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(208, 34);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // changeCardButton
            // 
            this.changeCardButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeCardButton.Location = new System.Drawing.Point(553, 356);
            this.changeCardButton.Name = "changeCardButton";
            this.changeCardButton.Size = new System.Drawing.Size(208, 34);
            this.changeCardButton.TabIndex = 9;
            this.changeCardButton.Text = "Изменить";
            this.changeCardButton.UseVisualStyleBackColor = true;
            this.changeCardButton.Click += new System.EventHandler(this.changeCardButton_Click);
            // 
            // saveCardButton
            // 
            this.saveCardButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveCardButton.Location = new System.Drawing.Point(553, 318);
            this.saveCardButton.Name = "saveCardButton";
            this.saveCardButton.Size = new System.Drawing.Size(208, 34);
            this.saveCardButton.TabIndex = 8;
            this.saveCardButton.Text = "Сохранить";
            this.saveCardButton.UseVisualStyleBackColor = true;
            this.saveCardButton.Click += new System.EventHandler(this.saveCardButton_Click);
            // 
            // cookingTechnologyTextBox
            // 
            this.cookingTechnologyTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cookingTechnologyTextBox.Location = new System.Drawing.Point(183, 390);
            this.cookingTechnologyTextBox.Multiline = true;
            this.cookingTechnologyTextBox.Name = "cookingTechnologyTextBox";
            this.cookingTechnologyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cookingTechnologyTextBox.Size = new System.Drawing.Size(364, 125);
            this.cookingTechnologyTextBox.TabIndex = 3;
            // 
            // cookingTechnologyLabel
            // 
            this.cookingTechnologyLabel.AutoSize = true;
            this.cookingTechnologyLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cookingTechnologyLabel.Location = new System.Drawing.Point(14, 400);
            this.cookingTechnologyLabel.Name = "cookingTechnologyLabel";
            this.cookingTechnologyLabel.Size = new System.Drawing.Size(142, 46);
            this.cookingTechnologyLabel.TabIndex = 21;
            this.cookingTechnologyLabel.Text = "Технология\r\nприготовления";
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.AutoSize = true;
            this.recipeNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeNameLabel.Location = new System.Drawing.Point(12, 322);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(165, 23);
            this.recipeNameLabel.TabIndex = 20;
            this.recipeNameLabel.Text = "Название рецепта";
            // 
            // cardDataGridView
            // 
            this.cardDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardDataGridView.Location = new System.Drawing.Point(1, 70);
            this.cardDataGridView.Name = "cardDataGridView";
            this.cardDataGridView.ReadOnly = true;
            this.cardDataGridView.Size = new System.Drawing.Size(698, 235);
            this.cardDataGridView.TabIndex = 19;
            this.cardDataGridView.Click += new System.EventHandler(this.cardDataGridView_Click);
            // 
            // typeOfProcessingLabel
            // 
            this.typeOfProcessingLabel.AutoSize = true;
            this.typeOfProcessingLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeOfProcessingLabel.Location = new System.Drawing.Point(12, 356);
            this.typeOfProcessingLabel.Name = "typeOfProcessingLabel";
            this.typeOfProcessingLabel.Size = new System.Drawing.Size(144, 23);
            this.typeOfProcessingLabel.TabIndex = 30;
            this.typeOfProcessingLabel.Text = "Вид обработки";
            // 
            // recipeNameComboBox
            // 
            this.recipeNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recipeNameComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.recipeNameComboBox.Location = new System.Drawing.Point(183, 318);
            this.recipeNameComboBox.Name = "recipeNameComboBox";
            this.recipeNameComboBox.Size = new System.Drawing.Size(364, 31);
            this.recipeNameComboBox.TabIndex = 1;
            // 
            // typeOfProcessingComboBox
            // 
            this.typeOfProcessingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfProcessingComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeOfProcessingComboBox.FormattingEnabled = true;
            this.typeOfProcessingComboBox.Items.AddRange(new object[] {
            "Термическая обработка",
            "Механическая обработка",
            "Физико-химическая обработка",
            "Биологическая обработка"});
            this.typeOfProcessingComboBox.Location = new System.Drawing.Point(183, 353);
            this.typeOfProcessingComboBox.Name = "typeOfProcessingComboBox";
            this.typeOfProcessingComboBox.Size = new System.Drawing.Size(364, 31);
            this.typeOfProcessingComboBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(553, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // contentDataGridView
            // 
            this.contentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.contentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contentDataGridView.Location = new System.Drawing.Point(705, 72);
            this.contentDataGridView.Name = "contentDataGridView";
            this.contentDataGridView.ReadOnly = true;
            this.contentDataGridView.Size = new System.Drawing.Size(446, 235);
            this.contentDataGridView.TabIndex = 84;
            this.contentDataGridView.Click += new System.EventHandler(this.contentDataGridView_Click);
            // 
            // addIngredientLabel
            // 
            this.addIngredientLabel.AutoSize = true;
            this.addIngredientLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addIngredientLabel.Location = new System.Drawing.Point(14, 531);
            this.addIngredientLabel.Name = "addIngredientLabel";
            this.addIngredientLabel.Size = new System.Drawing.Size(201, 23);
            this.addIngredientLabel.TabIndex = 85;
            this.addIngredientLabel.Text = "Добавить ингредиент";
            // 
            // ingredientComboBox
            // 
            this.ingredientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ingredientComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ingredientComboBox.FormattingEnabled = true;
            this.ingredientComboBox.Location = new System.Drawing.Point(221, 523);
            this.ingredientComboBox.Name = "ingredientComboBox";
            this.ingredientComboBox.Size = new System.Drawing.Size(326, 31);
            this.ingredientComboBox.TabIndex = 4;
            this.ingredientComboBox.SelectionChangeCommitted += new System.EventHandler(this.ingredientComboBox_SelectionChangeCommitted);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLabel.Location = new System.Drawing.Point(14, 566);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(115, 23);
            this.quantityLabel.TabIndex = 87;
            this.quantityLabel.Text = "Количество";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityTextBox.Location = new System.Drawing.Point(221, 560);
            this.quantityTextBox.MaxLength = 6;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 32);
            this.quantityTextBox.TabIndex = 5;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitLabel.Location = new System.Drawing.Point(327, 563);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(81, 23);
            this.unitLabel.TabIndex = 89;
            this.unitLabel.Text = "Ед. изм.";
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusButton.Location = new System.Drawing.Point(427, 560);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(57, 37);
            this.plusButton.TabIndex = 6;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusButton.Location = new System.Drawing.Point(490, 560);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(57, 37);
            this.minusButton.TabIndex = 7;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // ingredientDataGridView
            // 
            this.ingredientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ingredientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientDataGridView.Location = new System.Drawing.Point(767, 313);
            this.ingredientDataGridView.Name = "ingredientDataGridView";
            this.ingredientDataGridView.ReadOnly = true;
            this.ingredientDataGridView.Size = new System.Drawing.Size(384, 284);
            this.ingredientDataGridView.TabIndex = 92;
            // 
            // inputTechnologicalCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 607);
            this.Controls.Add(this.ingredientDataGridView);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.ingredientComboBox);
            this.Controls.Add(this.addIngredientLabel);
            this.Controls.Add(this.contentDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.typeOfProcessingComboBox);
            this.Controls.Add(this.recipeNameComboBox);
            this.Controls.Add(this.typeOfProcessingLabel);
            this.Controls.Add(this.recipeSearchButton);
            this.Controls.Add(this.recipeSearchTextBox);
            this.Controls.Add(this.recipeSearchLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.changeCardButton);
            this.Controls.Add(this.saveCardButton);
            this.Controls.Add(this.cookingTechnologyTextBox);
            this.Controls.Add(this.cookingTechnologyLabel);
            this.Controls.Add(this.recipeNameLabel);
            this.Controls.Add(this.cardDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inputTechnologicalCard";
            this.Text = "Управление технологическими картами";
            this.Activated += new System.EventHandler(this.inputTechnologicalCard_Activated);
            this.Load += new System.EventHandler(this.inputTechnologicalCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button recipeSearchButton;
        private System.Windows.Forms.TextBox recipeSearchTextBox;
        private System.Windows.Forms.Label recipeSearchLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button changeCardButton;
        private System.Windows.Forms.Button saveCardButton;
        private System.Windows.Forms.TextBox cookingTechnologyTextBox;
        private System.Windows.Forms.Label cookingTechnologyLabel;
        private System.Windows.Forms.Label recipeNameLabel;
        private System.Windows.Forms.DataGridView cardDataGridView;
        private System.Windows.Forms.Label typeOfProcessingLabel;
        private System.Windows.Forms.ComboBox recipeNameComboBox;
        private System.Windows.Forms.ComboBox typeOfProcessingComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView contentDataGridView;
        private System.Windows.Forms.Label addIngredientLabel;
        private System.Windows.Forms.ComboBox ingredientComboBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.DataGridView ingredientDataGridView;
    }
}