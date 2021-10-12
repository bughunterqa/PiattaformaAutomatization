/*using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace PiattaformaAutomatization.Data
{
    public partial class ApplicationContext : DbContext
    {


        public ApplicationContext(string connectionString)
                    : base(connectionString)
        {
           *//* var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder
                .UseSqlServer(config.GetConnectionString("DefaultConnection"))
                .Options;*//*
        }




    }
}
*/