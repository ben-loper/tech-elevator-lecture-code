using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using VendingService;
using VendingService.Database;
using VendingService.File;

namespace VndrCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");
            var db = new VendingDBService(connectionString);
            var log = new LogFileService();
            VendingMachine vm = new VendingMachine(db, log);
            VndrCLI cli = new VndrCLI(vm);
            cli.Run();
        }
    }
}
