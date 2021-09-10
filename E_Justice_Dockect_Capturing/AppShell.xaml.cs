using E_Justice_Dockect_Capturing.ViewModels;
using E_Justice_Dockect_Capturing.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace E_Justice_Dockect_Capturing
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
