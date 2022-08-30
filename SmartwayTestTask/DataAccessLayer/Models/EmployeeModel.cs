namespace SmartwayTestTask.DataAccessLayer.Models
{
    public class EmployeeModel
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int CompanyId { get; set; }
        public PassportModel PassportNumber { get; set; }
        public DepartamentModel DepartmentName { get; set; }
    }
}
