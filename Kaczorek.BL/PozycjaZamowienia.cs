using System;
using System.Collections.Generic;
using System.Text;

namespace Kaczorek.BL
{
    public class PozycjaZamowienia
    {
        public PozycjaZamowienia(int pozycjaZamowieniaId)
        {
            PozycjaZamowieniaId = PozycjaZamowieniaId;
        }

        public PozycjaZamowienia()
        {
        }

        public int PozycjaZamowieniaId { get; private set; }
        public int Ilosc { get; set; }
        public int ProduktId { get; set; }
        public decimal? CenaZakupu { get; set; }




        //Metody
        public bool Zwaliduj()
        {
            var poprawne = true;

            if (Ilosc<=0)
                poprawne = false;
            if (ProduktId <= 0)
                poprawne = false;
            if (CenaZakupu == 0)
                poprawne = false;
            return poprawne;
        }
        /// <summary>
        /// Zapisuje element zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // kod który zapisuje zdefiniowanego zamowienia
            return true;
        }
        /// <summary>
        /// Pobieramy jeden element zamowienia
        /// </summary>
        /// <param name="pozycjaZamowienieId"></param>
        /// <returns></returns>
        public PozycjaZamowienia Pobierz(int pozycjaZamowieniaId)
        {
            //kod który pobiera określonego klienta
            return new PozycjaZamowienia();
        }
        
    }
}
