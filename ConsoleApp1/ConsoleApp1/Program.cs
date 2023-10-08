using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbConnection sqlConnection = new SqlConnection("SQL Server Connection",TimeSpan.FromSeconds(5));
            DbCommand sqpcommand = new DbCommand("select * from customer",sqlConnection);
            sqpcommand.Execute();


            DbConnection oracleConnection = new OracleConnection("Oracle Connection String",TimeSpan.FromSeconds(5));
            sqpcommand = new DbCommand("select * from customer", oracleConnection);
            sqpcommand.Execute();

        }
    }
}
