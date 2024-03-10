using CloudHRMSTEST.Models.ViewModel;

namespace CloudHRMSTest.Services
{
    public interface IEmployeeService
    {
        void Create(EmployeeViewModel employee);
        IList<EmployeeViewModel> GetAll();
        void Delete(string id);
        void Update(EmployeeViewModel employee);
        EmployeeViewModel GetById(string id);
    }
}
