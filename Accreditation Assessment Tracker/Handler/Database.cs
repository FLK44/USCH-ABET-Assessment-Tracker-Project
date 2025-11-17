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
        string pathtodb;    //dir and filename to db
        string connectionStr;   //holds path to DB for SQLite
        public void initDB()    //creates the DB
        {
            string dirName = "Database";    //folder name
            string fileName = "Tracker.db"; //name of the DB

            if (!Directory.Exists(dirName)) //checks if the database folder exists, if not create it
            {
                Directory.CreateDirectory(dirName);
            }
            pathtodb = Path.Combine(dirName, fileName);
            connectionStr = $"Data Source={pathtodb};"; //actual path is ..bin/debug/Database/Tracker.db

            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                connection.Open();
                if (!File.Exists(pathtodb)) //check if db already exists, if not create it
                {
                    SQLiteConnection.CreateFile(pathtodb);  //creates the empty DB
                }
            }


            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))   //populates db with tables
            {
                //queries for constructing the tables
                string createAssmntTable = @"CREATE TABLE IF NOT EXISTS Assessments ( Id INTEGER PRIMARY KEY AUTOINCREMENT, AsmntName TEXT, AsmntType TEXT NOT NULL, AsmntDate TEXT NOT NULL )";
                string createProgTable = @"CREATE TABLE IF NOT EXISTS Programs ( Id INTEGER PRIMARY KEY AUTOINCREMENT, ProgName TEXT UNIQUE NOT NULL, Facilities TEXT," +
                                                                                         " Faculty TEXT, Curriculum TEXT, StudentNum INTEGER, Outcomes TEXT )";
                string createCrsTable = @"CREATE TABLE IF NOT EXISTS Courses ( Id INTEGER PRIMARY KEY AUTOINCREMENT, CourseName TEXT UNIQUE NOT NULL, Code INTEGER UNIQUE NOT NULL, Hours INTEGER NOT NULL, " +
                                                                                         "PreReqs TEXT, Instructor TEXT, Description TEXT, StudentNum INTEGER )";

                //execute each query
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(createAssmntTable, connection))
                {
                    command.ExecuteNonQuery();
                }
                using (SQLiteCommand command = new SQLiteCommand(createProgTable, connection))
                {
                    command.ExecuteNonQuery();
                }
                using (SQLiteCommand command = new SQLiteCommand(createCrsTable, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        //Debug functions
        public void ClearDB()   //remove all entries from tables, result is DB with 3 empty tables
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                string insertQuery = "DROP TABLE IF EXISTS Assessments";    //drops each table

                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
                insertQuery = "DROP TABLE IF EXISTS Programs";
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
                insertQuery = "DROP TABLE IF EXISTS Courses";
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            initDB();   //reinitialized db to empty state
        }
        public void ClearAsmnt() //clear assessment table
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {

            }
        }
        public void ClearProg() //clear prog table
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {

            }
        }
        public void ClearCourse() //clear crs table
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {

            }
        }

        //Assesment Functions
        public void AddAssesment(string name, string type, string date)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                string insertQuery = @"INSERT INTO Assessments (AsmntName, AsmntType, AsmntDate) VALUES(@Name, @Type, @Date);";

                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Type", type);
                    command.Parameters.AddWithValue("@Date", date);
                    command.ExecuteNonQuery();
                }
            }

        }

        //Program Functions
        public void AddProgram()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {

            }
        }

        //Course Functions
        public void AddCourse()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {

            }
        }
    }
}
