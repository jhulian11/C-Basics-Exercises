using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConection
{
    class DbCommand
    {
        public DbConnection DbConnection { get; set; }
        public string Command { get; set; }
        public DbCommand(DbConnection dbConnection,string command )
        {
            if (dbConnection == null)
            {
                throw new ArgumentNullException("The Connection path is null");
            }
            this.DbConnection = dbConnection;

            if (String.IsNullOrWhiteSpace(command))
            {
                throw new ArgumentNullException("The Command is null or empty");

            }
            this.Command = command;
        }

        public void Execute()
        {
            DbConnection.OpenConnection();
            Console.WriteLine("The Command {0} was Executed.", Command);
            DbConnection.CloseConnection();
        }

    }
}
