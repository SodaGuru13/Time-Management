
namespace PosRudeTimeNew
{
    partial class TimeBlockInt
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
            this.TimeBlockIntLabel = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.Label();
            this.StartPicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TimeBlockIntLabel
            // 
            this.TimeBlockIntLabel.AutoSize = true;
            this.TimeBlockIntLabel.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeBlockIntLabel.Location = new System.Drawing.Point(400, 30);
            this.TimeBlockIntLabel.Name = "TimeBlockIntLabel";
            this.TimeBlockIntLabel.Size = new System.Drawing.Size(164, 38);
            this.TimeBlockIntLabel.TabIndex = 0;
            this.TimeBlockIntLabel.Text = "Time Block";
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Location = new System.Drawing.Point(200, 100);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(102, 24);
            this.StartDate.TabIndex = 1;
            this.StartDate.Text = "Start Date";
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.Location = new System.Drawing.Point(700, 100);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(92, 24);
            this.EndDate.TabIndex = 2;
            this.EndDate.Text = "End Date";
            // 
            // StartPicker
            // 
            this.StartPicker.Font = new System.Drawing.Font("Yu Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPicker.Location = new System.Drawing.Point(140, 140);
            this.StartPicker.Name = "StartPicker";
            this.StartPicker.Size = new System.Drawing.Size(241, 28);
            this.StartPicker.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(640, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // TimeBlockInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 524);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.StartPicker);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.TimeBlockIntLabel);
            this.Name = "TimeBlockInt";
            this.Text = "Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeBlockIntLabel;
        private System.Windows.Forms.Label StartDate;
        private System.Windows.Forms.Label EndDate;
        private System.Windows.Forms.DateTimePicker StartPicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}