using CloudHRMSTEST.Models.DataModel;

namespace CloudHRMSTEST.Repostories
{
    public interface IPositionRepository
    {
        void Create(PositionEntity positionEntity);
        IList<PositionEntity> GetAll();
        PositionEntity GetById(string id);
        void Update(PositionEntity positionEntity);
        void Delete(string id); 
    }
}
