using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class DetailRepositoriy: IDetailRepositoriy
    {
        public IEnumerable<Detail> GetDetail()
        {
            //string connectionString = @"Data Source=.\SQLSERVER;Initial Catalog=CarDetails;Integrated Security=True";
            var query = "SELECT * FROM Details";
            var result = new List<Detail>();

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
                        result.Add(new Detail
                        {
                            Id = (int)reader["Id"],
                            NameDetail = (string)reader["NameDetail"],
                            Number = (int)reader["Number"],
                            CarId = (int)reader["CarId"]
                        });
                    }
                }
                connection.Close();

                return result;
            }
        }

    }
}
