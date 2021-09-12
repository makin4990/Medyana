using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfClinicDal: EfEntityRepositoryBase<Clinic,MedyanaDbContext>,IClinicDal

    {
        public List<Clinic> GetAllClinicsBySearch(string search)
        {
            using (MedyanaDbContext dbContext = new MedyanaDbContext())
            {
                if (search == null) 
                {
                   var result = dbContext.Clinics
                   .Include(a => a.Equipments).ToList();
                    return result;
                }
                else
                {
                    var result = dbContext.Clinics
                .Include(a => a.Equipments).Where(s => s.Name.Contains(search)).ToList();
                    return result;
                }
               
            }
        }

        public List<Clinic> GetAllClinicWithEquipment()
        {
            using (MedyanaDbContext dbContext = new MedyanaDbContext())
            {
                var result = dbContext.Clinics
                    .Include(a => a.Equipments).ToList();
                return result;
            }
        }

        public Clinic GetClinicByIdWithEquipment(int clinicId)
        {
            using (MedyanaDbContext dbContext = new MedyanaDbContext())
            {
                return dbContext.Clinics.Include(a => a.Equipments).Where(a => a.Id == clinicId).FirstOrDefault();
            }
        }
    }
}
