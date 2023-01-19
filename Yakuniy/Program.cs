using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Yakuniy.Api.Extensions;
using Yakuniy.Infrastract.Contexts;
using Yakuniy.Infrastract.EntityTypeConfigurations;

namespace Yakuniy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services
           .AddDbContexts(builder.Configuration);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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