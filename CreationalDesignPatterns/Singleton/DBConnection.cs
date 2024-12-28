using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Singleton
{
    public sealed class DBConnection
    {
        private static IDbConnection? _instance;
        private readonly string _connectionString;
        private DBConnection() {

            _connectionString = "connection_string";
        }

        public static IDbConnection GetDBConnection()
        {
            Console.WriteLine("Database Connection Initilized");
            if (_instance == null)
            {
                //_instance = new SqlConnection(_connectionString);
                return _instance;
            }
            return _instance;

        }

    }
}
