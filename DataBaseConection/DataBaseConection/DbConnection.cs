using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
            {
                throw new Exception("The String you passed is null or empty.");
            }
            this.ConnectionString = connectionString;
        }

        public DbConnection(string connectionString ,TimeSpan timeOut)
            :this(connectionString)
        {
            this.Timeout = timeOut;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
       


    }
}
