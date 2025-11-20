using Accredition_Assessment_Tracker.Handler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accredition_Assessment_Tracker
{
    public partial class Programs : Form
    {
        public Programs()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Hide();

        }

        private void programDrpDwnBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addProgramButton_Click(object sender, EventArgs e)
        {
            string progName = programDrpDwnBox.Text;
            //Console.WriteLine(input);
            programDrpDwnBox.Items.Add(progName);
        }


        private void addCourseButton_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string progName = programDrpDwnBox.Text;
            string facilitiesText = facilitiesTextBox.Text;
            string facultyText = facultyTextBox.Text;
            string currText = currTextBox.Text;
            int stNum = Convert.ToInt32(numSudentsBox.Value);
            string outCms = outcomesTextBox.Text;

            //Console.WriteLine($"{progName}\n{facilitiesText}\n{facultyText}\n{currText}\n{stNum}\n{outCms}\n"); //for debugging
            Database db = new Database();
            db.AddProgram(progName, facilitiesText, facultyText, currText, stNum, outCms);
        }
    }
}
