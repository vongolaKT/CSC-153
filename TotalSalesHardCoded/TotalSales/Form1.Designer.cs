
namespace TotalSales
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
            this.SalesNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SalesNumbers
            // 
            this.SalesNumbers.FormattingEnabled = true;
            this.SalesNumbers.Location = new System.Drawing.Point(12, 10);
            this.SalesNumbers.Name = "SalesNumbers";
            this.SalesNumbers.Size = new System.Drawing.Size(149, 160);
            this.SalesNumbers.TabIndex = 0;
            this.SalesNumbers.SelectedIndexChanged += new System.EventHandler(this.SalesNumbers_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 186);
            this.Controls.Add(this.SalesNumbers);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SalesNumbers;
    }
}

