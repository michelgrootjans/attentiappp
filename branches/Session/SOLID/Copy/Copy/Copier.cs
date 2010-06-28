namespace Copy
{
    public class Copier
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        public Copier()
        {
            //default implementation
            reader = new Keyboard();
            writer = new Printer();
        }

        public Copier(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Copy()
        {
            int c;
            while ((c = reader.Read()) != -1)
            {
                writer.Write(c);
            }
        }
    }
}
