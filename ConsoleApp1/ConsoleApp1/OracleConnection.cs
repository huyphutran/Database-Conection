using System;

namespace ConsoleApp1
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {
            Console.WriteLine("Connect String is initialize: {0}", connectionString);
        }
        public override void Open()
        {
            Console.WriteLine("Oracle DataBase is Open");
        }
        public override void Close() {

            Console.WriteLine("Ocracle DataBase is Close");
        }
    }
}
