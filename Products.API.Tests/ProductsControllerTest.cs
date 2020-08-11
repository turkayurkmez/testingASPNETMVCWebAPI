using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestAPIUsingWebApplicationFactory;
using TestAPIUsingWebApplicationFactory.Models;
using Xunit;

namespace Products.API.Tests
{
    public class ProductsControllerTest: IClassFixture<InMemoryWebApplicationFactory<Startup>>
    {
        private InMemoryWebApplicationFactory<Startup> factory;

        public ProductsControllerTest(InMemoryWebApplicationFactory<Startup> factory)
        {
            this.factory = factory;
        }
        [Fact]
        public async Task web_api_basari_testi()
        {
            var client =  factory.CreateClient();
            var response = await client.GetAsync("/api/products");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }
        [Fact]
        public async Task post_request_test()
        {
            var product = new Product
            {
                Name = "TestName",
                Price = 5,
                Stock = 1500
            };

            var client = factory.CreateClient();
            var httpContent = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");
            var response  = await client.PostAsync("/api/products", httpContent);

            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }
    }
}
