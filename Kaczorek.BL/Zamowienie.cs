using System;
using System.Collections.Generic;
using Common;

namespace Kaczorek.BL
{
    public class Zamowienie: KlasaBazowa, ILogowanie

    {
        #region konstruktory
        public Zamowienie()
        {

        }
        public Zamowienie(int zamowienieID)
        {
            ZamowienieId = zamowienieID;
        }

        #endregion

        #region własciwości
        public int ZamowienieId { get; private set; }
        public DateTimeOffset? DataZamowienia { get; set; }
        public List<PozycjaZamowienia> PozycjaZamowienia { get; set; }
        public int KlientId { get; set; }
        public int AdresDostawyId { get; set; }

        
        #endregion


        #region Metody
        //Metody
        public override bool Zwaliduj()
        {
            var poprawne = true;
            if (DataZamowienia == null)
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
        public override string ToString()
        {
            return DataZamowienia.Value.Date + "(" + ZamowienieId + ")";
        }

        public string Log()
        {
            var log = ZamowienieId + ": " + "Data : " + DataZamowienia.Value.Date + " " + "Status : " + StanObiektu.ToString();

            return log;
        }

        #endregion
    }
}






