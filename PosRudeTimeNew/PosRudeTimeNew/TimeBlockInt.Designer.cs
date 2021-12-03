
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
            this.EventTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EventTitle
            // 
            this.EventTitle.AccessibleDescription = "The event form is open, you can edit or view your event";
            this.EventTitle.AccessibleName = "eventForm";
            this.EventTitle.AutoSize = true;
            this.EventTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventTitle.ForeColor = System.Drawing.Color.Black;
            this.EventTitle.Location = new System.Drawing.Point(181, 9);
            this.EventTitle.Name = "EventTitle";
            this.EventTitle.Size = new System.Drawing.Size(131, 46);
            this.EventTitle.TabIndex = 0;
            this.EventTitle.Text = "Event";
            this.EventTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EventTitle.Click += new System.EventHandler(this.EventTitle_Click);
            // 
            // TimeBlockInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 465);
            this.Controls.Add(this.EventTitle);
            this.Name = "TimeBlockInt";
            this.Text = "Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EventTitle;
    }
}