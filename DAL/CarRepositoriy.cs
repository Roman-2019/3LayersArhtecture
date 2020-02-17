using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public static class ConstString
    {
        public const string connectionString = @"Data Source=.\SQLSERVER;Initial Catalog=CarDetails;Integrated Security=True";
    }

    public class CarRepositoriy : ICarRepositoriy
    {
        public IEnumerable<Car> GetCar()
        {
            //var query = "SELECT Cars.Name, Details.NameDetail, Details.Number FROM Details, Cars WHERE Details.CarId=Cars.Id AND Details.CarId=1";
            var query = "SELECT * FROM Cars";
            var result = new List<Car>();

            SqlConnection connection = new SqlConnection(ConstString.connectionString);

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(new Car
                        {
                            Id = (int)reader["Id"],
                            Name = (string)reader["Name"],
                            //Details = (ICollection<Detail>)reader["Details"]

                        });
                    }
                }
                connection.Close();

                return result;
            }
        }
    }
}
