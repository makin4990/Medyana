using FluentAssertions;
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

            using (var client =  new TestClientProvider().Client)
            {
                var response = await client.GetAsync("https://localhost:44352/api/clinics/getallclinics");

                response.EnsureSuccessStatusCode();

                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
        }
    }
}
