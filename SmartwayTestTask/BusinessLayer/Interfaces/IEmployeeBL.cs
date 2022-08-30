using SmartwayTestTask.DataAccessLayer.Models;

namespace SmartwayTestTask.BusinessLayer.Interfaces
{
    public interface IEmployeeBL
    {
        int CreateEmployee(EmployeeModel model);
        void DeleteEmployee(int id);
        IEnumerable<EmployeeModel> GetEmployeesByIdCompany(int idCompany);
        IEnumerable<EmployeeModel> GetEmployeeByDepartment(string nameDepartment);
        void UpdateEmployee(int id, params object[] param);
    }
}
