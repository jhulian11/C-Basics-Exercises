
using System;

namespace DataBaseConection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlDb = new SqlConnection("asdsadas");
            var oracleConnection = new OracleConnection("dasdasdadasda");

            sqlDb.OpenConnection();
            sqlDb.CloseConnection();

            oracleConnection.OpenConnection();
            oracleConnection.CloseConnection();

            Console.WriteLine("Teste 2 \n\n\n");

            Console.WriteLine("Type the Data Base Command below: ");
            var input = Console.ReadLine();

            var dbCommandSQL = new DbCommand(sqlDb,input);
            var dbCommandOracle = new DbCommand(oracleConnection,input);

            dbCommandSQL.Execute();
            dbCommandOracle.Execute();



        }
    }
}
