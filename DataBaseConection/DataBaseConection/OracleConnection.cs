using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConection
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }

        public OracleConnection(string connectionString, TimeSpan timeOut) : base(connectionString, timeOut)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("You Opened a Oracle Connection");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("You Closed a Oracle Connection");

        }
    }
}
