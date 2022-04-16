namespace StudentCompanion
{
    partial class CreateSemester
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
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(225, 105);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(498, 38);
            this.startDatePicker.TabIndex = 0;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(225, 184);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(498, 38);
            this.endDatePicker.TabIndex = 1;
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Date";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelButton.Location = new System.Drawing.Point(37, 404);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(292, 95);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(1223, 404);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(292, 95);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // CreateSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 528);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Name = "CreateSemester";
            this.Text = "CreateSemester";
            this.Load += new System.EventHandler(this.CreateSemester_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}