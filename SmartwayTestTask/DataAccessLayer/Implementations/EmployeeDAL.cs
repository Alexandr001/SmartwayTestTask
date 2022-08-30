using SmartwayTestTask.DataAccessLayer.Interfaces;
using SmartwayTestTask.DataAccessLayer.Models;

namespace SmartwayTestTask.DataAccessLayer.Implementations
{
    public class EmployeeDAL : IEmployeeDAL
    {
        public int CreateEmployee(EmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeModel> GetEmployeeByDepartment(string nameDepartment)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeModel> GetEmployeesByIdCompany(int idCompany)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(int id, params object[] param)
        {
            throw new NotImplementedException();
        }
    }
}
