namespace Accredition_Assessment_Tracker
{
    partial class Dashboard
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
            this.GoToCoursesbtn = new System.Windows.Forms.Button();
            this.GoToAssessmentsbtn = new System.Windows.Forms.Button();
            this.GoToProgramsbtn = new System.Windows.Forms.Button();
            this.settingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to USM Assessment Tracker";
            // 
            // GoToCoursesbtn
            // 
            this.GoToCoursesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToCoursesbtn.Location = new System.Drawing.Point(109, 82);
            this.GoToCoursesbtn.Name = "GoToCoursesbtn";
            this.GoToCoursesbtn.Size = new System.Drawing.Size(152, 39);
            this.GoToCoursesbtn.TabIndex = 1;
            this.GoToCoursesbtn.Text = "Courses";
            this.GoToCoursesbtn.UseVisualStyleBackColor = true;
            this.GoToCoursesbtn.Click += new System.EventHandler(this.GoToCoursesbtn_Click);
            // 
            // GoToAssessmentsbtn
            // 
            this.GoToAssessmentsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToAssessmentsbtn.Location = new System.Drawing.Point(209, 166);
            this.GoToAssessmentsbtn.Name = "GoToAssessmentsbtn";
            this.GoToAssessmentsbtn.Size = new System.Drawing.Size(152, 39);
            this.GoToAssessmentsbtn.TabIndex = 3;
            this.GoToAssessmentsbtn.Text = "Assessments";
            this.GoToAssessmentsbtn.UseVisualStyleBackColor = true;
            this.GoToAssessmentsbtn.Click += new System.EventHandler(this.GoToAssessmentsbtn_Click);
            // 
            // GoToProgramsbtn
            // 
            this.GoToProgramsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToProgramsbtn.Location = new System.Drawing.Point(316, 82);
            this.GoToProgramsbtn.Name = "GoToProgramsbtn";
            this.GoToProgramsbtn.Size = new System.Drawing.Size(152, 39);
            this.GoToProgramsbtn.TabIndex = 4;
            this.GoToProgramsbtn.Text = "Programs";
            this.GoToProgramsbtn.UseVisualStyleBackColor = true;
            this.GoToProgramsbtn.Click += new System.EventHandler(this.GoToProgramsbtn_Click);
            // 
            // settingBtn
            // 
            this.settingBtn.Location = new System.Drawing.Point(247, 247);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(75, 23);
            this.settingBtn.TabIndex = 5;
            this.settingBtn.Text = "Settings";
            this.settingBtn.UseVisualStyleBackColor = true;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 282);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.GoToProgramsbtn);
            this.Controls.Add(this.GoToAssessmentsbtn);
            this.Controls.Add(this.GoToCoursesbtn);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GoToCoursesbtn;
        private System.Windows.Forms.Button GoToAssessmentsbtn;
        private System.Windows.Forms.Button GoToProgramsbtn;
        private System.Windows.Forms.Button settingBtn;
    }
}

