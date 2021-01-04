using System;
using FoodAppContracts.Interface;

namespace FoodAppContracts
{
    public class ProductionDbContextConnectionString : IConnectionString
    {
        public ProductionDbContextConnectionString()
        {
            ConnectionString =
                "SERVER=localhost; DATABASE=project; UID=root; PASSWORD=dekel123;";
        }
        public ProductionDbContextConnectionString(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public string ConnectionString { get; }
    }
}
