namespace StudentCompanion
{
    partial class CreateCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.courseCodeInput = new System.Windows.Forms.TextBox();
            this.courseNameInput = new System.Windows.Forms.TextBox();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.gradeInput = new System.Windows.Forms.TextBox();
            this.creditsInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.creditsInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Credits:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grade:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelButton.Location = new System.Drawing.Point(53, 553);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(283, 132);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(706, 553);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(283, 132);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // courseCodeInput
            // 
            this.courseCodeInput.Location = new System.Drawing.Point(253, 104);
            this.courseCodeInput.Name = "courseCodeInput";
            this.courseCodeInput.Size = new System.Drawing.Size(237, 38);
            this.courseCodeInput.TabIndex = 7;
            this.courseCodeInput.TextChanged += new System.EventHandler(this.courseCodeInput_TextChanged);
            // 
            // courseNameInput
            // 
            this.courseNameInput.Location = new System.Drawing.Point(253, 186);
            this.courseNameInput.Name = "courseNameInput";
            this.courseNameInput.Size = new System.Drawing.Size(380, 38);
            this.courseNameInput.TabIndex = 8;
            this.courseNameInput.TextChanged += new System.EventHandler(this.courseNameInput_TextChanged);
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(253, 264);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(736, 38);
            this.descriptionInput.TabIndex = 9;
            this.descriptionInput.TextChanged += new System.EventHandler(this.descriptionInput_TextChanged);
            // 
            // gradeInput
            // 
            this.gradeInput.Location = new System.Drawing.Point(253, 417);
            this.gradeInput.Name = "gradeInput";
            this.gradeInput.Size = new System.Drawing.Size(83, 38);
            this.gradeInput.TabIndex = 11;
            this.gradeInput.TextChanged += new System.EventHandler(this.gradeInput_TextChanged);
            // 
            // creditsInput
            // 
            this.creditsInput.Location = new System.Drawing.Point(253, 339);
            this.creditsInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.creditsInput.Name = "creditsInput";
            this.creditsInput.Size = new System.Drawing.Size(120, 38);
            this.creditsInput.TabIndex = 12;
            this.creditsInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.creditsInput.ValueChanged += new System.EventHandler(this.creditsInput_ValueChanged);
            // 
            // CreateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 724);
            this.Controls.Add(this.creditsInput);
            this.Controls.Add(this.gradeInput);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.courseNameInput);
            this.Controls.Add(this.courseCodeInput);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateCourse";
            this.Text = "CreateCourse";
            this.Load += new System.EventHandler(this.CreateCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.creditsInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox courseCodeInput;
        private System.Windows.Forms.TextBox courseNameInput;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.TextBox gradeInput;
        private System.Windows.Forms.NumericUpDown creditsInput;
    }
}