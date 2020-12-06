using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using API.Models.Interfaces;
using System.Data.SQLite;

namespace API.Models
{
    public class SaveData : ISeedData, ISaveData
    {
        public void SaveEmployee(Employee value)
        {
            string cs = @"URI=file:C:\Users\talma\source\repos\mis321-project\emp.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = @"INSERT INTO employee(empFName, empLName, empStatus, overallScore, performanceScore, leadershipScore) VALUES(@empFName, @empLName, @empStatus, @overallScore, @performanceScore, @leadershipScore)";
            cmd.Parameters.AddWithValue("@empFName", value.employeeFName);
            cmd.Parameters.AddWithValue("@empLName", value.employeeLName);
            cmd.Parameters.AddWithValue("@empStatus", value.employeeStatus);
            cmd.Parameters.AddWithValue("@overallScore", value.overallScore);
            cmd.Parameters.AddWithValue("@performanceScore", value.performanceScore);
            cmd.Parameters.AddWithValue("@leadershipScore", value.leadershipScore);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        public void DeleteEmployee(int id)
        {
            string cs = @"URI=file:C:\Users\talma\source\repos\mis321-project\emp.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = @"DELETE FROM emp WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            Console.WriteLine(id);
        }

       public void SeedData()
        {
            string cs = @"URI=file:C:\Users\talma\source\repos\mis321-project\emp.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DROP TABLE IF EXISTS employee";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE employee(id INTEGER PRIMARY KEY, empFName TEXT, empLName TEXT, empStatus TEXT, overallScore INTEGER, performanceScore INTEGER, leadershipScore INTEGER)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"INSERT INTO employee(empFName, empLName, empStatus, overallScore, performanceScore, leadershipScore) VALUES(@empFName, @empLName, @empStatus, @overallScore, @performanceScore, @leadershipScore)";
            cmd.Parameters.AddWithValue("@empFName", "James");
            cmd.Parameters.AddWithValue("@empLName", "Clark");
            cmd.Parameters.AddWithValue("@empStatus", "E");
            cmd.Parameters.AddWithValue("@overallScore", "48");
            cmd.Parameters.AddWithValue("@performanceScore", "28");
            cmd.Parameters.AddWithValue("@leadershipScore", "20");
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"INSERT INTO employee(empFName, empLName, empStatus, overallScore, performanceScore, leadershipScore) VALUES(@empFName, @empLName, @empStatus, @overallScore, @performanceScore, @leadershipScore)";
            cmd.Parameters.AddWithValue("@empFName", "David");
            cmd.Parameters.AddWithValue("@empLName", "Winters");
            cmd.Parameters.AddWithValue("@empStatus", "E");
            cmd.Parameters.AddWithValue("@overallScore", "50");
            cmd.Parameters.AddWithValue("@performanceScore", "24");
            cmd.Parameters.AddWithValue("@leadershipScore", "26");
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"INSERT INTO employee(empFName, empLName, empStatus, overallScore, performanceScore, leadershipScore) VALUES(@empFName, @empLName, @empStatus, @overallScore, @performanceScore, @leadershipScore)";
            cmd.Parameters.AddWithValue("@empFName", "Aaron");
            cmd.Parameters.AddWithValue("@empLName", "Rodgers");
            cmd.Parameters.AddWithValue("@empStatus", "M");
            cmd.Parameters.AddWithValue("@overallScore", "55");
            cmd.Parameters.AddWithValue("@performanceScore", "27");
            cmd.Parameters.AddWithValue("@leadershipScore", "28");
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"INSERT INTO employee(empFName, empLName, empStatus, overallScore, performanceScore, leadershipScore) VALUES(@empFName, @empLName, @empStatus, @overallScore, @performanceScore, @leadershipScore)";
            cmd.Parameters.AddWithValue("@empFName", "Carl");
            cmd.Parameters.AddWithValue("@empLName", "Flannigan");
            cmd.Parameters.AddWithValue("@empStatus", "E");
            cmd.Parameters.AddWithValue("@overallScore", "23");
            cmd.Parameters.AddWithValue("@performanceScore", "10");
            cmd.Parameters.AddWithValue("@leadershipScore", "13");
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"INSERT INTO employee(empFName, empLName, empStatus, overallScore, performanceScore, leadershipScore) VALUES(@empFName, @empLName, @empStatus, @overallScore, @performanceScore, @leadershipScore)";
            cmd.Parameters.AddWithValue("@empFName", "Chang");
            cmd.Parameters.AddWithValue("@empLName", "Helkingsman");
            cmd.Parameters.AddWithValue("@empStatus", "M");
            cmd.Parameters.AddWithValue("@overallScore", "35");
            cmd.Parameters.AddWithValue("@performanceScore", "10");
            cmd.Parameters.AddWithValue("@leadershipScore", "25");
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"INSERT INTO employee(empFName, empLName, empStatus, overallScore, performanceScore, leadershipScore) VALUES(@empFName, @empLName, @empStatus, @overallScore, @performanceScore, @leadershipScore)";
            cmd.Parameters.AddWithValue("@empFName", "Max");
            cmd.Parameters.AddWithValue("@empLName", "Verstapan");
            cmd.Parameters.AddWithValue("@empStatus", "A");
            cmd.Parameters.AddWithValue("@overallScore", "58");
            cmd.Parameters.AddWithValue("@performanceScore", "28");
            cmd.Parameters.AddWithValue("@leadershipScore", "30");
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"INSERT INTO employee(empFName, empLName, empStatus, overallScore, performanceScore, leadershipScore) VALUES(@empFName, @empLName, @empStatus, @overallScore, @performanceScore, @leadershipScore)";
            cmd.Parameters.AddWithValue("@empFName", "Terry");
            cmd.Parameters.AddWithValue("@empLName", "McDonald");
            cmd.Parameters.AddWithValue("@empStatus", "E");
            cmd.Parameters.AddWithValue("@overallScore", "33");
            cmd.Parameters.AddWithValue("@performanceScore", "15");
            cmd.Parameters.AddWithValue("@leadershipScore", "18");
            cmd.Prepare();
            cmd.ExecuteNonQuery();

        }
    }
}