﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CustomerAppBLL;

namespace CustomerRestAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.WithOrigins("http://http://localhost:4200")
                .AllowAnyMethod()
                .AllowAnyHeader();
            }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                var facade = new BLLFacade();
                /*
                var address = facade.AddressService.Create(
                    new AddressBO()
                    {
                        City = "Copenhagen",
                        Street = "Played Out Meme Street",
                        Number = "1337"
                    });
                var address2 = facade.AddressService.Create(
                    new AddressBO()
                    {
                        City = "New York",
                        Street = "Not Found Street",
                        Number = "404"
                    });

                var cust = facade.CustomerService.Create(
                    new CustomerBO()
                    {
                        FirstName = "Peder",
                        LastName = "Laugesen",
                        AddressIds = new List<int>() { address2.Id}
                    });

                facade.CustomerService.Create(
                    new CustomerBO()
                    {
                        FirstName = "John",
                        LastName = "Cena",
                        AddressIds = new List<int>() { address.Id }
                    });

                for (int i = 0; i < 5; i++)
                {
                    facade.OrderService.Create(
                    new OrderBO()
                    {
                        DeliveryDate = DateTime.Now.AddMonths(1),
                        OrderDate = DateTime.Now.AddMonths(-1),
                        CustomerId = cust.Id
                    });
                }*/
                
            }

            app.UseMvc();
        }
    }
}
