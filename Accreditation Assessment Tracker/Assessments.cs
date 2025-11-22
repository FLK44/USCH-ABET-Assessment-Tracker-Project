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
    public partial class Assessments : Form
    {
        // Each Assessments form gets its own Database helper object.
        private readonly Database _db;
        public Assessments()
        {
            InitializeComponent();
            Database _db = new Database();
            int entryCount = 0;
            string[] programEntry;
            entryCount = _db.countEntries("Programs");
            //Console.WriteLine(entryCount.ToString());
            for (int i = 1; i < entryCount + 1; i++)    //adds all program names from table to dropdown box on start
            {
                programEntry = _db.PopulatePrograms(i);
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
        // adds an empty row to the grid so the user can type in a new assessment.
        private void addNewAssementBtn_Click(object sender, EventArgs e)
        {
            assessmentGridView.Rows.Add();
        }

        private void Assessments_Load(object sender, EventArgs e)
        {

        }
        // save and loops over each row in the grid and writes it to the Database.
        private void Savebtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in assessmentGridView.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                string type = Convert.ToString(row.Cells[0].Value);
                string name = Convert.ToString(row.Cells[1].Value);
                string date = Convert.ToString(row.Cells[2].Value);
                int crsID = crsIDDrpDwnBox.SelectedIndex;

                if (string.IsNullOrWhiteSpace(type) ||
                    string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(date))
                {
                    continue;
                }

                _db.AddAssesment(name, crsID, type, date);
            }

            MessageBox.Show("Assessments saved successfully.");
        }

        private void progIDDrpDwnBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            crsIDDrpDwnBox.Items.Clear();
            List<string[]> courseEntry;
            Database db = new Database();
            courseEntry = db.PopulateCourses(progIDDrpDwnBox.SelectedIndex);    //returns a collection of string arrays each holding a row.  0-9 for each collumn
            foreach (string[] item in courseEntry)
            {
                crsIDDrpDwnBox.Items.Add(item[1]);
            }
        }
    }
}
