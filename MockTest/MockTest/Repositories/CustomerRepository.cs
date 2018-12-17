using Microsoft.Extensions.Configuration;
using MockTest.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MockTest.Repositories
{
    public class CustomerRepository
    {
        private readonly IConfiguration _configuration;

        public CustomerRepository(IConfiguration configuration )
        {
            _configuration = configuration;
        }

        public void Save(CustomerModel model)
        {
            var connectionString = _configuration.GetConnectionString("default");
            using (var connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandText = "usp_SaveCustomerData";
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
