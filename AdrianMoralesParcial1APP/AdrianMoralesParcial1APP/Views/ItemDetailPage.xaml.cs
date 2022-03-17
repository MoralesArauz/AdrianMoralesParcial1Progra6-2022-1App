using AdrianMoralesParcial1APP.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AdrianMoralesParcial1APP.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}