using System;
using System.Collections.Generic;
using API.Models.Interfaces;
using System.Data.SQLite;

namespace mis321_project.Models
{
    public class SaveData : ISeedData, ISaveData
    //:IReadAllData, IGetEmployee 
    {
        public void SaveEmployee(Post text)
        {
            string cs = @"URI=file:C:\Users\talma\source\repos\pa4-talmartin-1\employee.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(con);

            // cmd.CommandText = @"INSERT INTO post(text, date) VALUES(@text, @date)";
            // cmd.Parameters.AddWithValue("@text", text.text);
            // DateTime time = DateTime.Now;
            // cmd.Parameters.AddWithValue("@date", time);
            // cmd.Prepare();
            // cmd.ExecuteNonQuery();

        }

        public void SeedData()
        {
            string cs = @"URI=file:C:\Users\talma\source\repos\pa4-talmartin-1\employee.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(con);

            //Drop table if it exist
            cmd.CommandText = "DROP TABLE IF EXISTS post";
            cmd.ExecuteNonQuery();

            //Create table
           cmd.CommandText = @"CREATE TABLE post(id INTEGER PRIMARY KEY, text TEXT, date DATETIME)";
           cmd.ExecuteNonQuery();

           //Populate table
        //    cmd.CommandText = @"INSERT INTO post(text, date) VALUES(@text, @date)";
        //    cmd.Parameters.AddWithValue("@text", "Let's go Bama!");
        //    cmd.Parameters.AddWithValue("@date", DateTime.Now);
        //    cmd.Prepare();
        //    cmd.ExecuteNonQuery();

        //    cmd.CommandText = @"INSERT INTO post(text, date) VALUES(@text, @date)";
        //    cmd.Parameters.AddWithValue("@text", "The Tide!");
        //    cmd.Parameters.AddWithValue("@date", DateTime.Now);
        //    cmd.Prepare();
        //    cmd.ExecuteNonQuery();

        //    cmd.CommandText = @"INSERT INTO post(text, date) VALUES(@text, @date)";
        //    cmd.Parameters.AddWithValue("@text", "Roll Tide!!!");
        //    cmd.Parameters.AddWithValue("@date", DateTime.Now);
        //    cmd.Prepare();
        //    cmd.ExecuteNonQuery();



        }
    }
}