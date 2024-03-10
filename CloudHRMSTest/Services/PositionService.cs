﻿using CloudHRMSTest.Models.ViewModel;
using CloudHRMSTEST.Models.DataModel;
using CloudHRMSTEST.Repostories;

namespace CloudHRMSTEST.Services
{
    public class PositionService : IPositionService 
    {
        private readonly IPositionRepository _positionRepository;

        public PositionService(IPositionRepository positionRepository)
        { 
            this._positionRepository = positionRepository;
        } 
        public void Create(PositionViewModel positionViewModel)
        {
            try
            {
                var IsPositionCodeAlreadyExists = _positionRepository.GetAll().Where(w => w.Code == positionViewModel.Code).Any();
                if (IsPositionCodeAlreadyExists)
                {
                    throw new Exception("Code already exists in the system.");
                }
                //Data exchange from view model to data model
                var position = new PositionEntity()
                {
                    Id = Guid.NewGuid().ToString(),
                    Code = positionViewModel.Code,
                    Name = positionViewModel.Name,
                    Level = positionViewModel.Level
                };
                _positionRepository.Create(position);
            }
            catch (Exception)
            {
                throw new Exception("Sorry! There are unexpected problem while saving process");
            }
        }

        public void Delete(string id)
        {
            _positionRepository.Delete(id);
        }

        public IList<PositionViewModel> GetAll()
        {
            return _positionRepository.GetAll().Select(
                 s => new PositionViewModel
                 {
                     Id = s.Id,
                     Code = s.Code,
                     Name = s.Name,
                     Level = s.Level,
                 }).ToList();
        }
        public PositionViewModel GetById(string id)
        {
            var positonEntity = _positionRepository.GetById(id);
            return new PositionViewModel()
            {
                Id = positonEntity.Id,
                Name = positonEntity.Name,
                Code = positonEntity.Code,
                Level = positonEntity.Level,
            };
        }

        public void Update(PositionViewModel positionViewModel)
        {
            var position = new PositionEntity()
            {
                Id = positionViewModel.Id,
                Name = positionViewModel.Name,
                Code = positionViewModel.Code,
                Level = positionViewModel.Level,
                ModifiedAt = DateTime.Now
            };
            _positionRepository.Update(position);
        }
    }
}

