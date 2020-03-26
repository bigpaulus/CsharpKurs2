using System;
using System.Collections.Generic;
using System.Text;
using Kaczorek.BL;

namespace Kaczorek.BL
{
    public class AdresRepository
    {


        /// <summary>
        /// Pobieramy jeden adres.
        /// </summary>
        /// <param name="adresId"></param>
        /// <returns></returns>
        public Adres Pobierz(int adresId)
        {
            //Tworzymy instancje klasy Adres i przekazujemy żądany identyfikator
            Adres adres = new Adres(adresId);

            //kod który pobiera zdefiniowany adres

            //tymczasowo zakodowane wartosci do zwrócenia adresu
            if (adresId == 1)
            {
                adres.AdresTyp = 1;
                adres.Ulica = "Gościnna";
                adres.Miasto = "Katowice";
                adres.Kraj = "Polska";
                adres.KodPocztowy = "40-467";

            }
            return adres;
        }

        public IEnumerable<Adres> PobierzPoKlientId(int klientId)
        {
            //Kod, który pobiera zdefiniowane adresy klienta

            //tymczasowo zakodowane waetości do zwrócenia , zestsaw adresów
            var listaAdresow = new List<Adres>();
            Adres adres = new Adres(1)
            {
                AdresTyp = 1,
                Ulica = "Adama",
                Miasto = "Opole",
                Kraj = "Polska",
                KodPocztowy = "11-100"

            };
            listaAdresow.Add(adres);

            adres = new Adres(2)
            {
                AdresTyp = 3,
                Ulica = "Miła",
                Miasto = "Katowice",
                Kraj = "Polska",
                KodPocztowy = "44-400"

            };
            listaAdresow.Add(adres);

            return listaAdresow;
        }



        /// <summary>
        /// Zapisuje aktualny adres
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Adres adres)
        {
            // kod który zapisuje zdefiniowany adres.
            return true;
        }


    }

}
