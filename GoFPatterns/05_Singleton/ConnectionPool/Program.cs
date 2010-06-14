using System;

namespace ConnectionPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Connection connection = new Connection();
                connection.Open();
                //Do something useful here
                connection.Close();
            }
            Console.ReadLine();
        }
    }
}
