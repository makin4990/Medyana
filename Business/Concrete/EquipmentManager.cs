using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class EquipmentManager:IEquipmentService
    {
        IEquipmentDal _equipmentDal;

        public EquipmentManager(IEquipmentDal equipmentDal)
        {
            _equipmentDal = equipmentDal;
        }

        [ValidationAspect(typeof(Equipment))]
        public IResult Create(Equipment equipment)
        {
            _equipmentDal.Add(equipment);
            return new SuccessResult(Messages.EquipmentsAdded);

        }

        [ValidationAspect(typeof(Equipment))]
        public IResult Update(Equipment equipment)
        {
            _equipmentDal.Update(equipment);
            return new SuccessResult(Messages.EquipmentsUpdated);
        }
        public IResult Delete(int equipmentId)
        {
            Equipment equipment = new Equipment {  Id= equipmentId };
            _equipmentDal.Delete(equipment);
            return new SuccessResult(Messages.EquipmentsDeleted);
        }
        
        public IDataResult<Equipment> GetById(int equipmentId)
        {
            _equipmentDal.Get(c => c.Id == equipmentId);
            return new SuccessDataResult<Equipment>(Messages.EquipmentsListed);
        }

        public IDataResult<List<Equipment>> GetAll()
        {
            _equipmentDal.GetAll();
            return new SuccessDataResult<List<Equipment>>(Messages.EquipmentsListed);
        }
    }
}
