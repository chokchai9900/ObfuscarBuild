using ObfuscarBuild.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ObfuscarBuild.Views
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