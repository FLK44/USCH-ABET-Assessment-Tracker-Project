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
    public partial class Courses : Form
    {
        public Courses()
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
                progIDDrpDwnBox.Items.Add(programEntry[1]);
                //Console.WriteLine(programEntry[1]);
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Hide();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string crsName = crsNameBox.Text;
            int progID = progIDDrpDwnBox.SelectedIndex;
            string code = crsCodeBox.Text;
            int hours = Convert.ToInt32(crdHrsBox.Value);
            string preR = preReqBox.Text;
            string instrName = instNameBox.Text;
            string crsDes = crsDescBox.Text;
            int stdNum = Convert.ToInt32(stdNumBox.Value);
            //int enrollmentsByMajor;
            //Console.WriteLine($"{crsName}\n{code}\n{hours}\n{preR}\n{instrName}\n{crsDes}\n{stdNum}\n");  //for debugging
            Database db = new Database();

            try
            {
                db.AddCourse(crsName, progID, code, hours, preR, instrName, crsDes, stdNum);
                MessageBox.Show($"Course: {crsName} successfully submitted.");
            }
            catch(Exception ex)
            {
                string[] errMes = ex.Message.Split('.');
                if (errMes[1] == "CourseName")
                {
                    MessageBox.Show($"Error: Entry already exists with course name {crsName}");
                }
                else if (errMes[1] == "Code")
                {
                    MessageBox.Show($"Error: Entry already exists with course code {code}");
                }
                else
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

            }
            
        }

        private void progIDDrpDwnBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
