using SmartwayTestTask.DataAccessLayer.Models;

namespace SmartwayTestTask.DataAccessLayer.Interfaces
{
    public interface IEmployeeDAL
    {
        int CreateEmployee(EmployeeModel model);
        void DeleteEmployee(int id);
        IEnumerable<EmployeeModel> GetEmployeesByIdCompany(int idCompany);
        IEnumerable<EmployeeModel> GetEmployeeByDepartment(string nameDepartment);
        void UpdateEmployee(int id, params object[] param);
    }
}
