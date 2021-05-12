using ObfuscarBuild.ViewModels;
using ObfuscarBuild.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ObfuscarBuild
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
