﻿using PhotoStudio.Data.Model;
using PhotoStudio.Data.Requests.Korisnik;
using PhotoStudio.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;



namespace PhotoStudio.MobileApp.ViewModels
{
    public class RegistracijaViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Korisnik");


        public ICommand RegisterCommand { get; set; }
        public RegistracijaViewModel()
        {
            RegisterCommand = new Command(async () => await Registracija());
        }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public int GradId = 1;
        // grad nije vezan za korisnika nego za studio u kojem se nalazi

        public async Task Registracija()
        {
            try
            {
                if (Password != PasswordConfirm)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti dva ista passworda", "OK");
                    return;
                }


                if (string.IsNullOrEmpty(Ime) || string.IsNullOrEmpty(Prezime) || string.IsNullOrEmpty(Telefon) || string.IsNullOrEmpty(Email)
                    || string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(PasswordConfirm))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Sva polja su obavezna", "OK");
                    return;
                }

                var korisnici = await _service.GetRegistracija<List<Data.Model.Korisnik>>(null);

                foreach (var item in korisnici)
                {
                    if (item.Username == Username)
                    {
                        await Application.Current.MainPage.DisplayAlert("Greška", "Username je zauzet, unesite drugo ime", "OK");
                        return;
                    }
                    if (item.Email == Email)
                    {
                        await Application.Current.MainPage.DisplayAlert("Greška", "Email je već u upotrebi", "OK");
                        return;
                    }
                    if (item.Telefon == Telefon)
                    {
                        await Application.Current.MainPage.DisplayAlert("Greška", "Uneseni broj telefona je već u upotrebi", "OK");
                        return;
                    }
                }


                var request = new KorisnikUpsert
                {
                    Ime = Ime,
                    Prezime = Prezime,
                    Telefon = Telefon,
                    Email = Email,
                    GradId = GradId,
                    Username = Username,
                    Password = Password,
                    PasswordConfirm = PasswordConfirm,
                    TipKorisnikaId = 2
                };

                var korisnik = await _service.SignUp<Data.Model.Korisnik>(request);
                if (korisnik != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste izvršili registraciju", "Logiraj se");
                    await Application.Current.MainPage.Navigation.PushModalAsync(new LoginPage());
                }
            }
            catch (Exception err)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Registracija neuspješna", "OK");
            }
        }

    }
}
