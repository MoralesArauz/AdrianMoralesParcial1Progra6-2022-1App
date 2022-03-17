using AdrianMoralesParcial1APP.ViewModels;
using AdrianMoralesParcial1APP.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AdrianMoralesParcial1APP
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
