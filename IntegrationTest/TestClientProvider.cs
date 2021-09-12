using CustomerAPI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace IntegrationTest
{
    public class TestClientProvider
    {
        public virtual HttpClient Client { get; set; }

        public TestClientProvider()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            
           
            Client = server.CreateClient();
            Client.DefaultRequestHeaders.Add("Accept-Language", "en-GB,en-US;q=0.8,en;q=0.6,ru;q=0.4");
            Client.BaseAddress = new Uri("https://localhost:44352");
        
        }
    }
}
