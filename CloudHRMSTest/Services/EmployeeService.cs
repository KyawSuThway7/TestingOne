using CloudHRMSTest.Repostories;
using CloudHRMSTEST.Models.DataModel;
using CloudHRMSTEST.Models.ViewModel;

namespace CloudHRMSTest.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepostory _employeeRepostory;

        public EmployeeService(IEmployeeRepostory employeeRepostory)
        {
            this._employeeRepostory = employeeRepostory;
        }
        public void Create(EmployeeViewModel employee)
        {
            var EmployeeCodeAlreadyExist = _employeeRepostory.GetAll().Where(x => x.Code == employee.Code).Any();
            if(EmployeeCodeAlreadyExist)
            {
                throw new Exception("Code is already exist.Please need to chose another code");
            }
            var employees = new EmployeeEntity()
            {
                Id = Guid.NewGuid().ToString(),
                Code = employee.Code,
                Name = employee.Name,
                Email = employee.Email,
                Phone = employee.Phone,
                DOB = employee.DOB,
                DOE = employee.DOE,
                DOR = employee.DOR,
                Address = employee.Address,
                BasicSalary = employee.BasicSalary,
                Gender = employee.Gender,
                DepartmentId = employee.DepartmentId,
                PositionId = employee.PositionId,
            };
            _employeeRepostory.Create(employees);
        }

        public void Delete(string id)
        {
            _employeeRepostory.Delete(id);
        }

        public IList<EmployeeViewModel> GetAll()
        {
            return _employeeRepostory.GetAll().Select(x => new EmployeeViewModel
            {
                
            }).ToList();
        }

        public EmployeeViewModel GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(EmployeeViewModel employee)
        {
            throw new NotImplementedException();
        }
    }
}
