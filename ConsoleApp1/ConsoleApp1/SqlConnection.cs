using System;

namespace ConsoleApp1
{
    public class SqlConnection : DbConnection {
        public SqlConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Sql is Open");
        }
        public override void Close()
        {
            Console.WriteLine("Sqp is close");
        }

    }
}
