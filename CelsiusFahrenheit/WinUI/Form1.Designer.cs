
namespace WinUI
{
    partial class Form1
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
            this.temperatureListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // temperatureListBox
            // 
            this.temperatureListBox.FormattingEnabled = true;
            this.temperatureListBox.Location = new System.Drawing.Point(12, 12);
            this.temperatureListBox.Name = "temperatureListBox";
            this.temperatureListBox.Size = new System.Drawing.Size(447, 368);
            this.temperatureListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 395);
            this.Controls.Add(this.temperatureListBox);
            this.Name = "Form1";
            this.Text = "Celsius to Farenheight";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox temperatureListBox;
    }
}

