using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConection
{
    class SqlConnection:DbConnection
    {

        public SqlConnection(string connectionString): base(connectionString)
        {
            
        }

        public SqlConnection(string connectionString, TimeSpan timeOut) : base(connectionString,timeOut)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("You Opened a SQL Connection");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("You Closed a SQL Connection");

        }
    }
}
