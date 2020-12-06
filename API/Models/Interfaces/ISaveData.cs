namespace API.Models.Interfaces
{
    public interface ISaveData
    {
        public void SaveEmployee(Employee value);

        public void DeleteEmployee(int id);
    }
}