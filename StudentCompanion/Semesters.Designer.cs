namespace StudentCompanion
{
    partial class Semesters
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
            this.semesterList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.viewCourseButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // semesterList
            // 
            this.semesterList.FormattingEnabled = true;
            this.semesterList.Location = new System.Drawing.Point(279, 158);
            this.semesterList.Name = "semesterList";
            this.semesterList.Size = new System.Drawing.Size(835, 39);
            this.semesterList.TabIndex = 0;
            this.semesterList.SelectedIndexChanged += new System.EventHandler(this.semesterList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Semester";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(135, 294);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(133, 32);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "start date";
            this.startDateLabel.Click += new System.EventHandler(this.startDateLabel_Click);
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(988, 294);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(126, 32);
            this.endDateLabel.TabIndex = 3;
            this.endDateLabel.Text = "end date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(935, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "to:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "from:";
            // 
            // addCourseButton
            // 
            this.addCourseButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.addCourseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addCourseButton.Location = new System.Drawing.Point(32, 801);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(303, 147);
            this.addCourseButton.TabIndex = 6;
            this.addCourseButton.Text = "Add Course";
            this.addCourseButton.UseVisualStyleBackColor = false;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // viewCourseButton
            // 
            this.viewCourseButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.viewCourseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewCourseButton.Location = new System.Drawing.Point(390, 801);
            this.viewCourseButton.Name = "viewCourseButton";
            this.viewCourseButton.Size = new System.Drawing.Size(303, 147);
            this.viewCourseButton.TabIndex = 7;
            this.viewCourseButton.Text = "View Courses";
            this.viewCourseButton.UseVisualStyleBackColor = false;
            this.viewCourseButton.Click += new System.EventHandler(this.viewCourseButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(1296, 801);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(303, 147);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete Semester";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Semesters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 1004);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.viewCourseButton);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.semesterList);
            this.Name = "Semesters";
            this.Text = "Semesters";
            this.Load += new System.EventHandler(this.Semesters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox semesterList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Button viewCourseButton;
        private System.Windows.Forms.Button deleteButton;
    }
}