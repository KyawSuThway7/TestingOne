using CloudHRMSTest.Repostories;
using CloudHRMSTEST.Models.DataModel;
using CloudHRMSTEST.Models.ViewModel;

namespace CloudHRMSTest.Services
{
    public class DepartmentServices : IDepartmentServices
    {
        private DepartmentRepStory _departmentRepStory;

        public DepartmentServices(DepartmentRepStory departmentRepStory)
        {
            this._departmentRepStory = departmentRepStory;
        }
        public void Create(DepartmentViewModel viewModel)
        {
            var IsCodeAlreadyExist = _departmentRepStory.GetAll().Where(x => x.Code == viewModel.Code).Any();
            if (IsCodeAlreadyExist)
            {
                throw new Exception("Code is already exist");
            }
            var department = new DepartmentEntity()
            {
                Id = Guid.NewGuid().ToString(),
                Name = viewModel.Name,
                Code = viewModel.Code,
                ExtensionPhone = viewModel.ExtensionPhone,
            };
        }


        public void Delete(string id)
        {
            _departmentRepStory.Delete(id);
        }

        public IList<DepartmentViewModel> GetAll()
        {
          return _departmentRepStory.GetAll().Select(
              x => new DepartmentViewModel()
              {
                  Id = x.Id,
                  Code = x.Code,
                  Name = x.Name,
                  ExtensionPhone = x.ExtensionPhone,
              }).ToList();
        }

        public DepartmentViewModel GetById(string id)
        {
            var departmentEntity = _departmentRepStory.GetById(id);
            return new DepartmentViewModel()
            {
                Id = departmentEntity.Id,
                Code = departmentEntity.Code,
                Name = departmentEntity.Name,
                ExtensionPhone = departmentEntity.ExtensionPhone,
            };
        }

        public void Update(DepartmentViewModel viewModel)
        {
            var department = new DepartmentEntity()
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Code = viewModel.Code,
                ExtensionPhone= viewModel.ExtensionPhone,
                ModifiedAt = DateTime.Now
            };
            _departmentRepStory.Update(department);
        }

    }
}
