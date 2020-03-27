using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kaczorek.BL
{
    public class KlientRepository
    {

        private AdresRepository adresRepository { get; set; }

        public KlientRepository()
        {
            adresRepository = new AdresRepository();
        }

       
        /// <summary>
        /// Pobieramy jednego klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            //Tworzymy instancję klasy klienta
            Klient klient = new Klient(klientId);
            klient.ListaAdresow = adresRepository.PobierzPoKlientId(klientId).ToList();


            //kod który pobiera określonego klienta

            //tymczasowo zakodowane wartosci zeby zwrocic klienta
            if (klientId==1)
            {
                klient.Email = "marcin@dev-hobby.pl";
                klient.Imie = "Marcin";
                klient.Nazwisko = "Kowal";
                
            }


            return klient;
        }
        /// <summary>
        /// Pobieramy wszystkich klientów
        /// </summary>
        /// <returns></returns>
        public List<Klient> Pobierz()
        {
            //kod pobiera wszystkich klientów
            return new List<Klient>();
        }


        /// <summary>
        /// Zapisuje klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Klient klient)
        {
            // kod który zapisuje zdefiniowanego Produkt
            var sukces = true;
            if (klient.MaZmiany && klient.DanePrawidlowe)
            {
                if (klient.JestNowy)
                {
                    //wywołaj procedure insert
                }
                else
                {
                    //wywolac procedure update
                }
            }


            return sukces;
        }
    }
}
