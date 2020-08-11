using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TestAPIUsingWebApplicationFactory.Data;

namespace Products.API.Tests
{
    public class InMemoryWebApplicationFactory<T>: WebApplicationFactory<T> where T:class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.UseEnvironment("Testing")
                   .ConfigureTestServices(services =>
                   {
                       var options = new DbContextOptionsBuilder<ProductDbContext>()
                                                              .UseInMemoryDatabase("testMemory").Options;

                       var serviceProvider = services.BuildServiceProvider();
                       var db =serviceProvider.GetRequiredService<ProductDbContext>();
                       db.Database.EnsureCreated();

                   });
        }
    }
}
