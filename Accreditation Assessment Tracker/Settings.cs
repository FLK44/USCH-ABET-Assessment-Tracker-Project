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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void delDbBtn_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.initDB();
            db.ClearDB();

            MessageBox.Show("All tables cleared successfully.", "Success");

        }

        private void delCrsTabBtn_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.initDB();

            int rows = db.ClearCourse();

            MessageBox.Show($"Courses table cleared.\nRows deleted: {rows}", "Success");
        }

        private void delProgTabBtn_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.initDB();

            int rows = db.ClearProg();

            MessageBox.Show($"Programs table cleared.\nRows deleted: {rows}", "Success");
        }

        private void delAsmTabBtn_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.initDB();

            int rows = db.ClearAsmnt();

            MessageBox.Show($"Assessment table cleared.\nRows deleted: {rows}", "Success");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Hide();
        }

        private void fillDBBtn_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.TestFillDB();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
