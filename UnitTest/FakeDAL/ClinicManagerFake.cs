using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using X.PagedList;

namespace UnitTest.FakeDAL
{
    public class ClinicManagerFake : IClinicServiceFake
    {
        IClinicDalFake _clinicDalFake;

        public ClinicManagerFake(IClinicDalFake orderDalFake)
        {
            _clinicDalFake = orderDalFake;
        }

        public IResult Create(Clinic clinic)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int clinicId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Clinic>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Clinic>> GetAllClinicBySearchWithEquipment(string search)
        {
            throw new NotImplementedException();
        }

        public IDataResult<PagedList<Clinic>> GetAllClinicWithEquipment(string sort,int currentPage, int pageSize)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Clinic> GetById(int clinicId)
        {
            return new SuccessDataResult<Clinic>(_clinicDalFake.Get(c => c.Id == clinicId),"Success");
        }

        public IDataResult<Clinic> GetClinicByIdWithEquipment(int clinicId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Clinic clinic)
        {
            throw new NotImplementedException();
        }
    }
}
