namespace API.Models
{
    public class Employee
    {
        public int ID {get; set;}
        public string employeeFName {get; set;}
        public string employeeLName {get; set;}
        public string employeeStatus {get; set;}
        public static int employeeId = 0;
        
    }
}