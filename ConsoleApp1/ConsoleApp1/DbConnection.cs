using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        private readonly TimeSpan _timeout;

        public string ConnectionString => _connectionString;
        public TimeSpan Timeout => _timeout;

        public DbConnection(string connectionString, TimeSpan timeout)
        {
            if (string.IsNullOrEmpty(connectionString))
            
                this._connectionString = connectionString;
                this._timeout = timeout;
        }


        public abstract void Open();
        public abstract void Close();



    }
}
