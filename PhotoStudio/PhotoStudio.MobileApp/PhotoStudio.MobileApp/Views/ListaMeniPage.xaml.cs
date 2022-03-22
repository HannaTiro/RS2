﻿using PhotoStudio.MobileApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhotoStudio.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class ListaMeniPage : ContentPage
    {
        PocetniPage pocetnaStranica { get => Application.Current.MainPage as PocetniPage; }
        List<HomeMenuItem> menuItems;
        public ListaMeniPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem{Id=MenuItemType.Fotografi,Title="Fotografi"},
                new HomeMenuItem {Id = MenuItemType.Rezervacije, Title="Moje rezervacije" },
                new HomeMenuItem {Id = MenuItemType.Komentari, Title=" Moji komentari" },
                new HomeMenuItem {Id = MenuItemType.Ocjene, Title=" Moje ocjene"},
                new HomeMenuItem{Id=MenuItemType.Novosti,Title="Novosti"},
                new HomeMenuItem{Id=MenuItemType.PosebnaPonuda,Title="Posebne ponude"},
                new HomeMenuItem{Id=MenuItemType.Usluga,Title="Dodatne usluge studija"},

                new HomeMenuItem{Id=MenuItemType.PostavkeProfila,Title="Moj profil"},
                new HomeMenuItem{Id=MenuItemType.LogOut,Title="Odjavi se"}
            };
            ListViewMenu.ItemsSource = menuItems;
            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await pocetnaStranica.NavigateFromMenu(id);
            };
        }
    }
}