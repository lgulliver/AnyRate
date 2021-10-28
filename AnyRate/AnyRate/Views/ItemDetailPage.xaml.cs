using AnyRate.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AnyRate.Views
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