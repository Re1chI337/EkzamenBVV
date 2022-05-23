using EkzamenBVV.ViewModels;
using EkzamenBVV.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace EkzamenBVV
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
