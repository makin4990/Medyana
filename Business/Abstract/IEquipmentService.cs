using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IEquipmentService
    {
        IDataResult<List<Equipment>> GetAll();
        IDataResult<Equipment> GetById(int equipmentId);
        IResult Create(Equipment equipment);
        IResult Update(Equipment equipment);
        IResult Delete(int equipmentId);
      
    }
}
