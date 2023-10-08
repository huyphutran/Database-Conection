using System;

namespace ConsoleApp1
{
    public class DbCommand
    {
        private readonly DbConnection _dbconnection;
        public DbConnection Dbconnection => _dbconnection;

        private readonly string _instruction;

        internal DbCommand(string instruction, DbConnection dbConnection)
        {
            if (string.IsNullOrEmpty(_instruction))
                Console.WriteLine("Command Status {0}", instruction);
            _instruction = instruction;
            _dbconnection = dbConnection;
        }


        public void Execute()
        {
            Dbconnection.Open();
            Console.WriteLine("Running the instruction");
            Dbconnection.Close();
        }
    }
}
