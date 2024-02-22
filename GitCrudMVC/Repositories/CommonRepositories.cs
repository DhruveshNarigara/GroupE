using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace GitCrudMVC.Repositories
{
    public class CommonRepositories
    {
        protected NpgsqlConnection conn;
    
        

        public CommonRepositories()
        {
            
            IConfiguration myConfig = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            conn = new NpgsqlConnection(myConfig.GetConnectionString("DefaultConnection"));
        }
    }
}