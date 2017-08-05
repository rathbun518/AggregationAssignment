namespace AggregationAssignment
{
    partial class frmCourseInfo
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
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.btnViewInstructor = new System.Windows.Forms.Button();
            this.btnViewRoster = new System.Windows.Forms.Button();
            this.grpCourseInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourseNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCourseDescription = new System.Windows.Forms.TextBox();
            this.txtCourseCredits = new System.Windows.Forms.TextBox();
            this.grpCourseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.Location = new System.Drawing.Point(25, 43);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(120, 95);
            this.lstCourses.TabIndex = 0;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // btnViewInstructor
            // 
            this.btnViewInstructor.Location = new System.Drawing.Point(180, 43);
            this.btnViewInstructor.Name = "btnViewInstructor";
            this.btnViewInstructor.Size = new System.Drawing.Size(131, 36);
            this.btnViewInstructor.TabIndex = 1;
            this.btnViewInstructor.Text = "View Instructor";
            this.btnViewInstructor.UseVisualStyleBackColor = true;
            this.btnViewInstructor.Click += new System.EventHandler(this.btnViewInstructor_Click);
            // 
            // btnViewRoster
            // 
            this.btnViewRoster.Location = new System.Drawing.Point(180, 102);
            this.btnViewRoster.Name = "btnViewRoster";
            this.btnViewRoster.Size = new System.Drawing.Size(131, 36);
            this.btnViewRoster.TabIndex = 2;
            this.btnViewRoster.Text = "View Roster";
            this.btnViewRoster.UseVisualStyleBackColor = true;
            this.btnViewRoster.Click += new System.EventHandler(this.btnViewRoster_Click);
            // 
            // grpCourseInfo
            // 
            this.grpCourseInfo.Controls.Add(this.txtCourseCredits);
            this.grpCourseInfo.Controls.Add(this.txtCourseDescription);
            this.grpCourseInfo.Controls.Add(this.label4);
            this.grpCourseInfo.Controls.Add(this.label3);
            this.grpCourseInfo.Controls.Add(this.txtCourseTitle);
            this.grpCourseInfo.Controls.Add(this.label2);
            this.grpCourseInfo.Controls.Add(this.txtCourseNumber);
            this.grpCourseInfo.Controls.Add(this.label1);
            this.grpCourseInfo.Location = new System.Drawing.Point(25, 157);
            this.grpCourseInfo.Name = "grpCourseInfo";
            this.grpCourseInfo.Size = new System.Drawing.Size(286, 151);
            this.grpCourseInfo.TabIndex = 3;
            this.grpCourseInfo.TabStop = false;
            this.grpCourseInfo.Text = "Course Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // txtCourseNumber
            // 
            this.txtCourseNumber.Location = new System.Drawing.Point(80, 17);
            this.txtCourseNumber.Name = "txtCourseNumber";
            this.txtCourseNumber.ReadOnly = true;
            this.txtCourseNumber.Size = new System.Drawing.Size(182, 20);
            this.txtCourseNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title:";
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Location = new System.Drawing.Point(80, 49);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.ReadOnly = true;
            this.txtCourseTitle.Size = new System.Drawing.Size(182, 20);
            this.txtCourseTitle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Credits:";
            // 
            // txtCourseDescription
            // 
            this.txtCourseDescription.Location = new System.Drawing.Point(80, 81);
            this.txtCourseDescription.Name = "txtCourseDescription";
            this.txtCourseDescription.ReadOnly = true;
            this.txtCourseDescription.Size = new System.Drawing.Size(182, 20);
            this.txtCourseDescription.TabIndex = 6;
            // 
            // txtCourseCredits
            // 
            this.txtCourseCredits.Location = new System.Drawing.Point(80, 113);
            this.txtCourseCredits.Name = "txtCourseCredits";
            this.txtCourseCredits.ReadOnly = true;
            this.txtCourseCredits.Size = new System.Drawing.Size(182, 20);
            this.txtCourseCredits.TabIndex = 7;
            // 
            // frmCourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 320);
            this.Controls.Add(this.grpCourseInfo);
            this.Controls.Add(this.btnViewRoster);
            this.Controls.Add(this.btnViewInstructor);
            this.Controls.Add(this.lstCourses);
            this.Name = "frmCourseInfo";
            this.Text = "Course Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCourseInfo.ResumeLayout(false);
            this.grpCourseInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Button btnViewInstructor;
        private System.Windows.Forms.Button btnViewRoster;
        private System.Windows.Forms.GroupBox grpCourseInfo;
        private System.Windows.Forms.TextBox txtCourseCredits;
        private System.Windows.Forms.TextBox txtCourseDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCourseNumber;
        private System.Windows.Forms.Label label1;
    }
}

