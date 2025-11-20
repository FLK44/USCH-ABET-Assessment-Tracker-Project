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
            db.ClearDB();

        }

        private void delCrsTabBtn_Click(object sender, EventArgs e)
        {
            int rowsAff;
            Database db = new Database();
            rowsAff = db.ClearCourse();
            Console.WriteLine($"Rows affected: {rowsAff}");
        }

        private void delProgTabBtn_Click(object sender, EventArgs e)
        {
            int rowsAff;
            Database db = new Database();
            rowsAff = db.ClearProg();
            Console.WriteLine($"Rows affected: {rowsAff}");
        }

        private void delAsmTabBtn_Click(object sender, EventArgs e)
        {
            int rowsAff;
            Database db = new Database();
            rowsAff = db.ClearAsmnt();
            Console.WriteLine($"Rows affected: {rowsAff}");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Hide();
        }
    }
}
