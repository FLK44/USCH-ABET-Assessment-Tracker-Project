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
            Database db = new Database();
            int entryCount = 0;
            string[] programEntry;
            entryCount = db.countEntries("Programs");
            //Console.WriteLine(entryCount.ToString());
            for (int i = 1; i < entryCount + 1; i++)    //adds all program names from table to dropdown box on start
            {
                programEntry = db.PopulatePrograms(i);
                programDrpDwnBox.Items.Add(programEntry[1]);
                //Console.WriteLine(programEntry[1]);
            }

        }
        private void fillPageValues(int index)  //fills the page with table values at ID# of index
        {
            Database db = new Database();
            string[] programEntry = db.PopulatePrograms(index);
            programDrpDwnBox.Text = programEntry[1];    //prog name
            facilitiesTextBox.Text = programEntry[2];   //facilities
            facultyTextBox.Text = programEntry[3];      //faculty
            currTextBox.Text = programEntry[4];         //curriculum
            numSudentsBox.Value = Convert.ToInt32(programEntry[5]); //num of students
            outcomesTextBox.Text = programEntry[6];     //outcomes
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
            fillPageValues(programDrpDwnBox.SelectedIndex + 1);
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
