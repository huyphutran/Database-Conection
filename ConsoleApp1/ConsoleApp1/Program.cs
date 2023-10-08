using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static bool inPostMode = true;
        static void Main(string[] args)
        {
            ShowMenu();
        }

        static void runSqlDB()
        {
            DbConnection sqlConnection = new SqlConnection("SQL Server Connection", TimeSpan.FromSeconds(5));
            DbCommand sqpcommand = new DbCommand("select * from customer ", sqlConnection);
            sqpcommand.Execute();
        }
        static void runOracleDB()
        {
            DbConnection oracleConnection = new OracleConnection("Oracle Connection String", TimeSpan.FromSeconds(5));
            DbCommand sqpcommand = new DbCommand("select * from customer ", oracleConnection);
            sqpcommand.Execute();
        }

        static void ShowMenu()
        {
            Console.WriteLine("Welcome to DBConection");
            Console.WriteLine("Press A to Connect to Sql DB");
            Console.WriteLine("Press D to  Connect to Orace DB");

            while (inPostMode)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                char key = char.ToUpper(consoleKeyInfo.KeyChar);
                switch (key)
                {
                    case 'A':
                        ClearandSleep();
                        inPostMode = true;
                        runSqlDB();
                        Console.WriteLine("Press S to Back");
                        break;
                    case 'D':
                        ClearandSleep();
                        inPostMode = true;
                        runOracleDB();
                        Console.WriteLine("Press S to Back");
                        break;
                    case 'S':
                        ClearandSleep();
                        inPostMode = true;
                        ShowMenu();
                        break;
                    default:
                        Console.WriteLine(". Invalid command");
                        break;
                }
            }
        }


         static void ClearandSleep()
        {
            Thread.Sleep(1000);
            Console.Clear();
        }
    }


}
