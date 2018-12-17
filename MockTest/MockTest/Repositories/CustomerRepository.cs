using Microsoft.Extensions.Configuration;
using MockTest.Models;
using System.Data.SqlClient;

namespace MockTest.Repositories
{
    public class CustomerRepository : ICustomerRepository
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
