using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkinghouse
{
    internal class DatabasDapper
    {
        static string connString = "data source=.\\SQLEXPRESS; initial catalog = Parking10; persist security info = True; Integrated Security = True;";

        public static List<Models.Cities> GetAllCities()
        {
            var sql = "SELECT * FROM Cities";
            List<Models.Cities> city = new List<Models.Cities>();
            using (var connection = new SqlConnection(connString))
            {
                city = connection.Query<Models.Cities>(sql).ToList();
            }
            return city;
        }
    }
}
