﻿using System;

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
        private void InitializeComponent(DateTime Start)
        {
            this.SuspendLayout();
            // 
            // TimeBlockInt
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "TimeBlockInt";
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Next;
    }
}