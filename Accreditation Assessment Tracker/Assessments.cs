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
        // Database helper for this form
        private Database _db;

        // Holds the list of courses for the selected program
        private List<string[]> _currentCourses;
        public Assessments()
        {
            InitializeComponent();
            assessmentGridView.AllowUserToAddRows = false;
            _db = new Database();
            _db.initDB();

            int entryCount = 0;
            string[] programEntry;

            entryCount = _db.countEntries("Programs");
            for (int i = 1; i < entryCount + 1; i++)
            {
                programEntry = _db.PopulatePrograms(i);
                progIDDrpDwnBox.Items.Add(programEntry[1]);   
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
            if (progIDDrpDwnBox.SelectedIndex < 0 || crsIDDrpDwnBox.SelectedIndex < 0)
            {
                // message box to prevent adding to grid before selecting program and course
                MessageBox.Show("Select a Program and Course first.");
                return;
            }
            assessmentGridView.Rows.Add();
        }

        private void Assessments_Load(object sender, EventArgs e)
        {

        }
        // save and loops over each row in the grid and writes it to the Database.
        private void Savebtn_Click(object sender, EventArgs e)
        {
            // message box to prevent saving before selecting program and course
            if (progIDDrpDwnBox.SelectedIndex < 0 || crsIDDrpDwnBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Program and Course before saving.",
                                "Missing Selection",
                                MessageBoxButtons.OK);
                return;
            }

            // Check if any data rows exist
            if (assessmentGridView.Rows.Count == 0)
            {
                MessageBox.Show("No assessments to save.", "Empty Table");
                return;
            }

            // Get the selected course from _currentCourses
            int courseIndex = crsIDDrpDwnBox.SelectedIndex;
            string[] selectedCourse = _currentCourses[courseIndex];
            int courseId = Convert.ToInt32(selectedCourse[0]);   // [0] = Courses.Id

            // Save each row for that course
            foreach (DataGridViewRow row in assessmentGridView.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string type = Convert.ToString(row.Cells[0].Value);
                string name = Convert.ToString(row.Cells[1].Value);
                string date = Convert.ToString(row.Cells[2].Value);

                if (string.IsNullOrWhiteSpace(type) ||
                    string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(date))
                    continue;

                // AddAssesment(string name, int crsID, string type, string date)
                try
                {
                    _db.AddAssesment(name, courseId, type, date);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving assessment: {ex.Message}");
                }
            }

            MessageBox.Show("Assessments saved successfully.");
        }

        private void progIDDrpDwnBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear old course list and assessment
            crsIDDrpDwnBox.Items.Clear();
            assessmentGridView.Rows.Clear();

            int progIndex = progIDDrpDwnBox.SelectedIndex;

            // Get all courses whose ProgID == progIndex
            _currentCourses = _db.PopulateCourses(progIndex);

            // Fill Course dropdown with course names
            foreach (var course in _currentCourses)
            {
                // course[2] = CourseName
                crsIDDrpDwnBox.Items.Add(course[2]);
            }

        }
        private void crsIDDrpDwnBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear current rows
            assessmentGridView.Rows.Clear();

            // Safety check for errors
            if (_currentCourses == null || _currentCourses.Count == 0)
                return;

            int courseIndex = crsIDDrpDwnBox.SelectedIndex;
            if (courseIndex < 0)
                return;

            // Get selected course from _currentCourses
            string[] selectedCourse = _currentCourses[courseIndex];

            // entry[0] = Courses.Id (primary key)
            int courseId = Convert.ToInt32(selectedCourse[0]);

            // Load assessments for this course
            List<string[]> assessments = _db.PopulateAssessments(courseId);

            // Each entry: [0]=Id, [1]=CourseID, [2]=Name, [3]=Type, [4]=Date
            foreach (var asm in assessments)
            {
               int row = assessmentGridView.Rows.Add();
               assessmentGridView.Rows[row].Cells[0].Value = asm[3]; // Type
               assessmentGridView.Rows[row].Cells[1].Value = asm[2]; // Name
               assessmentGridView.Rows[row].Cells[2].Value = asm[4]; // Date
            }
        }
    }
}
