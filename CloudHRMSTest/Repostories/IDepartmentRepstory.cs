using CloudHRMSTEST.Models.DataModel;

namespace CloudHRMSTest.Repostories
{
    public interface IDepartmentRepstory
    {
        void Create(DepartmentEntity entity);
        IList<DepartmentEntity> GetAll();
        DepartmentEntity GetById(string id);
        void Update(DepartmentEntity entity);
        void Delete(string id);
    }
}
