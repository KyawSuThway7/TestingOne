using CloudHRMSTest.Models.ViewModel;

namespace CloudHRMSTEST.Services
{
    public interface IPositionService 
    {
        void Create(PositionViewModel positionViewModel);
        IList<PositionViewModel> GetAll();
        PositionViewModel GetById(string id);  
        void Update(PositionViewModel positionViewModel);
        void Delete(string id);
    }
}
