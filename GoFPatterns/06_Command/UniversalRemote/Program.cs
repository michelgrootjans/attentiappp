using System;

namespace UniversalRemote
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var remote = new Remote();

                Console.Write("What button do you want to press:");
                var buttonNumber = Convert.ToInt32(Console.ReadLine());
                remote.PushOnButton(buttonNumber);
                remote.PushOffButton(buttonNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}