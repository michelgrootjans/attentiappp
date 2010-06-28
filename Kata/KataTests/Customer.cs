using System;

namespace KataTests
{
    public class Customer : ICustomer
    {

        public void AddVerlofDagen(int aantalVerlofdagen)
        {
            if(VerlofDagenBeschikbaar < aantalVerlofdagen)
                throw new ArgumentException();
            VerlofDagenBeschikbaar -= aantalVerlofdagen;
        }

        public int VerlofDagenBeschikbaar { get; set; }
    }
}