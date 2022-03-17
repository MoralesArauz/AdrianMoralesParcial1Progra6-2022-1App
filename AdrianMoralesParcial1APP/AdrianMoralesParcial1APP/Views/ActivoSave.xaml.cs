using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdrianMoralesParcial1APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivoSave : ContentPage
    {
        public ActivoSave()
        {
            InitializeComponent();
        }

        private async void CmdRegisterAsset(object sender, EventArgs e)
        {
            await DisplayAlert("Éxito!", "Se ha registrado el Activo", "OK");
        }

        private async void CmdCancelRegister(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}