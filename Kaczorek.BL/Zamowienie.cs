using System;
using System.Collections.Generic;


namespace Kaczorek.BL
{
    public class Zamowienie
    {
        public Zamowienie()
        {

        }
        public Zamowienie(int zamowienieID)
        {
            ZamowienieId = zamowienieID;
        }
        public int ZamowienieId { get; private set; }
        public DateTimeOffset? DataZamowienia { get; set; }



        //Metody
        public bool Zwaliduj()
        {
            var poprawne = true;
            if (DataZamowienia==null)
                poprawne = false;
           
            return poprawne;
        }
        /// <summary>
        /// Zapisuje dane zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // kod który zapisuje zdefiniowane zamowienie
            return true;
        }
        /// <summary>
        /// Pobieramy jednego klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            //kod który pobiera określonego klienta
            return new Zamowienie();
        }
        /// <summary>
        /// Pobieramywszystkie zamowienia
        /// </summary>
        /// <returns></returns>
        public List<Zamowienie> Pobierz()
        {
            //kod pobiera wszystkich klientów
            return new List<Zamowienie>();
        }
    }
}
