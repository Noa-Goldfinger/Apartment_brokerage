
using ApartmentBrokerage;
using Solid.Core.Repositories;
using Solid.Core.Service;
using Solid.Data;
using Solid.Data.Repositories;
using Solid.Service.services;

namespace ApartmentBrokerage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IApartmentService, ApartmentService>();
            builder.Services.AddScoped<IApartmentOwnerService, ApartmentOwnerService>();
            builder.Services.AddScoped<IClientService, ClientService>();
            builder.Services.AddScoped<IApartmentRepository,ApartmentRepository>();
            builder.Services.AddScoped<IApartmentOwnerRepository, ApartmentOwnerRepository>();
            builder.Services.AddScoped<IClientRepository,ClientRepository>();
            builder.Services.AddSingleton<DataContext>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}