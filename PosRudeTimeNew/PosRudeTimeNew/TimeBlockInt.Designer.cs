using System;
using System.Windows.Forms;

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
            this.EnterStartDate = new System.Windows.Forms.DateTimePicker();
            this.EnterEndDate = new System.Windows.Forms.DateTimePicker();
            this.StartTime = new System.Windows.Forms.Label();
            this.EnterStart = new System.Windows.Forms.DateTimePicker();
            this.EndTime = new System.Windows.Forms.Label();
            this.EnterEnd = new System.Windows.Forms.DateTimePicker();
            this.Description = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Location = new System.Windows.Forms.Label();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeBlockIntLabel
            // 
            this.TimeBlockIntLabel.AutoSize = true;
            this.TimeBlockIntLabel.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeBlockIntLabel.Location = new System.Drawing.Point(427, 36);
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
            // EnterStartDate
            // 
            this.EnterStartDate.Font = new System.Drawing.Font("Yu Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterStartDate.Location = new System.Drawing.Point(140, 140);
            this.EnterStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterStartDate.Name = "EnterStartDate";
            this.EnterStartDate.Size = new System.Drawing.Size(241, 28);
            this.EnterStartDate.TabIndex = 3;
            // 
            // EnterEndDate
            // 
            this.EnterEndDate.Font = new System.Drawing.Font("Yu Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.EnterEndDate.Location = new System.Drawing.Point(643, 140);
            this.EnterEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterEndDate.Name = "EnterEndDate";
            this.EnterEndDate.Size = new System.Drawing.Size(252, 28);
            this.EnterEndDate.TabIndex = 4;
            // 
            // StartTime
            // 
            this.StartTime.AutoSize = true;
            this.StartTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTime.Location = new System.Drawing.Point(460, 194);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(104, 24);
            this.StartTime.TabIndex = 5;
            this.StartTime.Text = "Start Time";
            // 
            // EnterStart
            // 
            this.EnterStart.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EnterStart.Location = new System.Drawing.Point(464, 235);
            this.EnterStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterStart.Name = "EnterStart";
            this.EnterStart.ShowUpDown = true;
            this.EnterStart.Size = new System.Drawing.Size(107, 28);
            this.EnterStart.TabIndex = 6;
            // 
            // EndTime
            // 
            this.EndTime.AutoSize = true;
            this.EndTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline);
            this.EndTime.Location = new System.Drawing.Point(460, 281);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(94, 24);
            this.EndTime.TabIndex = 7;
            this.EndTime.Text = "End Time";
            // 
            // EnterEnd
            // 
            this.EnterEnd.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.EnterEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EnterEnd.Location = new System.Drawing.Point(464, 322);
            this.EnterEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterEnd.Name = "EnterEnd";
            this.EnterEnd.ShowUpDown = true;
            this.EnterEnd.Size = new System.Drawing.Size(107, 28);
            this.EnterEnd.TabIndex = 8;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline);
            this.Description.Location = new System.Drawing.Point(35, 194);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(110, 24);
            this.Description.TabIndex = 9;
            this.Description.Text = "Description";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(37, 235);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(376, 223);
            this.DescriptionTextBox.TabIndex = 10;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(755, 474);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(81, 27);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.Add.Location = new System.Drawing.Point(857, 474);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 27);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline);
            this.Location.Location = new System.Drawing.Point(637, 194);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(85, 24);
            this.Location.TabIndex = 13;
            this.Location.Text = "Location";
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(643, 235);
            this.LocationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocationTextBox.Multiline = true;
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(276, 70);
            this.LocationTextBox.TabIndex = 14;
            // 
            // Previous
            // 
            this.Previous.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.Previous.Location = new System.Drawing.Point(37, 474);
            this.Previous.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(83, 27);
            this.Previous.TabIndex = 15;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = true;
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.Next.Location = new System.Drawing.Point(140, 474);
            this.Next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 27);
            this.Next.TabIndex = 16;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            // 
            // TimeBlockInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(971, 524);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.EnterEnd);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.EnterStart);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.EnterEndDate);
            this.Controls.Add(this.EnterStartDate);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.TimeBlockIntLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TimeBlockInt";
            this.Text = "Event";
            this.Load += new System.EventHandler(this.TimeBlockInt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeBlockIntLabel;
        private System.Windows.Forms.Label StartDate;
        private System.Windows.Forms.Label EndDate;
        private System.Windows.Forms.DateTimePicker EnterStartDate;
        private System.Windows.Forms.DateTimePicker EnterEndDate;
        private System.Windows.Forms.Label StartTime;
        private System.Windows.Forms.DateTimePicker EnterStart;
        private System.Windows.Forms.Label EndTime;
        private System.Windows.Forms.DateTimePicker EnterEnd;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Next;
    }
}