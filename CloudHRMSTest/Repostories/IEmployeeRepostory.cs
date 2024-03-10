using CloudHRMSTEST.Models.DataModel;

namespace CloudHRMSTest.Repostories
{
    public interface IEmployeeRepostory
    {
        void Create(EmployeeEntity employee);
        EmployeeEntity GetById(string id);
        IList<EmployeeEntity> GetAll();
        void Delete(string id);
        void Update(EmployeeEntity employee);
    }
}
