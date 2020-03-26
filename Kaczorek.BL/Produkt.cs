﻿using System;
using System.Collections.Generic;


namespace Kaczorek.BL
{
    public class Produkt
    {
        public Produkt()
        {

        }
        public Produkt(int produktId)
        {
            ProduktId = produktId;
        }

        public int ProduktId { get; private set; }

        public Decimal? AktualnaCena { get; set; }
        public string Opis { get; set; }
        public string NazwaProduktu { get; set; }


        //Metody
        /// <summary>
        /// Sprawdza dane produktu
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;
            if (string.IsNullOrWhiteSpace(NazwaProduktu))
                poprawne = false;
            if (AktualnaCena == null)
                poprawne = false;
            return poprawne;
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
        /// <summary>
        /// Pobieramy jednen produkt
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            //kod który pobiera określonny produkt
            return new Produkt();
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


    }
}