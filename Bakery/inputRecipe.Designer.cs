namespace Bakery
{
    partial class inputRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inputRecipe));
            this.cancelButton = new System.Windows.Forms.Button();
            this.changeRecipeButton = new System.Windows.Forms.Button();
            this.addRecipeButton = new System.Windows.Forms.Button();
            this.cookingTimeTextBox = new System.Windows.Forms.TextBox();
            this.recipeNameTextBox = new System.Windows.Forms.TextBox();
            this.cookingTimeLabel = new System.Windows.Forms.Label();
            this.recipeNameLabel = new System.Windows.Forms.Label();
            this.recipeDataGridView = new System.Windows.Forms.DataGridView();
            this.recipeSearchLabel = new System.Windows.Forms.Label();
            this.recipeSearchTextBox = new System.Windows.Forms.TextBox();
            this.recipeSearchButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.hourLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(662, 243);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(515, 60);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // changeRecipeButton
            // 
            this.changeRecipeButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeRecipeButton.Location = new System.Drawing.Point(662, 184);
            this.changeRecipeButton.Name = "changeRecipeButton";
            this.changeRecipeButton.Size = new System.Drawing.Size(357, 53);
            this.changeRecipeButton.TabIndex = 5;
            this.changeRecipeButton.Text = "Изменить";
            this.changeRecipeButton.UseVisualStyleBackColor = true;
            this.changeRecipeButton.Click += new System.EventHandler(this.changeRecipeButton_Click);
            // 
            // addRecipeButton
            // 
            this.addRecipeButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRecipeButton.Location = new System.Drawing.Point(662, 123);
            this.addRecipeButton.Name = "addRecipeButton";
            this.addRecipeButton.Size = new System.Drawing.Size(357, 55);
            this.addRecipeButton.TabIndex = 4;
            this.addRecipeButton.Text = "Добавить";
            this.addRecipeButton.UseVisualStyleBackColor = true;
            this.addRecipeButton.Click += new System.EventHandler(this.addRecipeButton_Click);
            // 
            // cookingTimeTextBox
            // 
            this.cookingTimeTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cookingTimeTextBox.Location = new System.Drawing.Point(849, 44);
            this.cookingTimeTextBox.MaxLength = 5;
            this.cookingTimeTextBox.Name = "cookingTimeTextBox";
            this.cookingTimeTextBox.Size = new System.Drawing.Size(123, 32);
            this.cookingTimeTextBox.TabIndex = 2;
            this.cookingTimeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cookingTimeTextBox_KeyPress);
            // 
            // recipeNameTextBox
            // 
            this.recipeNameTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeNameTextBox.Location = new System.Drawing.Point(849, 8);
            this.recipeNameTextBox.MaxLength = 100;
            this.recipeNameTextBox.Name = "recipeNameTextBox";
            this.recipeNameTextBox.Size = new System.Drawing.Size(328, 32);
            this.recipeNameTextBox.TabIndex = 1;
            // 
            // cookingTimeLabel
            // 
            this.cookingTimeLabel.AutoSize = true;
            this.cookingTimeLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cookingTimeLabel.Location = new System.Drawing.Point(658, 53);
            this.cookingTimeLabel.Name = "cookingTimeLabel";
            this.cookingTimeLabel.Size = new System.Drawing.Size(141, 23);
            this.cookingTimeLabel.TabIndex = 10;
            this.cookingTimeLabel.Text = "Время готовки";
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.AutoSize = true;
            this.recipeNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeNameLabel.Location = new System.Drawing.Point(658, 17);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(165, 23);
            this.recipeNameLabel.TabIndex = 9;
            this.recipeNameLabel.Text = "Название рецепта";
            // 
            // recipeDataGridView
            // 
            this.recipeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.recipeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipeDataGridView.Location = new System.Drawing.Point(2, 72);
            this.recipeDataGridView.Name = "recipeDataGridView";
            this.recipeDataGridView.ReadOnly = true;
            this.recipeDataGridView.Size = new System.Drawing.Size(650, 231);
            this.recipeDataGridView.TabIndex = 8;
            this.recipeDataGridView.Click += new System.EventHandler(this.recipeDataGridView_Click);
            // 
            // recipeSearchLabel
            // 
            this.recipeSearchLabel.AutoSize = true;
            this.recipeSearchLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeSearchLabel.Location = new System.Drawing.Point(160, 8);
            this.recipeSearchLabel.Name = "recipeSearchLabel";
            this.recipeSearchLabel.Size = new System.Drawing.Size(256, 23);
            this.recipeSearchLabel.TabIndex = 16;
            this.recipeSearchLabel.Text = "Поиск по названию рецепта";
            // 
            // recipeSearchTextBox
            // 
            this.recipeSearchTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeSearchTextBox.Location = new System.Drawing.Point(132, 34);
            this.recipeSearchTextBox.MaxLength = 100;
            this.recipeSearchTextBox.Name = "recipeSearchTextBox";
            this.recipeSearchTextBox.Size = new System.Drawing.Size(311, 32);
            this.recipeSearchTextBox.TabIndex = 7;
            // 
            // recipeSearchButton
            // 
            this.recipeSearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("recipeSearchButton.BackgroundImage")));
            this.recipeSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.recipeSearchButton.Location = new System.Drawing.Point(449, 34);
            this.recipeSearchButton.Name = "recipeSearchButton";
            this.recipeSearchButton.Size = new System.Drawing.Size(52, 32);
            this.recipeSearchButton.TabIndex = 8;
            this.recipeSearchButton.UseVisualStyleBackColor = true;
            this.recipeSearchButton.Click += new System.EventHandler(this.recipeSearchButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1025, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLabel.Location = new System.Drawing.Point(658, 88);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(185, 23);
            this.quantityLabel.TabIndex = 85;
            this.quantityLabel.Text = "Количество порций";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityTextBox.Location = new System.Drawing.Point(849, 85);
            this.quantityTextBox.MaxLength = 3;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(170, 32);
            this.quantityTextBox.TabIndex = 3;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.implementingNumberInput);
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hourLabel.Location = new System.Drawing.Point(975, 47);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(50, 23);
            this.hourLabel.TabIndex = 129;
            this.hourLabel.Text = "мин.";
            // 
            // inputRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 310);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.recipeSearchButton);
            this.Controls.Add(this.recipeSearchTextBox);
            this.Controls.Add(this.recipeSearchLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.changeRecipeButton);
            this.Controls.Add(this.addRecipeButton);
            this.Controls.Add(this.cookingTimeTextBox);
            this.Controls.Add(this.recipeNameTextBox);
            this.Controls.Add(this.cookingTimeLabel);
            this.Controls.Add(this.recipeNameLabel);
            this.Controls.Add(this.recipeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inputRecipe";
            this.Text = "Управление рецептами";
            this.Activated += new System.EventHandler(this.inputRecipe_Activated);
            this.Load += new System.EventHandler(this.inputRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button changeRecipeButton;
        private System.Windows.Forms.Button addRecipeButton;
        private System.Windows.Forms.TextBox cookingTimeTextBox;
        private System.Windows.Forms.TextBox recipeNameTextBox;
        private System.Windows.Forms.Label cookingTimeLabel;
        private System.Windows.Forms.Label recipeNameLabel;
        private System.Windows.Forms.DataGridView recipeDataGridView;
        private System.Windows.Forms.Label recipeSearchLabel;
        private System.Windows.Forms.TextBox recipeSearchTextBox;
        private System.Windows.Forms.Button recipeSearchButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label hourLabel;
    }
}