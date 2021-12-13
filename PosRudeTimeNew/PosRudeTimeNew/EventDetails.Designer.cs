namespace PosRudeTimeNew
{
    partial class EventDetails
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
            this.EventName = new System.Windows.Forms.Label();
            this.EventNameBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.Location = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EventName
            // 
            this.EventName.AutoSize = true;
            this.EventName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline);
            this.EventName.Location = new System.Drawing.Point(12, 9);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(118, 24);
            this.EventName.TabIndex = 28;
            this.EventName.Text = "Event Name";
            // 
            // EventNameBox
            // 
            this.EventNameBox.Location = new System.Drawing.Point(5, 36);
            this.EventNameBox.Name = "EventNameBox";
            this.EventNameBox.ReadOnly = true;
            this.EventNameBox.Size = new System.Drawing.Size(278, 22);
            this.EventNameBox.TabIndex = 27;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(454, 113);
            this.LocationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocationTextBox.Multiline = true;
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.ReadOnly = true;
            this.LocationTextBox.Size = new System.Drawing.Size(276, 70);
            this.LocationTextBox.TabIndex = 26;
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline);
            this.Location.Location = new System.Drawing.Point(450, 77);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(85, 24);
            this.Location.TabIndex = 25;
            this.Location.Text = "Location";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(5, 113);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(376, 223);
            this.DescriptionTextBox.TabIndex = 24;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline);
            this.Description.Location = new System.Drawing.Point(12, 77);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(110, 24);
            this.Description.TabIndex = 23;
            this.Description.Text = "Description";
            // 
            // EventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.EventNameBox);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.Description);
            this.Name = "EventDetails";
            this.Text = "Event Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EventName;
        private System.Windows.Forms.TextBox EventNameBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label Description;
    }
}