﻿using System;
using System.Collections.Generic;
using Kaczorek.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaczorek.BLTest
{
    [TestClass]
    public class ZamowienieRepositoryTest
    {
        [TestMethod]
        public void PobierzZamowienieTest()
        {
            //Arrange
            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwane = new Zamowienie(10)
            {
                DataZamowienia = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0))
            };
            //Act

            var aktualne = zamowienieRepository.Pobierz(10);

            //Assert
            Assert.AreEqual(oczekiwane.ZamowienieId, aktualne.ZamowienieId);
            Assert.AreEqual(oczekiwane.DataZamowienia, aktualne.DataZamowienia);
           
        }

        [TestMethod]
        public void PobierzZamowienieDoWyswietleniaTest()
        {
            //Arrange
            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwane = new WyswietlanieZamowienia()
            {




                Imie = "Jacek",
                Nazwisko = "Kowal",
                DataZamowienia = new DateTimeOffset(2018, 5, 21, 12, 00, 00, new TimeSpan(5, 0, 0)),


                AdresDostawy = new Adres()
                {
                    AdresTyp = 2,
                    Ulica = "Mila",
                    Miasto = "Katowice",
                    Kraj = "Polska",
                    KodPocztowy = "44-400"
                },
                WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>()
            {

             new WyswietlaniePozycjiZamowienia()
                {
                    NazwaProduktu = "Stol",
                    CenaZakupu = 300.50M,
                    Ilosc = 10
                },
               new WyswietlaniePozycjiZamowienia()
                {
                    NazwaProduktu = "blat",
                    CenaZakupu = 50.330M,
                    Ilosc = 5
                }
                }
            };

            

            //Act

            var aktualne = zamowienieRepository.PobierzZamowienieDoWyswietlenia(10);

            //Assert
            Assert.AreEqual(oczekiwane.ZamowienieId, aktualne.ZamowienieId);
            Assert.AreEqual(oczekiwane.DataZamowienia, aktualne.DataZamowienia);
            Assert.AreEqual(oczekiwane.Imie, aktualne.Imie);
            Assert.AreEqual(oczekiwane.Nazwisko, aktualne.Nazwisko);

            Assert.AreEqual(oczekiwane.AdresDostawy.AdresTyp, aktualne.AdresDostawy.AdresTyp);
            Assert.AreEqual(oczekiwane.AdresDostawy.Ulica, aktualne.AdresDostawy.Ulica);
            Assert.AreEqual(oczekiwane.AdresDostawy.Miasto, aktualne.AdresDostawy.Miasto);
            Assert.AreEqual(oczekiwane.AdresDostawy.KodPocztowy, aktualne.AdresDostawy.KodPocztowy);
            Assert.AreEqual(oczekiwane.AdresDostawy.Kraj, aktualne.AdresDostawy.Kraj);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwane.WyswietlaniePozycjiZamowieniaLista[i].NazwaProduktu, aktualne.WyswietlaniePozycjiZamowieniaLista[i].NazwaProduktu);
                Assert.AreEqual(oczekiwane.WyswietlaniePozycjiZamowieniaLista[i].Ilosc, aktualne.WyswietlaniePozycjiZamowieniaLista[i].Ilosc);
                Assert.AreEqual(oczekiwane.WyswietlaniePozycjiZamowieniaLista[i].CenaZakupu, aktualne.WyswietlaniePozycjiZamowieniaLista[i].CenaZakupu);

            }
        }

    }
}
