using System.Windows.Forms;
namespace Accredition_Assessment_Tracker
{
    partial class Programs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programs));
            this.Backbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseListGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.facilitiesTextBox = new System.Windows.Forms.TextBox();
            this.facultyTextBox = new System.Windows.Forms.TextBox();
            this.currTextBox = new System.Windows.Forms.TextBox();
            this.numSudentsBox = new System.Windows.Forms.NumericUpDown();
            this.outcomesTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.programDrpDwnBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSudentsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Backbtn
            // 
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(16, 648);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(89, 47);
            this.Backbtn.TabIndex = 1;
            this.Backbtn.Text = "Back To Dashboard";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Program:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course List:";
            // 
            // courseListGrid
            // 
            this.courseListGrid.AllowUserToAddRows = false;
            this.courseListGrid.AllowUserToDeleteRows = false;
            this.courseListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.courseListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3,
            this.colDescription,
            this.colStudentNum});
            this.courseListGrid.Location = new System.Drawing.Point(16, 82);
            this.courseListGrid.Name = "courseListGrid";
            this.courseListGrid.Size = new System.Drawing.Size(806, 199);
            this.courseListGrid.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Course Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 88;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Course Code";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 86;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Credit Hours";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 83;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Pre-reqs";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 71;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Instructor Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 98;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 85;
            // 
            // colStudentNum
            // 
            this.colStudentNum.HeaderText = "Students";
            this.colStudentNum.Name = "colStudentNum";
            this.colStudentNum.Width = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-7, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(853, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "ABET Critieria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-7, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(856, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Facilities:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Faculty:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Curriculum:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Number of Students:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 507);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Students Outcomes:";
            // 
            // facilitiesTextBox
            // 
            this.facilitiesTextBox.Location = new System.Drawing.Point(91, 357);
            this.facilitiesTextBox.Name = "facilitiesTextBox";
            this.facilitiesTextBox.Size = new System.Drawing.Size(248, 20);
            this.facilitiesTextBox.TabIndex = 18;
            // 
            // facultyTextBox
            // 
            this.facultyTextBox.Location = new System.Drawing.Point(82, 395);
            this.facultyTextBox.Name = "facultyTextBox";
            this.facultyTextBox.Size = new System.Drawing.Size(248, 20);
            this.facultyTextBox.TabIndex = 19;
            // 
            // currTextBox
            // 
            this.currTextBox.Location = new System.Drawing.Point(106, 427);
            this.currTextBox.Name = "currTextBox";
            this.currTextBox.Size = new System.Drawing.Size(248, 20);
            this.currTextBox.TabIndex = 20;
            // 
            // numSudentsBox
            // 
            this.numSudentsBox.Location = new System.Drawing.Point(174, 472);
            this.numSudentsBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSudentsBox.Name = "numSudentsBox";
            this.numSudentsBox.Size = new System.Drawing.Size(86, 20);
            this.numSudentsBox.TabIndex = 21;
            // 
            // outcomesTextBox
            // 
            this.outcomesTextBox.Location = new System.Drawing.Point(174, 507);
            this.outcomesTextBox.Multiline = true;
            this.outcomesTextBox.Name = "outcomesTextBox";
            this.outcomesTextBox.Size = new System.Drawing.Size(282, 113);
            this.outcomesTextBox.TabIndex = 22;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(282, 648);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(89, 33);
            this.submitButton.TabIndex = 23;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // programDrpDwnBox
            // 
            this.programDrpDwnBox.FormattingEnabled = true;
            this.programDrpDwnBox.Location = new System.Drawing.Point(91, 8);
            this.programDrpDwnBox.Name = "programDrpDwnBox";
            this.programDrpDwnBox.Size = new System.Drawing.Size(143, 21);
            this.programDrpDwnBox.TabIndex = 25;
            this.programDrpDwnBox.SelectedIndexChanged += new System.EventHandler(this.programDrpDwnBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(240, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Or enter a new one";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(668, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "*Ignore if entering new program";
            // 
            // Programs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 725);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.programDrpDwnBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.outcomesTextBox);
            this.Controls.Add(this.numSudentsBox);
            this.Controls.Add(this.currTextBox);
            this.Controls.Add(this.facultyTextBox);
            this.Controls.Add(this.facilitiesTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.courseListGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Backbtn);
            this.Name = "Programs";
            this.Text = "Programs";
            this.Load += new System.EventHandler(this.Programs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSudentsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView courseListGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox facilitiesTextBox;
        private System.Windows.Forms.TextBox facultyTextBox;
        private System.Windows.Forms.TextBox currTextBox;
        private System.Windows.Forms.NumericUpDown numSudentsBox;
        private System.Windows.Forms.TextBox outcomesTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox programDrpDwnBox;
        private Label label11;
        private Label label12;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn colDescription;
        private DataGridViewTextBoxColumn colStudentNum;
    }
}