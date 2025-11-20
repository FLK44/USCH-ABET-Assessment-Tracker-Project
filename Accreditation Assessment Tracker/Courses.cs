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
            string code = crsCodeBox.Text;
            int hours = Convert.ToInt32(crdHrsBox.Value);
            string preR = preReqBox.Text;
            string instrName = instNameBox.Text;
            string crsDes = crsDescBox.Text;
            int stdNum = Convert.ToInt32(stdNumBox.Value);
            //int enrollmentsByMajor;
            //Console.WriteLine($"{crsName}\n{code}\n{hours}\n{preR}\n{instrName}\n{crsDes}\n{stdNum}\n");  //for debugging
            Database db = new Database();
            db.AddCourse(crsName, code, hours, preR, instrName, crsDes, stdNum);
        }
    }
}
