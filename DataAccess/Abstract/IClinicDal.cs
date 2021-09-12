using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IClinicDal: IEntityRepository<Clinic>
    {
        public List<Clinic> GetAllClinicWithEquipment();
        public Clinic GetClinicByIdWithEquipment(int clinicId);
        public List<Clinic> GetAllClinicsBySearch(string search);

    }
}
