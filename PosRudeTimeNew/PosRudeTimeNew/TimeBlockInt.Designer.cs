
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
            this.SuspendLayout();
            // 
            // TimeBlockIntLabel
            // 
            this.TimeBlockIntLabel.AutoSize = true;
            this.TimeBlockIntLabel.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeBlockIntLabel.Location = new System.Drawing.Point(420, 30);
            this.TimeBlockIntLabel.Name = "TimeBlockIntLabel";
            this.TimeBlockIntLabel.Size = new System.Drawing.Size(164, 38);
            this.TimeBlockIntLabel.TabIndex = 0;
            this.TimeBlockIntLabel.Text = "Time Block";
            // 
            // TimeBlockInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 524);
            this.Controls.Add(this.TimeBlockIntLabel);
            this.Name = "TimeBlockInt";
            this.Text = "Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeBlockIntLabel;
    }
}