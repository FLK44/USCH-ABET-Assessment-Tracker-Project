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
        public Assessments()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.initDB();
            db.AddAssesment("a", "b", "c");
            Dashboard dashboard = new Dashboard();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Hide();
        }
    }
}
