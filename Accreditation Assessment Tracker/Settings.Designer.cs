namespace Accredition_Assessment_Tracker
{
    partial class Settings
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
            this.delDbBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.delCrsTabBtn = new System.Windows.Forms.Button();
            this.delProgTabBtn = new System.Windows.Forms.Button();
            this.delAsmTabBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delDbBtn
            // 
            this.delDbBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delDbBtn.Location = new System.Drawing.Point(92, 50);
            this.delDbBtn.Name = "delDbBtn";
            this.delDbBtn.Size = new System.Drawing.Size(172, 47);
            this.delDbBtn.TabIndex = 0;
            this.delDbBtn.Text = "Clear Database";
            this.delDbBtn.UseVisualStyleBackColor = true;
            this.delDbBtn.Click += new System.EventHandler(this.delDbBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Debug Options";
            // 
            // delCrsTabBtn
            // 
            this.delCrsTabBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delCrsTabBtn.Location = new System.Drawing.Point(92, 103);
            this.delCrsTabBtn.Name = "delCrsTabBtn";
            this.delCrsTabBtn.Size = new System.Drawing.Size(172, 47);
            this.delCrsTabBtn.TabIndex = 2;
            this.delCrsTabBtn.Text = "Clear Course table";
            this.delCrsTabBtn.UseVisualStyleBackColor = true;
            this.delCrsTabBtn.Click += new System.EventHandler(this.delCrsTabBtn_Click);
            // 
            // delProgTabBtn
            // 
            this.delProgTabBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delProgTabBtn.Location = new System.Drawing.Point(92, 156);
            this.delProgTabBtn.Name = "delProgTabBtn";
            this.delProgTabBtn.Size = new System.Drawing.Size(172, 47);
            this.delProgTabBtn.TabIndex = 3;
            this.delProgTabBtn.Text = "Clear Programs Table";
            this.delProgTabBtn.UseVisualStyleBackColor = true;
            this.delProgTabBtn.Click += new System.EventHandler(this.delProgTabBtn_Click);
            // 
            // delAsmTabBtn
            // 
            this.delAsmTabBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delAsmTabBtn.Location = new System.Drawing.Point(92, 208);
            this.delAsmTabBtn.Name = "delAsmTabBtn";
            this.delAsmTabBtn.Size = new System.Drawing.Size(172, 47);
            this.delAsmTabBtn.TabIndex = 4;
            this.delAsmTabBtn.Text = "Clear Assm. Table";
            this.delAsmTabBtn.UseVisualStyleBackColor = true;
            this.delAsmTabBtn.Click += new System.EventHandler(this.delAsmTabBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(12, 276);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(86, 39);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 327);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.delAsmTabBtn);
            this.Controls.Add(this.delProgTabBtn);
            this.Controls.Add(this.delCrsTabBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delDbBtn);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delDbBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delCrsTabBtn;
        private System.Windows.Forms.Button delProgTabBtn;
        private System.Windows.Forms.Button delAsmTabBtn;
        private System.Windows.Forms.Button backBtn;
    }
}