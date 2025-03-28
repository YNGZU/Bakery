namespace Bakery
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technologocalCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bakeryProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientsAreAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bakeryRatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bakeryRaportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directoryToolStripMenuItem,
            this.technologocalCardToolStripMenuItem,
            this.bakeryProductsToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(18, 2, 2, 2);
            this.menuStrip.Size = new System.Drawing.Size(874, 35);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recipeToolStripMenuItem,
            this.ingredientToolStripMenuItem});
            this.directoryToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Size = new System.Drawing.Size(161, 31);
            this.directoryToolStripMenuItem.Text = "Справочники";
            // 
            // recipeToolStripMenuItem
            // 
            this.recipeToolStripMenuItem.Name = "recipeToolStripMenuItem";
            this.recipeToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.recipeToolStripMenuItem.Text = "Рецепты";
            this.recipeToolStripMenuItem.Click += new System.EventHandler(this.recipeToolStripMenuItem_Click);
            // 
            // ingredientToolStripMenuItem
            // 
            this.ingredientToolStripMenuItem.Name = "ingredientToolStripMenuItem";
            this.ingredientToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.ingredientToolStripMenuItem.Text = "Ингредиенты";
            this.ingredientToolStripMenuItem.Click += new System.EventHandler(this.ingredientToolStripMenuItem_Click);
            // 
            // technologocalCardToolStripMenuItem
            // 
            this.technologocalCardToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.technologocalCardToolStripMenuItem.Name = "technologocalCardToolStripMenuItem";
            this.technologocalCardToolStripMenuItem.Size = new System.Drawing.Size(263, 31);
            this.technologocalCardToolStripMenuItem.Text = "Технологическая карта";
            this.technologocalCardToolStripMenuItem.Click += new System.EventHandler(this.technologocalCardToolStripMenuItem_Click);
            // 
            // bakeryProductsToolStripMenuItem
            // 
            this.bakeryProductsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bakeryProductsToolStripMenuItem.Name = "bakeryProductsToolStripMenuItem";
            this.bakeryProductsToolStripMenuItem.Size = new System.Drawing.Size(114, 31);
            this.bakeryProductsToolStripMenuItem.Text = "Выпечка";
            this.bakeryProductsToolStripMenuItem.Click += new System.EventHandler(this.bakeryProductsToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingredientsAreAvailableToolStripMenuItem,
            this.bakeryRatingToolStripMenuItem,
            this.bakeryRaportsToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(100, 31);
            this.reportToolStripMenuItem.Text = "Отчеты";
            // 
            // ingredientsAreAvailableToolStripMenuItem
            // 
            this.ingredientsAreAvailableToolStripMenuItem.Name = "ingredientsAreAvailableToolStripMenuItem";
            this.ingredientsAreAvailableToolStripMenuItem.Size = new System.Drawing.Size(332, 32);
            this.ingredientsAreAvailableToolStripMenuItem.Text = "Ингредиенты в наличии";
            this.ingredientsAreAvailableToolStripMenuItem.Click += new System.EventHandler(this.ingredientsAreAvailableToolStripMenuItem_Click);
            // 
            // bakeryRatingToolStripMenuItem
            // 
            this.bakeryRatingToolStripMenuItem.Name = "bakeryRatingToolStripMenuItem";
            this.bakeryRatingToolStripMenuItem.Size = new System.Drawing.Size(332, 32);
            this.bakeryRatingToolStripMenuItem.Text = "Рейтинг выпечки";
            this.bakeryRatingToolStripMenuItem.Click += new System.EventHandler(this.bakeryRatingToolStripMenuItem_Click);
            // 
            // bakeryRaportsToolStripMenuItem
            // 
            this.bakeryRaportsToolStripMenuItem.Name = "bakeryRaportsToolStripMenuItem";
            this.bakeryRaportsToolStripMenuItem.Size = new System.Drawing.Size(332, 32);
            this.bakeryRaportsToolStripMenuItem.Text = "Отчеты по выпечке";
            this.bakeryRaportsToolStripMenuItem.Click += new System.EventHandler(this.bakeryRaportsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(110, 31);
            this.helpToolStripMenuItem.Text = "Справка";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(90, 31);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "main";
            this.Text = "Пекарня";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientsAreAvailableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bakeryRatingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technologocalCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bakeryProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bakeryRaportsToolStripMenuItem;
    }
}

