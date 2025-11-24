namespace Accredition_Assessment_Tracker
{
    partial class Assessments
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
            this.Backbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.crsIDDrpDwnBox = new System.Windows.Forms.ComboBox();
            this.progIDDrpDwnBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.assessmentGridView = new System.Windows.Forms.DataGridView();
            this.AssessmentTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssessmentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssessmentDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addNewAssementBtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Backbtn
            // 
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(35, 458);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(129, 44);
            this.Backbtn.TabIndex = 1;
            this.Backbtn.Text = "Back To Dashboard";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course and Program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Program:";
            // 
            // crsIDDrpDwnBox
            // 
            this.crsIDDrpDwnBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crsIDDrpDwnBox.FormattingEnabled = true;
            this.crsIDDrpDwnBox.Location = new System.Drawing.Point(100, 86);
            this.crsIDDrpDwnBox.Name = "crsIDDrpDwnBox";
            this.crsIDDrpDwnBox.Size = new System.Drawing.Size(121, 21);
            this.crsIDDrpDwnBox.TabIndex = 5;
            this.crsIDDrpDwnBox.SelectedIndexChanged += new System.EventHandler(this.crsIDDrpDwnBox_SelectedIndexChanged);
            // 
            // progIDDrpDwnBox
            // 
            this.progIDDrpDwnBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.progIDDrpDwnBox.FormattingEnabled = true;
            this.progIDDrpDwnBox.Location = new System.Drawing.Point(100, 59);
            this.progIDDrpDwnBox.Name = "progIDDrpDwnBox";
            this.progIDDrpDwnBox.Size = new System.Drawing.Size(121, 21);
            this.progIDDrpDwnBox.TabIndex = 6;
            this.progIDDrpDwnBox.SelectedIndexChanged += new System.EventHandler(this.progIDDrpDwnBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Assessment List";
            // 
            // assessmentGridView
            // 
            this.assessmentGridView.AllowUserToOrderColumns = true;
            this.assessmentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.assessmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assessmentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssessmentTypeColumn,
            this.AssessmentNameColumn,
            this.AssessmentDateColumn});
            this.assessmentGridView.Location = new System.Drawing.Point(35, 162);
            this.assessmentGridView.Name = "assessmentGridView";
            this.assessmentGridView.Size = new System.Drawing.Size(385, 263);
            this.assessmentGridView.TabIndex = 8;
            // 
            // AssessmentTypeColumn
            // 
            this.AssessmentTypeColumn.HeaderText = "Assessment Type";
            this.AssessmentTypeColumn.Name = "AssessmentTypeColumn";
            this.AssessmentTypeColumn.Width = 106;
            // 
            // AssessmentNameColumn
            // 
            this.AssessmentNameColumn.HeaderText = "Assessment Name";
            this.AssessmentNameColumn.Name = "AssessmentNameColumn";
            this.AssessmentNameColumn.Width = 109;
            // 
            // AssessmentDateColumn
            // 
            this.AssessmentDateColumn.HeaderText = "Date";
            this.AssessmentDateColumn.Name = "AssessmentDateColumn";
            this.AssessmentDateColumn.Width = 55;
            // 
            // addNewAssementBtn
            // 
            this.addNewAssementBtn.Location = new System.Drawing.Point(459, 162);
            this.addNewAssementBtn.Name = "addNewAssementBtn";
            this.addNewAssementBtn.Size = new System.Drawing.Size(119, 38);
            this.addNewAssementBtn.TabIndex = 9;
            this.addNewAssementBtn.Text = "Add New...";
            this.addNewAssementBtn.UseVisualStyleBackColor = true;
            this.addNewAssementBtn.Click += new System.EventHandler(this.addNewAssementBtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(322, 485);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(98, 29);
            this.Savebtn.TabIndex = 10;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Assessments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 524);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.addNewAssementBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progIDDrpDwnBox);
            this.Controls.Add(this.crsIDDrpDwnBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.assessmentGridView);
            this.Name = "Assessments";
            this.Text = "Assessments";
            this.Load += new System.EventHandler(this.Assessments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assessmentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox crsIDDrpDwnBox;
        private System.Windows.Forms.ComboBox progIDDrpDwnBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView assessmentGridView;
        private System.Windows.Forms.Button addNewAssementBtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssessmentTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssessmentNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssessmentDateColumn;
    }
}