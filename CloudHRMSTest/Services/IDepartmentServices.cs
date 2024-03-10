using CloudHRMSTEST.Models.ViewModel;

namespace CloudHRMSTest.Services
{
    public interface IDepartmentServices
    {
        void Create(DepartmentViewModel viewModel);
        IList<DepartmentViewModel> GetAll();
        DepartmentViewModel GetById(string id);
        void Update(DepartmentViewModel viewModel);
        void Delete(string id);
    }
}
