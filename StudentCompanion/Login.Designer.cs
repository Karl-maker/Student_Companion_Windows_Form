namespace StudentCompanion
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.studentCompanionDataSet1 = new StudentCompanion.StudentCompanionDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new StudentCompanion.StudentCompanionDataSetTableAdapters.StudentsTableAdapter();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.loginLb = new System.Windows.Forms.Label();
            this.StudentCompantionLb = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentCompanionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentCompanionDataSet1
            // 
            this.studentCompanionDataSet1.DataSetName = "StudentCompanionDataSet";
            this.studentCompanionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.studentCompanionDataSet1;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPanel.Controls.Add(this.loginButton);
            this.mainPanel.Controls.Add(this.passwordTextBox);
            this.mainPanel.Controls.Add(this.emailTextBox);
            this.mainPanel.Controls.Add(this.StudentCompantionLb);
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mainPanel.Location = new System.Drawing.Point(198, 191);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1139, 672);
            this.mainPanel.TabIndex = 1;
            // 
            // loginLb
            // 
            this.loginLb.AutoSize = true;
            this.loginLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginLb.Location = new System.Drawing.Point(192, 141);
            this.loginLb.Name = "loginLb";
            this.loginLb.Size = new System.Drawing.Size(86, 32);
            this.loginLb.TabIndex = 0;
            this.loginLb.Text = "Login";
            this.loginLb.Click += new System.EventHandler(this.label2_Click);
            // 
            // StudentCompantionLb
            // 
            this.StudentCompantionLb.AutoSize = true;
            this.StudentCompantionLb.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.StudentCompantionLb.Location = new System.Drawing.Point(432, 52);
            this.StudentCompantionLb.Name = "StudentCompantionLb";
            this.StudentCompantionLb.Size = new System.Drawing.Size(267, 32);
            this.StudentCompantionLb.TabIndex = 0;
            this.StudentCompantionLb.Text = "Student Companion";
            this.StudentCompantionLb.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(412, 217);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(324, 38);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.Text = "Enter Email";
            this.emailTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(412, 297);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(324, 38);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "Enter Password";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(412, 533);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(324, 63);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1543, 1069);
            this.Controls.Add(this.loginLb);
            this.Controls.Add(this.mainPanel);
            this.Name = "Login";
            this.Text = "Student Companion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentCompanionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StudentCompanionDataSet studentCompanionDataSet1;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private StudentCompanionDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label loginLb;
        private System.Windows.Forms.Label StudentCompantionLb;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}

