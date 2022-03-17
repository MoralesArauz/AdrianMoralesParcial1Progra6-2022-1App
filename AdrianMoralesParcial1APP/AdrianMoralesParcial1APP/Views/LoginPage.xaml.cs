using AdrianMoralesParcial1APP.ViewModels;
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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        public void CmdSeePassword(object sender, ToggledEventArgs e)
        {
            TxtPassword.IsPassword = !SwSeePassword.IsToggled;
        }

        private async void CmdUserRegister(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActivoSave());
        }
    }
}