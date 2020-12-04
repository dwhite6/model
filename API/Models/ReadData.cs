using System;
using System.Collections.Generic;
using API.Models.Interfaces;
using System.Data.SQLite;

namespace API.Models
{
    public class ReadData : IReadAllData, IGetEmployee
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> allEmployees = new List<Employee>();

            string cs = @"URI=file:C:\Users\talma\source\repos\pa4-talmartin-1\employee.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM employee";
            using var cmd = new SQLiteCommand(stm, con);

            using SQLiteDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                Employee temp = new Employee(){ID = rdr.GetInt32(0), employeeFName = rdr.GetString(1), employeeLName = rdr.GetString(2), employeeStatus = rdr.GetString(3)};
                allEmployees.Add(temp);
            }

            return allEmployees;
        }

        public Employee GetEmployee(int id)
        {
            string cs = @"URI=file:C:\Users\talma\source\repos\pa4-talmartin-1\employee.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM employee WHERE id = @id";
            using var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            return new Employee(){ID = rdr.GetInt32(0), employeeFName = rdr.GetString(1), employeeLName = rdr.GetString(2), employeeStatus = rdr.GetString(3)};
        }
    }
}