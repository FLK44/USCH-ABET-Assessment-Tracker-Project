using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Accredition_Assessment_Tracker.Handler
{
    public class Database
    {
        string pathtodb;    //dir and filename to db
        string connectionStr;   //holds path to DB for SQLite
        private string getConnStr() //creates folder path and returns the connection string needed for sqlite functions
        {
            string dirName = "Database";    //folder name
            string fileName = "Tracker.db"; //name of the DB file

            if (!Directory.Exists(dirName)) //checks if the database folder exists, if not create it
            {
                Directory.CreateDirectory(dirName);
            }
            pathtodb = Path.Combine(dirName, fileName);
            connectionStr = $"Data Source={pathtodb};"; //actual path is ..bin/debug/Database/Tracker.db
            return connectionStr;
        }

        public void initDB()
        {

            connectionStr = getConnStr();   //get connectionStr call
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
                string createAssmntTable = @"CREATE TABLE IF NOT EXISTS Assessments ( Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                             "CourseID INT NOT NULL, " +
                                            "AsmntName TEXT, AsmntType TEXT NOT NULL, AsmntDate TEXT NOT NULL, " +
                                            "FOREIGN KEY (CourseID) REFERENCES Courses(Id) ON DELETE CASCADE )";

                string createProgTable = @"CREATE TABLE IF NOT EXISTS Programs ( Id INTEGER PRIMARY KEY AUTOINCREMENT, " + 
                                          "ProgName TEXT UNIQUE NOT NULL, Facilities TEXT, " +
                                          "Faculty TEXT, Curriculum TEXT, StudentNum INTEGER, Outcomes TEXT )";

                string createCrsTable = @"CREATE TABLE IF NOT EXISTS Courses ( Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                         "ProgID INT NOT NULL, " +
                                         "CourseName TEXT UNIQUE NOT NULL, Code INTEGER UNIQUE NOT NULL, Hours INTEGER NOT NULL, " +
                                         "PreReqs TEXT, Instructor TEXT, Description TEXT, StudentNum INTEGER, " +
                                         "FOREIGN KEY (ProgID) REFERENCES Programs(Id) ON DELETE CASCADE )";

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
            connectionStr = getConnStr();
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
        public void TestFillDB()    //fills DB with test values
        {
            Database db = new Database();
            db.ClearDB();
            for (int i = 0; i < 10; i++)
            {
                db.AddAssesment($"TestNM{i}", i, "Quiz", $"11/1{i}/2000");
                db.AddCourse($"Test Course 11{i}", i, $"TST-11{i}", 3, $"TST-10{i}", "Dr. Saul Realman", $"Descriptive test text{i}", 30 + i);
                db.AddProgram($"Program Name{i}", $"Lab 11{i}", $"Instructors: {i}", $"linkToACurr{i}", 1000 + i, $"Descriptive outcome text{i}");
            }
        }
        public int ClearAsmnt() //clear assessment table
        {
            int rowsAff = 0;
            connectionStr = getConnStr();
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                string delQuery = @"DELETE FROM Assessments";
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(delQuery, connection))
                {
                    return rowsAff = command.ExecuteNonQuery();
                }
            }
        }
        public int ClearProg() //clear prog table
        {
            int rowsAff = 0;
            connectionStr = getConnStr();
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                string delQuery = @"DELETE FROM Programs";
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(delQuery, connection))
                {
                    return rowsAff = command.ExecuteNonQuery();
                }
            }
        }
        public int ClearCourse() //clear crs table
        {
            int rowsAff = 0;
            connectionStr = getConnStr();
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                string delQuery = @"DELETE FROM Courses";
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(delQuery, connection))
                {
                    return rowsAff = command.ExecuteNonQuery();
                }
            }
        }

        //Assesment Functions
        public void AddAssesment(string name, int crsID, string type, string date)
        {
            connectionStr = getConnStr();
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                string insertQuery = @"INSERT INTO Assessments (AsmntName, CourseID, AsmntType, AsmntDate) VALUES(@Name, @crsID, @Type, @Date);"; //insertion query

                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@crsID", crsID);
                    command.Parameters.AddWithValue("@Type", type);
                    command.Parameters.AddWithValue("@Date", date);
                    command.ExecuteNonQuery();
                }
            }

        }

        //Program Functions
        public void AddProgram(string progName, string facil, string facul, string curr, int stnNum, string outcm)  //adds a program to the program table in db
        {
            connectionStr = getConnStr();
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                string insertQuery = @"INSERT INTO Programs (ProgName, Facilities, Faculty, Curriculum, StudentNum, Outcomes) VALUES(@progName, @facil, @facul, @curr, @stnNum, @outcm)";
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@progName", progName);
                    command.Parameters.AddWithValue("@facil", facil);
                    command.Parameters.AddWithValue("@facul", facul);
                    command.Parameters.AddWithValue("@stnNum", stnNum);
                    command.Parameters.AddWithValue("@curr", curr);
                    command.Parameters.AddWithValue("@outcm", outcm);
                    command.ExecuteNonQuery();
                }
            }
        }

        public string[] PopulatePrograms(int index)    //pulls program table info from the db
        {
            connectionStr = getConnStr();
            string[] output = new string[7];
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                string readQuery = @"SELECT * FROM Programs WHERE Id = @Id";
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(readQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", index);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output[0] = reader["Id"].ToString();
                            output[1] = reader["ProgName"].ToString();
                            output[2] = reader["Facilities"].ToString();
                            output[3] = reader["Faculty"].ToString();
                            output[4] = reader["Curriculum"].ToString();
                            output[5] = reader["StudentNum"].ToString();
                            output[6] = reader["Outcomes"].ToString();
                            return output;
                        }
                    }
                }
            }
            output[0] = "empty";
            return output;
        }

        //Course Functions
        public void AddCourse(string crsName, int progID, string code, int hrs, string preReq, string instrName, string desc, int stdNum)
        {
            connectionStr = getConnStr();
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                string insertQuery = @"INSERT INTO Courses(CourseName, ProgID, Code, Hours, PreReqs, Instructor, Description, StudentNum) VALUES(@crsName, @progID, @code, @hrs, @preReq, @instrName, @desc, @stdNum)";
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@crsName", crsName);
                    command.Parameters.AddWithValue("@progID", progID);
                    command.Parameters.AddWithValue("@code", code);
                    command.Parameters.AddWithValue("@hrs", hrs);
                    command.Parameters.AddWithValue("@preReq", preReq);
                    command.Parameters.AddWithValue("@instrName", instrName);
                    command.Parameters.AddWithValue("@desc", desc);
                    command.Parameters.AddWithValue("@stdNum",stdNum);
                    command.ExecuteNonQuery();
                }
            }
        }

        //Helper funcitons
        public int countEntries(string table)
        {
            connectionStr = getConnStr();
            using (SQLiteConnection connection = new SQLiteConnection(connectionStr))
            {
                string readQuery = $"SELECT COUNT(*) FROM {table}";
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(readQuery, connection))
                {
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }
    }
}
