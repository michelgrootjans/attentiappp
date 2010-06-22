using Sim_U_Duck.Ducks;

namespace Sim_U_Duck.Tests
{
    public class TestWriter : IWriter
    {
        private string lastMessage;

        public string LastMessage
        {
            get { return lastMessage; }
        }

        public void Write(string message)
        {
            lastMessage = message;
        }
    }
}