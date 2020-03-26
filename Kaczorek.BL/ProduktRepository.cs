using System;
using System.Collections.Generic;
using System.Text;

namespace Kaczorek.BL
{
    public class ProduktRepository
    {
       
        /// <summary>
        /// Pobieramy jednen produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)

        {
            //tworzenie instancji produktu
            Produkt produkt = new Produkt(produktId);

            //kod który pobiera określonny produkt

            //tymczasowo zakodowane wartosci,aby zwrocic produkt
            if (produktId == 5)
            {
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "Klocki dla dzieci";
                produkt.AktualnaCena = 89.99M;
            }

            return produkt;
        }
        /// <summary>
        /// Pobieramy wszystkie produkty
        /// </summary>
        /// <returns></returns>
        public List<Produkt> Pobierz()
        {
            //kod pobiera wszystkich klientów
            return new List<Produkt>();
        }
        /// <summary>
        /// Zapisuje Produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // kod który zapisuje zdefiniowanego Produkt
            return true;
        }
    }
}
