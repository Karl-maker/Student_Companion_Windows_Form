namespace StudentCompanion
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewSemesterLabelLink = new System.Windows.Forms.LinkLabel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.studentEmailLabel = new System.Windows.Forms.Label();
            this.addSemesterLinkLabel = new System.Windows.Forms.LinkLabel();
            this.viewCourseLabelLink = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.viewCourseLabelLink);
            this.panel1.Controls.Add(this.addSemesterLinkLabel);
            this.panel1.Controls.Add(this.headerLabel);
            this.panel1.Controls.Add(this.viewSemesterLabelLink);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 1032);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // viewSemesterLabelLink
            // 
            this.viewSemesterLabelLink.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.viewSemesterLabelLink.AutoSize = true;
            this.viewSemesterLabelLink.LinkColor = System.Drawing.Color.White;
            this.viewSemesterLabelLink.Location = new System.Drawing.Point(41, 217);
            this.viewSemesterLabelLink.Name = "viewSemesterLabelLink";
            this.viewSemesterLabelLink.Size = new System.Drawing.Size(219, 32);
            this.viewSemesterLabelLink.TabIndex = 1;
            this.viewSemesterLabelLink.TabStop = true;
            this.viewSemesterLabelLink.Text = "View Semesters";
            this.viewSemesterLabelLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.headerLabel.Location = new System.Drawing.Point(47, 81);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(267, 32);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Student Companion";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(855, 265);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(114, 32);
            this.studentNameLabel.TabIndex = 1;
            this.studentNameLabel.Text = "Name...";
            this.studentNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // studentEmailLabel
            // 
            this.studentEmailLabel.AutoSize = true;
            this.studentEmailLabel.Location = new System.Drawing.Point(855, 346);
            this.studentEmailLabel.Name = "studentEmailLabel";
            this.studentEmailLabel.Size = new System.Drawing.Size(111, 32);
            this.studentEmailLabel.TabIndex = 2;
            this.studentEmailLabel.Text = "Email...";
            this.studentEmailLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // addSemesterLinkLabel
            // 
            this.addSemesterLinkLabel.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.addSemesterLinkLabel.AutoSize = true;
            this.addSemesterLinkLabel.LinkColor = System.Drawing.Color.White;
            this.addSemesterLinkLabel.Location = new System.Drawing.Point(41, 277);
            this.addSemesterLinkLabel.Name = "addSemesterLinkLabel";
            this.addSemesterLinkLabel.Size = new System.Drawing.Size(208, 32);
            this.addSemesterLinkLabel.TabIndex = 3;
            this.addSemesterLinkLabel.TabStop = true;
            this.addSemesterLinkLabel.Text = "Add Semesters";
            this.addSemesterLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addSemesterLinkLabel_LinkClicked);
            // 
            // viewCourseLabelLink
            // 
            this.viewCourseLabelLink.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.viewCourseLabelLink.AutoSize = true;
            this.viewCourseLabelLink.LinkColor = System.Drawing.Color.White;
            this.viewCourseLabelLink.Location = new System.Drawing.Point(47, 347);
            this.viewCourseLabelLink.Name = "viewCourseLabelLink";
            this.viewCourseLabelLink.Size = new System.Drawing.Size(189, 32);
            this.viewCourseLabelLink.TabIndex = 4;
            this.viewCourseLabelLink.TabStop = true;
            this.viewCourseLabelLink.Text = "View Courses";
            this.viewCourseLabelLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewCourseLabelLink_LinkClicked);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 1030);
            this.Controls.Add(this.studentEmailLabel);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel viewSemesterLabelLink;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label studentEmailLabel;
        private System.Windows.Forms.LinkLabel viewCourseLabelLink;
        private System.Windows.Forms.LinkLabel addSemesterLinkLabel;
    }
}