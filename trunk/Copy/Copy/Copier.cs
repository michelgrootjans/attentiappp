namespace Copy
{
    public class Copier
    {
        public static void Copy()
        {
            int c;
            while ((c = Keyboard.Read()) != -1)
            {
                Printer.Write(c);
            }
        }
    }
}
