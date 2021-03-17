
namespace WinUI
{
    partial class EmployeeClassForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.DisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.displayPositionBottomLabel = new System.Windows.Forms.Label();
            this.displayDepartmentBottomLabel = new System.Windows.Forms.Label();
            this.displayIDBottomLabel = new System.Windows.Forms.Label();
            this.displayNameBottomLabel = new System.Windows.Forms.Label();
            this.displayPositionMiddleLabel = new System.Windows.Forms.Label();
            this.displayDepartmentMiddleLabel = new System.Windows.Forms.Label();
            this.displayIDMiddleLabel = new System.Windows.Forms.Label();
            this.displayNameMiddleLabel = new System.Windows.Forms.Label();
            this.displayPositionTopLabel = new System.Windows.Forms.Label();
            this.displayDepartmentTopLabel = new System.Windows.Forms.Label();
            this.displayIDTopLabel = new System.Windows.Forms.Label();
            this.displayNameTopLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.PositionInputTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentInputTextBox = new System.Windows.Forms.TextBox();
            this.iDNumberInputTextBox = new System.Windows.Forms.TextBox();
            this.nameInputTextBox = new System.Windows.Forms.TextBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.IDNumberLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DisplayGroupBox.SuspendLayout();
            this.InputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(190, 221);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 32);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // DisplayGroupBox
            // 
            this.DisplayGroupBox.Controls.Add(this.displayPositionBottomLabel);
            this.DisplayGroupBox.Controls.Add(this.displayDepartmentBottomLabel);
            this.DisplayGroupBox.Controls.Add(this.displayIDBottomLabel);
            this.DisplayGroupBox.Controls.Add(this.displayNameBottomLabel);
            this.DisplayGroupBox.Controls.Add(this.displayPositionMiddleLabel);
            this.DisplayGroupBox.Controls.Add(this.displayDepartmentMiddleLabel);
            this.DisplayGroupBox.Controls.Add(this.displayIDMiddleLabel);
            this.DisplayGroupBox.Controls.Add(this.displayNameMiddleLabel);
            this.DisplayGroupBox.Controls.Add(this.displayPositionTopLabel);
            this.DisplayGroupBox.Controls.Add(this.displayDepartmentTopLabel);
            this.DisplayGroupBox.Controls.Add(this.displayIDTopLabel);
            this.DisplayGroupBox.Controls.Add(this.displayNameTopLabel);
            this.DisplayGroupBox.Controls.Add(this.label4);
            this.DisplayGroupBox.Controls.Add(this.label3);
            this.DisplayGroupBox.Controls.Add(this.label2);
            this.DisplayGroupBox.Controls.Add(this.label1);
            this.DisplayGroupBox.Location = new System.Drawing.Point(12, 259);
            this.DisplayGroupBox.Name = "DisplayGroupBox";
            this.DisplayGroupBox.Size = new System.Drawing.Size(446, 235);
            this.DisplayGroupBox.TabIndex = 1;
            this.DisplayGroupBox.TabStop = false;
            this.DisplayGroupBox.Text = "Employees:";
            // 
            // displayPositionBottomLabel
            // 
            this.displayPositionBottomLabel.AutoSize = true;
            this.displayPositionBottomLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPositionBottomLabel.Location = new System.Drawing.Point(358, 189);
            this.displayPositionBottomLabel.Name = "displayPositionBottomLabel";
            this.displayPositionBottomLabel.Size = new System.Drawing.Size(33, 15);
            this.displayPositionBottomLabel.TabIndex = 15;
            this.displayPositionBottomLabel.Text = "--------";
            // 
            // displayDepartmentBottomLabel
            // 
            this.displayDepartmentBottomLabel.AutoSize = true;
            this.displayDepartmentBottomLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayDepartmentBottomLabel.Location = new System.Drawing.Point(251, 189);
            this.displayDepartmentBottomLabel.Name = "displayDepartmentBottomLabel";
            this.displayDepartmentBottomLabel.Size = new System.Drawing.Size(33, 15);
            this.displayDepartmentBottomLabel.TabIndex = 14;
            this.displayDepartmentBottomLabel.Text = "--------";
            // 
            // displayIDBottomLabel
            // 
            this.displayIDBottomLabel.AutoSize = true;
            this.displayIDBottomLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayIDBottomLabel.Location = new System.Drawing.Point(144, 189);
            this.displayIDBottomLabel.Name = "displayIDBottomLabel";
            this.displayIDBottomLabel.Size = new System.Drawing.Size(33, 15);
            this.displayIDBottomLabel.TabIndex = 13;
            this.displayIDBottomLabel.Text = "--------";
            // 
            // displayNameBottomLabel
            // 
            this.displayNameBottomLabel.AutoSize = true;
            this.displayNameBottomLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayNameBottomLabel.Location = new System.Drawing.Point(36, 189);
            this.displayNameBottomLabel.Name = "displayNameBottomLabel";
            this.displayNameBottomLabel.Size = new System.Drawing.Size(33, 15);
            this.displayNameBottomLabel.TabIndex = 12;
            this.displayNameBottomLabel.Text = "--------";
            // 
            // displayPositionMiddleLabel
            // 
            this.displayPositionMiddleLabel.AutoSize = true;
            this.displayPositionMiddleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPositionMiddleLabel.Location = new System.Drawing.Point(358, 138);
            this.displayPositionMiddleLabel.Name = "displayPositionMiddleLabel";
            this.displayPositionMiddleLabel.Size = new System.Drawing.Size(33, 15);
            this.displayPositionMiddleLabel.TabIndex = 11;
            this.displayPositionMiddleLabel.Text = "--------";
            // 
            // displayDepartmentMiddleLabel
            // 
            this.displayDepartmentMiddleLabel.AutoSize = true;
            this.displayDepartmentMiddleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayDepartmentMiddleLabel.Location = new System.Drawing.Point(251, 138);
            this.displayDepartmentMiddleLabel.Name = "displayDepartmentMiddleLabel";
            this.displayDepartmentMiddleLabel.Size = new System.Drawing.Size(33, 15);
            this.displayDepartmentMiddleLabel.TabIndex = 10;
            this.displayDepartmentMiddleLabel.Text = "--------";
            // 
            // displayIDMiddleLabel
            // 
            this.displayIDMiddleLabel.AutoSize = true;
            this.displayIDMiddleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayIDMiddleLabel.Location = new System.Drawing.Point(144, 138);
            this.displayIDMiddleLabel.Name = "displayIDMiddleLabel";
            this.displayIDMiddleLabel.Size = new System.Drawing.Size(33, 15);
            this.displayIDMiddleLabel.TabIndex = 9;
            this.displayIDMiddleLabel.Text = "--------";
            // 
            // displayNameMiddleLabel
            // 
            this.displayNameMiddleLabel.AutoSize = true;
            this.displayNameMiddleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayNameMiddleLabel.Location = new System.Drawing.Point(36, 138);
            this.displayNameMiddleLabel.Name = "displayNameMiddleLabel";
            this.displayNameMiddleLabel.Size = new System.Drawing.Size(33, 15);
            this.displayNameMiddleLabel.TabIndex = 8;
            this.displayNameMiddleLabel.Text = "--------";
            // 
            // displayPositionTopLabel
            // 
            this.displayPositionTopLabel.AutoSize = true;
            this.displayPositionTopLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPositionTopLabel.Location = new System.Drawing.Point(358, 82);
            this.displayPositionTopLabel.Name = "displayPositionTopLabel";
            this.displayPositionTopLabel.Size = new System.Drawing.Size(33, 15);
            this.displayPositionTopLabel.TabIndex = 7;
            this.displayPositionTopLabel.Text = "--------";
            // 
            // displayDepartmentTopLabel
            // 
            this.displayDepartmentTopLabel.AutoSize = true;
            this.displayDepartmentTopLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayDepartmentTopLabel.Location = new System.Drawing.Point(251, 82);
            this.displayDepartmentTopLabel.Name = "displayDepartmentTopLabel";
            this.displayDepartmentTopLabel.Size = new System.Drawing.Size(33, 15);
            this.displayDepartmentTopLabel.TabIndex = 6;
            this.displayDepartmentTopLabel.Text = "--------";
            // 
            // displayIDTopLabel
            // 
            this.displayIDTopLabel.AutoSize = true;
            this.displayIDTopLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayIDTopLabel.Location = new System.Drawing.Point(144, 82);
            this.displayIDTopLabel.Name = "displayIDTopLabel";
            this.displayIDTopLabel.Size = new System.Drawing.Size(33, 15);
            this.displayIDTopLabel.TabIndex = 5;
            this.displayIDTopLabel.Text = "--------";
            // 
            // displayNameTopLabel
            // 
            this.displayNameTopLabel.AutoSize = true;
            this.displayNameTopLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayNameTopLabel.Location = new System.Drawing.Point(36, 82);
            this.displayNameTopLabel.Name = "displayNameTopLabel";
            this.displayNameTopLabel.Size = new System.Drawing.Size(33, 15);
            this.displayNameTopLabel.TabIndex = 4;
            this.displayNameTopLabel.Text = "--------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Controls.Add(this.PositionInputTextBox);
            this.InputGroupBox.Controls.Add(this.DepartmentInputTextBox);
            this.InputGroupBox.Controls.Add(this.iDNumberInputTextBox);
            this.InputGroupBox.Controls.Add(this.nameInputTextBox);
            this.InputGroupBox.Controls.Add(this.PositionLabel);
            this.InputGroupBox.Controls.Add(this.DepartmentLabel);
            this.InputGroupBox.Controls.Add(this.IDNumberLabel);
            this.InputGroupBox.Controls.Add(this.NameLabel);
            this.InputGroupBox.Location = new System.Drawing.Point(13, 13);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(445, 202);
            this.InputGroupBox.TabIndex = 2;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "Enter the Following Data";
            // 
            // PositionInputTextBox
            // 
            this.PositionInputTextBox.Location = new System.Drawing.Point(143, 150);
            this.PositionInputTextBox.Name = "PositionInputTextBox";
            this.PositionInputTextBox.Size = new System.Drawing.Size(220, 20);
            this.PositionInputTextBox.TabIndex = 7;
            // 
            // DepartmentInputTextBox
            // 
            this.DepartmentInputTextBox.Location = new System.Drawing.Point(143, 114);
            this.DepartmentInputTextBox.Name = "DepartmentInputTextBox";
            this.DepartmentInputTextBox.Size = new System.Drawing.Size(220, 20);
            this.DepartmentInputTextBox.TabIndex = 6;
            // 
            // iDNumberInputTextBox
            // 
            this.iDNumberInputTextBox.Location = new System.Drawing.Point(143, 75);
            this.iDNumberInputTextBox.Name = "iDNumberInputTextBox";
            this.iDNumberInputTextBox.Size = new System.Drawing.Size(220, 20);
            this.iDNumberInputTextBox.TabIndex = 5;
            // 
            // nameInputTextBox
            // 
            this.nameInputTextBox.Location = new System.Drawing.Point(143, 36);
            this.nameInputTextBox.Name = "nameInputTextBox";
            this.nameInputTextBox.Size = new System.Drawing.Size(220, 20);
            this.nameInputTextBox.TabIndex = 4;
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(74, 153);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(47, 13);
            this.PositionLabel.TabIndex = 3;
            this.PositionLabel.Text = "Position:";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(56, 117);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(65, 13);
            this.DepartmentLabel.TabIndex = 2;
            this.DepartmentLabel.Text = "Department:";
            // 
            // IDNumberLabel
            // 
            this.IDNumberLabel.AutoSize = true;
            this.IDNumberLabel.Location = new System.Drawing.Point(60, 78);
            this.IDNumberLabel.Name = "IDNumberLabel";
            this.IDNumberLabel.Size = new System.Drawing.Size(61, 13);
            this.IDNumberLabel.TabIndex = 1;
            this.IDNumberLabel.Text = "ID Number:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(83, 39);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // EmployeeClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 506);
            this.Controls.Add(this.InputGroupBox);
            this.Controls.Add(this.DisplayGroupBox);
            this.Controls.Add(this.addButton);
            this.Name = "EmployeeClassForm";
            this.Text = "EmployeeClass";
            this.DisplayGroupBox.ResumeLayout(false);
            this.DisplayGroupBox.PerformLayout();
            this.InputGroupBox.ResumeLayout(false);
            this.InputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox DisplayGroupBox;
        private System.Windows.Forms.GroupBox InputGroupBox;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label IDNumberLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox PositionInputTextBox;
        private System.Windows.Forms.TextBox DepartmentInputTextBox;
        private System.Windows.Forms.TextBox iDNumberInputTextBox;
        private System.Windows.Forms.TextBox nameInputTextBox;
        private System.Windows.Forms.Label displayPositionBottomLabel;
        private System.Windows.Forms.Label displayDepartmentBottomLabel;
        private System.Windows.Forms.Label displayIDBottomLabel;
        private System.Windows.Forms.Label displayNameBottomLabel;
        private System.Windows.Forms.Label displayPositionMiddleLabel;
        private System.Windows.Forms.Label displayDepartmentMiddleLabel;
        private System.Windows.Forms.Label displayIDMiddleLabel;
        private System.Windows.Forms.Label displayNameMiddleLabel;
        private System.Windows.Forms.Label displayPositionTopLabel;
        private System.Windows.Forms.Label displayDepartmentTopLabel;
        private System.Windows.Forms.Label displayIDTopLabel;
        private System.Windows.Forms.Label displayNameTopLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

