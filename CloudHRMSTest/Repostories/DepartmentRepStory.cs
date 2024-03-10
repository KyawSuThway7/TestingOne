using CloudHRMSTEST.DAO;
using CloudHRMSTEST.Models.DataModel;

namespace CloudHRMSTest.Repostories
{
    public class DepartmentRepStory : IDepartmentRepstory
    {
        private ApplicationDbContext _applicationDbContext;

        public DepartmentRepStory(ApplicationDbContext applicationDbContext)
        {
            this._applicationDbContext = applicationDbContext
        }
        public void Create(DepartmentEntity entity)
        {
            _applicationDbContext.Departments.Add(entity);
            _applicationDbContext.SaveChanges();
        }

        public void Delete(string id)
        {
            _applicationDbContext.Departments.Remove(id);
            _applicationDbContext.SaveChanges();
        }

        public IList<DepartmentEntity> GetAll()
        {
            return _applicationDbContext.Departments.ToList();
        }

        public DepartmentEntity GetById(string id)
        {
            return _applicationDbContext.Departments.Where(x => x.Id == id).SingleOrDefault();

        }

        public void Update(DepartmentEntity entity)
        {
            _applicationDbContext.Departments.Update(entity);
            _applicationDbContext.SaveChanges();
        }
    }
}
