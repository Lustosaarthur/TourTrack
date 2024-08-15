
using Microsoft.EntityFrameworkCore;
using TourTrack.Api.Persistence;
using TourTrack.Api.Repositories.Main;

namespace TourTrack.Api
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("TourTrackCS");
            // Add services to the container.
            
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                    });
            });
            builder.WebHost.UseUrls("http://0.0.0.0:5033", "https://0.0.0.0:7133");
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddDbContext<TourTrackDbContext>(o => o.UseSqlServer(connectionString));
            builder.Services.AddSwaggerGen();
            
            builder.Services.AddScoped<IAttractionRepository, AttractionRepository>();
            builder.Services.AddScoped<ICountryRepository, CountryRepository>();
            builder.Services.AddScoped<IAccommodationRepository, AccommodationRepository>();
          
           
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("AllowAllOrigins");
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();

            
        }
    }
}
