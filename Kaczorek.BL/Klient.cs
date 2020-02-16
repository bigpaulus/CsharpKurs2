﻿using System;

namespace Kaczorek.BL
{
    public class Klient
    {
        private string _nazwisko;

        public string Nazwisko
        {
            get
            {
                // tutaj możemy dodać dowolny kod
                return _nazwisko;
            }
            set
            {
                // tutaj możemy dodać dowolny kod
                _nazwisko = value;
            }
        }

        public string Imie { get; set; }

        public string Email { get; set; }

        public int KlientId { get; private set; }

        public string ImieNazwisko
        {
            get
            {
                string imieNazwisko = Imie;

                if (!string.IsNullOrWhiteSpace(Nazwisko))
                {
                    if (!string.IsNullOrWhiteSpace(imieNazwisko))
                    {
                        imieNazwisko += ", ";
                    }
                    imieNazwisko += Nazwisko;
                }
                return imieNazwisko;
            }
        }
    }
}