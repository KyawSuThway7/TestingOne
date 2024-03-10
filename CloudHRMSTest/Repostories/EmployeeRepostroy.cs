using CloudHRMSTEST.DAO;
using CloudHRMSTEST.Models.DataModel;

namespace CloudHRMSTest.Repostories
{
    public class EmployeeRepostroy : IEmployeeRepostory
    {
        private ApplicationDbContext _applicationDbContext;

        public EmployeeRepostroy(ApplicationDbContext applicationDbContext)
        {
            this._applicationDbContext = applicationDbContext;
        }
        public void Create(EmployeeEntity employee)
        {
            _applicationDbContext.Employees.Add(employee);
            _applicationDbContext.SaveChanges();
        }

        public void Delete(string id)
        {
           if(null != id)
            {
                var employee = _applicationDbContext.Employees.Find(id);
                if(employee != null)
                {
                    _applicationDbContext.Remove(employee);
                    _applicationDbContext.SaveChanges();
                }
            }
        }

        public IList<EmployeeEntity> GetAll()
        {
           return _applicationDbContext.Employees.ToList();
        }

        public EmployeeEntity GetById(string id)
        {
            return _applicationDbContext.Employees.Where(w => w.Id == id).SingleOrDefault();
        }

        public void Update(EmployeeEntity employee)
        {
            _applicationDbContext.Employees.Update(employee);
            _applicationDbContext.SaveChanges();
        }
    }
}
