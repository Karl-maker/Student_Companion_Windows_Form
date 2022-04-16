namespace StudentCompanion
{
    partial class ViewCourses
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
            this.courseList = new System.Windows.Forms.ComboBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Course";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // courseList
            // 
            this.courseList.FormattingEnabled = true;
            this.courseList.Location = new System.Drawing.Point(267, 106);
            this.courseList.Name = "courseList";
            this.courseList.Size = new System.Drawing.Size(454, 39);
            this.courseList.TabIndex = 2;
            this.courseList.SelectedIndexChanged += new System.EventHandler(this.semesterList_SelectedIndexChanged);
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(44, 226);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(0, 32);
            this.codeLabel.TabIndex = 4;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(44, 335);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(0, 32);
            this.descriptionLabel.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(44, 279);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 32);
            this.nameLabel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Amount of Credits:";
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Location = new System.Drawing.Point(305, 400);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(0, 32);
            this.creditsLabel.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Final Grade:";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(695, 400);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(0, 32);
            this.gradeLabel.TabIndex = 10;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(44, 547);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(245, 95);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteButton.Location = new System.Drawing.Point(1144, 547);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(245, 95);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ViewCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 682);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseList);
            this.Name = "ViewCourses";
            this.Text = "ViewCourses";
            this.Load += new System.EventHandler(this.ViewCourses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox courseList;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteButton;
    }
}