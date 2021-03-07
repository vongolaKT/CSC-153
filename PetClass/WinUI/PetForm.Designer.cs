
namespace WinUI
{
    partial class PetForm
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
            this.createButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(32, 357);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(127, 59);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(427, 357);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(136, 59);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "Display Last Pet";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(626, 357);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 59);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(175, 72);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(135, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Enter the name of your pet:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(175, 150);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(160, 13);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.Text = "Enter type of pet (Dog, Cat etc.):";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(176, 238);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(127, 13);
            this.ageLabel.TabIndex = 5;
            this.ageLabel.Text = "Enter the age of your pet:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(392, 69);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(211, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(392, 147);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(211, 20);
            this.typeTextBox.TabIndex = 7;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(392, 235);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(211, 20);
            this.ageTextBox.TabIndex = 8;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(221, 357);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(136, 59);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // PetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.createButton);
            this.Name = "PetForm";
            this.Text = "Pets";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Button clearButton;
    }
}

