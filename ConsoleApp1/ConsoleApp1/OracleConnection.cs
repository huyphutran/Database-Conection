using System;

namespace ConsoleApp1
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {
        }
        public override void Open()
        {
            Console.WriteLine("Oracle is Open");
        }
        public override void Close() {

            Console.WriteLine("Ocracle is Close");
        }
    }
}
