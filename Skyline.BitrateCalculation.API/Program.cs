
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Skyline.BitrateCalculation.API.Database;
using Skyline.BitrateCalculation.API.Services.IRepository;
using Skyline.BitrateCalculation.API.Services.Repository;

namespace Skyline.BitrateCalculation.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<BirateCalculationDbContext>(o => o.UseInMemoryDatabase("BirateCalculationDb"));
            builder.Services.AddScoped<IVideoRepository, VideoRepository>();

            builder.Services.AddAutoMapper(typeof(Program));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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