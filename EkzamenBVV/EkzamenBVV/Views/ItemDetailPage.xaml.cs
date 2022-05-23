using EkzamenBVV.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace EkzamenBVV.Views
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