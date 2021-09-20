using FluentAssertions;
using Shouldly;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTest
{
    public class ClinicIntegrationTest
    {
        [Fact]
        public async Task Test_Get_All()
        {

        

            var webClient = new WebClient();
            var result = webClient.DownloadString("https://localhost:44352/api/clinics/getclinicbyid?clinicid=1");
            result.ShouldBe("{\"data\":{\"id\":1,\"name\":\"Acil Servis\",\"equipments\":[]},\"success\":true,\"message\":\"Klinik listelendi\"}");
        }
    }
}

