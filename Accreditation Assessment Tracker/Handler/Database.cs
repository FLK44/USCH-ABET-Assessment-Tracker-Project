using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Drawing.Text;

namespace Accredition_Assessment_Tracker.Handler
{
    public class Database
    {
        string pathtodb;
        string connectionStr;
        public void initDB()    //creates the DB
        {
            string dirName = "Database";
            string fileName = "Tracker.db";
            if (!Directory.Exists(dirName)) //checks if the database folder exists, if not create it
            {
                Directory.CreateDirectory(dirName);
            }
            pathtodb = Path.Combine(dirName, fileName);
            connectionStr = $"Data Source={pathtodb};"; //actual path is ..bin/debug/Database/Tracker.db
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                connection.Open();
                if (!File.Exists(pathtodb))
                {
                    SQLiteConnection.CreateFile(pathtodb);  //creates the empty DB
                }
            }
            DB(); //calls db to set up tables
        }
        public void DB()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                string createAssmntTable = @"CREATE TABLE IF NOT EXISTS Assessments ( Id INTEGER PRIMARY KEY AUTOINCREMENT, AsmntName TEXT, AsmntType TEXT NOT NULL, AsmntDate TEXT NOT NULL )";
                string createProgTable = @"CREATE TABLE IF NOT EXISTS Programs ( Id INTEGER PRIMARY KEY AUTOINCREMENT, ProgName TEXT UNIQUE NOT NULL, Facilities TEXT,"+
                                                                                         " Faculty TEXT, Curriculum TEXT, StudentNum INTEGER NOT NULL, Outcomes TEXT )";
                string createCrsTable;

                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(createAssmntTable, connection))
                {
                    command.ExecuteNonQuery();
                }
                using (SQLiteCommand command = new SQLiteCommand(createProgTable, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
