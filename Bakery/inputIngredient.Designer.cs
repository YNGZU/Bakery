namespace Bakery
{
    partial class inputIngredient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inputIngredient));
            this.ingredientNameLabel = new System.Windows.Forms.Label();
            this.ingredientSearchTextBox = new System.Windows.Forms.TextBox();
            this.ingredientSearchLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.changeIngredientButton = new System.Windows.Forms.Button();
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.ingredientDataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ingredientSearchButton = new System.Windows.Forms.Button();
            this.ingredientNameTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.rubLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ingredientNameLabel
            // 
            this.ingredientNameLabel.AutoSize = true;
            this.ingredientNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ingredientNameLabel.Location = new System.Drawing.Point(629, 9);
            this.ingredientNameLabel.Name = "ingredientNameLabel";
            this.ingredientNameLabel.Size = new System.Drawing.Size(139, 23);
            this.ingredientNameLabel.TabIndex = 94;
            this.ingredientNameLabel.Text = "Наименование";
            // 
            // ingredientSearchTextBox
            // 
            this.ingredientSearchTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ingredientSearchTextBox.Location = new System.Drawing.Point(99, 35);
            this.ingredientSearchTextBox.MaxLength = 100;
            this.ingredientSearchTextBox.Name = "ingredientSearchTextBox";
            this.ingredientSearchTextBox.Size = new System.Drawing.Size(348, 32);
            this.ingredientSearchTextBox.TabIndex = 8;
            // 
            // ingredientSearchLabel
            // 
            this.ingredientSearchLabel.AutoSize = true;
            this.ingredientSearchLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ingredientSearchLabel.Location = new System.Drawing.Point(131, 9);
            this.ingredientSearchLabel.Name = "ingredientSearchLabel";
            this.ingredientSearchLabel.Size = new System.Drawing.Size(298, 23);
            this.ingredientSearchLabel.TabIndex = 91;
            this.ingredientSearchLabel.Text = "Поиск по названию ингредиента";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(629, 240);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(402, 34);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // changeIngredientButton
            // 
            this.changeIngredientButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeIngredientButton.Location = new System.Drawing.Point(629, 200);
            this.changeIngredientButton.Name = "changeIngredientButton";
            this.changeIngredientButton.Size = new System.Drawing.Size(402, 34);
            this.changeIngredientButton.TabIndex = 6;
            this.changeIngredientButton.Text = "Изменить";
            this.changeIngredientButton.UseVisualStyleBackColor = true;
            this.changeIngredientButton.Click += new System.EventHandler(this.changeIngredientButton_Click);
            // 
            // addIngredientButton
            // 
            this.addIngredientButton.BackColor = System.Drawing.SystemColors.Control;
            this.addIngredientButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addIngredientButton.FlatAppearance.BorderSize = 0;
            this.addIngredientButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addIngredientButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addIngredientButton.Location = new System.Drawing.Point(629, 160);
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.Size = new System.Drawing.Size(402, 34);
            this.addIngredientButton.TabIndex = 5;
            this.addIngredientButton.Text = "Добавить";
            this.addIngredientButton.UseVisualStyleBackColor = false;
            this.addIngredientButton.Click += new System.EventHandler(this.addIngredientButton_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityTextBox.Location = new System.Drawing.Point(774, 47);
            this.quantityTextBox.MaxLength = 10;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(148, 32);
            this.quantityTextBox.TabIndex = 2;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.implementingNumberInput);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLabel.Location = new System.Drawing.Point(629, 47);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(115, 23);
            this.quantityLabel.TabIndex = 86;
            this.quantityLabel.Text = "Количество";
            // 
            // ingredientDataGridView
            // 
            this.ingredientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ingredientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientDataGridView.Location = new System.Drawing.Point(-4, 70);
            this.ingredientDataGridView.Name = "ingredientDataGridView";
            this.ingredientDataGridView.ReadOnly = true;
            this.ingredientDataGridView.Size = new System.Drawing.Size(618, 204);
            this.ingredientDataGridView.TabIndex = 84;
            this.ingredientDataGridView.Click += new System.EventHandler(this.ingredientDataGridView_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(933, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // ingredientSearchButton
            // 
            this.ingredientSearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ingredientSearchButton.BackgroundImage")));
            this.ingredientSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ingredientSearchButton.Location = new System.Drawing.Point(453, 35);
            this.ingredientSearchButton.Name = "ingredientSearchButton";
            this.ingredientSearchButton.Size = new System.Drawing.Size(52, 32);
            this.ingredientSearchButton.TabIndex = 9;
            this.ingredientSearchButton.UseVisualStyleBackColor = true;
            this.ingredientSearchButton.Click += new System.EventHandler(this.ingredientSearchButton_Click);
            // 
            // ingredientNameTextBox
            // 
            this.ingredientNameTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ingredientNameTextBox.Location = new System.Drawing.Point(774, 9);
            this.ingredientNameTextBox.MaxLength = 100;
            this.ingredientNameTextBox.Name = "ingredientNameTextBox";
            this.ingredientNameTextBox.Size = new System.Drawing.Size(257, 32);
            this.ingredientNameTextBox.TabIndex = 1;
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costTextBox.Location = new System.Drawing.Point(774, 85);
            this.costTextBox.MaxLength = 10;
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(101, 32);
            this.costTextBox.TabIndex = 3;
            this.costTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.implementingNumberInput);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(629, 85);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(108, 23);
            this.costLabel.TabIndex = 99;
            this.costLabel.Text = "Стоимость";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitLabel.Location = new System.Drawing.Point(629, 123);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(136, 23);
            this.unitLabel.TabIndex = 101;
            this.unitLabel.Text = "Ед. измерения";
            // 
            // unitComboBox
            // 
            this.unitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Items.AddRange(new object[] {
            "кг.",
            "л.",
            "шт.",
            "г.",
            "мл."});
            this.unitComboBox.Location = new System.Drawing.Point(774, 123);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(249, 31);
            this.unitComboBox.TabIndex = 102;
            // 
            // rubLabel
            // 
            this.rubLabel.AutoSize = true;
            this.rubLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rubLabel.Location = new System.Drawing.Point(877, 88);
            this.rubLabel.Name = "rubLabel";
            this.rubLabel.Size = new System.Drawing.Size(45, 23);
            this.rubLabel.TabIndex = 103;
            this.rubLabel.Text = "руб.";
            // 
            // inputIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 282);
            this.Controls.Add(this.rubLabel);
            this.Controls.Add(this.unitComboBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.ingredientNameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ingredientNameLabel);
            this.Controls.Add(this.ingredientSearchButton);
            this.Controls.Add(this.ingredientSearchTextBox);
            this.Controls.Add(this.ingredientSearchLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.changeIngredientButton);
            this.Controls.Add(this.addIngredientButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.ingredientDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inputIngredient";
            this.Text = "Управление ингредиентами";
            this.Activated += new System.EventHandler(this.inputIngredient_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.ingredientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ingredientNameLabel;
        private System.Windows.Forms.Button ingredientSearchButton;
        private System.Windows.Forms.TextBox ingredientSearchTextBox;
        private System.Windows.Forms.Label ingredientSearchLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button changeIngredientButton;
        private System.Windows.Forms.Button addIngredientButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.DataGridView ingredientDataGridView;
        private System.Windows.Forms.TextBox ingredientNameTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.Label rubLabel;
    }
}