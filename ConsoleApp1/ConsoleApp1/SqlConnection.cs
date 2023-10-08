using System;

namespace ConsoleApp1
{
    public class SqlConnection : DbConnection {
        public SqlConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {
            Console.WriteLine("Connect String is initialize: {0}", connectionString);
        }

        public override void Open()
        {
            Console.WriteLine("Sql DataBase is Open");
        }
        public override void Close()
        {
            Console.WriteLine("Sql DataBase is close");
        }

    }
}
