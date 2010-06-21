namespace Copy
{
    public class Copier
    {
        public void Copy()
        {
            int c;
            while ((c = Keyboard.Read()) != -1)
            {
                Printer.Write(c);
            }
        }
    }
}
