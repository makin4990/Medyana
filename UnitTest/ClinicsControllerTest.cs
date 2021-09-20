using Business.Abstract;
using Business.Concrete;
using CustomerAPI;
using DataAccess.Abstract;
using Entities.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UnitTest.FakeDAL;
using WebAPI;
using Xunit;


namespace UnitTest
{
    public class ClinicsControllerTest : IClassFixture<InMemoryWebApplicationFactory<Startup>>
    {
        private InMemoryWebApplicationFactory<Startup> factory;

       

        IClinicService _service;
        IClinicDalFake _clinicDalFake;
        public ClinicsControllerTest()
        {
            _clinicDalFake = new ClinicDalFake();
            _service = new ClinicManager(_clinicDalFake);
        }

       
        [Fact]
        public async Task get_by_id_request_test()
        {

            var  result= _service.GetById(1);
            Clinic clinic=  result.Data;
            Assert.Equal("Cerrahi Maske",clinic.Name);
        }
    }
}
