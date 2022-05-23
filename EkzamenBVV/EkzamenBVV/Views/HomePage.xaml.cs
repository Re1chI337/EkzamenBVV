using EkzamenBVV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EkzamenBVV.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (entryText.Text != null)
            {
                await App.DataBase.SaveTimeAsync(new Time() { Title = entryText.Text,});
                lableResult.Text = "Успех!";
            }
        }
    }
}