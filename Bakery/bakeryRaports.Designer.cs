namespace Bakery
{
    partial class bakeryRaports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bakeryRaports));
            this.dateStartLabel = new System.Windows.Forms.Label();
            this.dateEndLabel = new System.Windows.Forms.Label();
            this.dateStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.printButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateStartLabel
            // 
            this.dateStartLabel.AutoSize = true;
            this.dateStartLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartLabel.Location = new System.Drawing.Point(12, 9);
            this.dateStartLabel.Name = "dateStartLabel";
            this.dateStartLabel.Size = new System.Drawing.Size(24, 23);
            this.dateStartLabel.TabIndex = 1;
            this.dateStartLabel.Text = "С";
            // 
            // dateEndLabel
            // 
            this.dateEndLabel.AutoSize = true;
            this.dateEndLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEndLabel.Location = new System.Drawing.Point(12, 45);
            this.dateEndLabel.Name = "dateEndLabel";
            this.dateEndLabel.Size = new System.Drawing.Size(36, 23);
            this.dateEndLabel.TabIndex = 2;
            this.dateEndLabel.Text = "По";
            // 
            // dateStartDateTimePicker
            // 
            this.dateStartDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStartDateTimePicker.Location = new System.Drawing.Point(54, 5);
            this.dateStartDateTimePicker.Name = "dateStartDateTimePicker";
            this.dateStartDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.dateStartDateTimePicker.TabIndex = 3;
            // 
            // dateEndDateTimePicker
            // 
            this.dateEndDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEndDateTimePicker.Location = new System.Drawing.Point(54, 41);
            this.dateEndDateTimePicker.Name = "dateEndDateTimePicker";
            this.dateEndDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.dateEndDateTimePicker.TabIndex = 4;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Продано",
            "Списано",
            "Реализуется"});
            this.statusComboBox.Location = new System.Drawing.Point(285, 5);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(200, 29);
            this.statusComboBox.TabIndex = 5;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printButton.Location = new System.Drawing.Point(285, 40);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(200, 31);
            this.printButton.TabIndex = 6;
            this.printButton.Text = "Печать";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // bakeryRaports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 76);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.dateEndDateTimePicker);
            this.Controls.Add(this.dateStartDateTimePicker);
            this.Controls.Add(this.dateEndLabel);
            this.Controls.Add(this.dateStartLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bakeryRaports";
            this.Text = "Отчеты по выпечке";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateStartLabel;
        private System.Windows.Forms.Label dateEndLabel;
        private System.Windows.Forms.DateTimePicker dateStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateEndDateTimePicker;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button printButton;
    }
}