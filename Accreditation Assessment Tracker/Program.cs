using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accredition_Assessment_Tracker.Handler;

namespace Accredition_Assessment_Tracker
{
    internal class Program
    {
        static void Main()
        {
            Database db = new Database();
            db.initDB();    //initalize database on app start

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard()); 
        }
    }
}

