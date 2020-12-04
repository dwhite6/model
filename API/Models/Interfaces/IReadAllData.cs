using System.Collections.Generic;

namespace API.Models.Interfaces
{
    public interface IReadAllData
    {
        public List<Employee> GetAllEmployees();
    }
}