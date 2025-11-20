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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void GoToCoursesbtn_Click(object sender, EventArgs e)
        {
            Courses courses = new Courses();
            courses.StartPosition = FormStartPosition.CenterScreen;
            courses.Show();
            this.Hide();
        }

        private void GoToAssessmentsbtn_Click(object sender, EventArgs e)
        {
            Assessments assessments = new Assessments();
            assessments.StartPosition = FormStartPosition.CenterScreen;
            assessments.Show();
            this.Hide();
        }

        private void GoToProgramsbtn_Click(object sender, EventArgs e)
        {
            Programs programs = new Programs();
            programs.StartPosition = FormStartPosition.CenterScreen;
            programs.Show();
            this.Hide();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.StartPosition = FormStartPosition.CenterScreen;
            settings.Show();
            this.Hide();
        }
    }
}
