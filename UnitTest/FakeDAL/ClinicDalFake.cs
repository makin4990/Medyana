using Entities.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace UnitTest.FakeDAL
{
    public class ClinicDalFake : IClinicDalFake
    {

        List<Clinic> _clinics;

        public ClinicDalFake()
        {
            _clinics = new List<Clinic>();
            SeedData(@"../../../TestData/OrderForTestData.json");
        }

        private void SeedData(string file) 
        {
            _clinics.Add(new Clinic
            {
                Id = 1,
                 Name = "Cerrahi Maske",
                
            });
            
        }

        public Clinic Add(Clinic entity)
        {
            _clinics.Add(entity);
            return entity;
        }

        public void Delete(Clinic entity)
        {
            _clinics.Remove(entity);
        }

        public Clinic Get(Expression<Func<Clinic, bool>> filter)
        {
            return _clinics.AsQueryable().Where(filter).FirstOrDefault();
        }

        public List<Clinic> GetAll(Expression<Func<Clinic, bool>> filter = null)
        {
            return _clinics;
        }

      
        public Clinic Update(Clinic entity)
        {
            Clinic clinic = _clinics.Find(p => p.Id == entity.Id);
            clinic = entity;
            return clinic;
        }

        public List<Clinic> GetAllClinicWithEquipment()
        {
            throw new NotImplementedException();
        }

        public Clinic GetClinicByIdWithEquipment(int clinicId)
        {
            throw new NotImplementedException();
        }

        public List<Clinic> GetAllClinicsBySearch(string search)
        {
            throw new NotImplementedException();
        }
    }
}
