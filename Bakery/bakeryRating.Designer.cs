namespace Bakery
{
    partial class bakeryRating
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bakeryRating));
            this.ratingBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.endingDateLabel = new System.Windows.Forms.Label();
            this.createRatingButton = new System.Windows.Forms.Button();
            this.startingDateLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ratingBar
            // 
            this.ratingBar.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.ratingBar.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingBar.Legends.Add(legend1);
            this.ratingBar.Location = new System.Drawing.Point(38, 69);
            this.ratingBar.Name = "ratingBar";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Выпечка";
            this.ratingBar.Series.Add(series1);
            this.ratingBar.Size = new System.Drawing.Size(724, 390);
            this.ratingBar.TabIndex = 136;
            this.ratingBar.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Рейтинг выпечки";
            this.ratingBar.Titles.Add(title1);
            // 
            // endingDateLabel
            // 
            this.endingDateLabel.AutoSize = true;
            this.endingDateLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endingDateLabel.Location = new System.Drawing.Point(35, 37);
            this.endingDateLabel.Name = "endingDateLabel";
            this.endingDateLabel.Size = new System.Drawing.Size(225, 23);
            this.endingDateLabel.TabIndex = 134;
            this.endingDateLabel.Text = "Дата окончания периода";
            // 
            // createRatingButton
            // 
            this.createRatingButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.createRatingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createRatingButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createRatingButton.Location = new System.Drawing.Point(536, 12);
            this.createRatingButton.Name = "createRatingButton";
            this.createRatingButton.Size = new System.Drawing.Size(226, 38);
            this.createRatingButton.TabIndex = 3;
            this.createRatingButton.Text = "Сформировать рейтинг";
            this.createRatingButton.UseVisualStyleBackColor = false;
            this.createRatingButton.Click += new System.EventHandler(this.createRatingButton_Click);
            // 
            // startingDateLabel
            // 
            this.startingDateLabel.AutoSize = true;
            this.startingDateLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startingDateLabel.Location = new System.Drawing.Point(35, 9);
            this.startingDateLabel.Name = "startingDateLabel";
            this.startingDateLabel.Size = new System.Drawing.Size(189, 23);
            this.startingDateLabel.TabIndex = 137;
            this.startingDateLabel.Text = "Дата начала периода";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDateTimePicker.Location = new System.Drawing.Point(277, 6);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.startDateTimePicker.TabIndex = 1;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateTimePicker.Location = new System.Drawing.Point(277, 37);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.endDateTimePicker.TabIndex = 2;
            // 
            // bakeryRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.startingDateLabel);
            this.Controls.Add(this.ratingBar);
            this.Controls.Add(this.endingDateLabel);
            this.Controls.Add(this.createRatingButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bakeryRating";
            this.Text = "Рейтинг выпечки";
            ((System.ComponentModel.ISupportInitialize)(this.ratingBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ratingBar;
        private System.Windows.Forms.Label endingDateLabel;
        private System.Windows.Forms.Button createRatingButton;
        private System.Windows.Forms.Label startingDateLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
    }
}