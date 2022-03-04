using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EMyShop.Data.EF
{
    public class EShopDBContextFactory : IDesignTimeDbContextFactory<EShopDBContext>
    {
        public EShopDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("Appsetting.json")
            .Build();

            var connectionstring = configurationRoot.GetConnectionString("EMyShopDB");

            var optionbuilder = new DbContextOptionsBuilder<EShopDBContext>();
            optionbuilder.UseSqlServer(connectionstring);
            return new EShopDBContext(optionbuilder.Options);
        }
    }
}
