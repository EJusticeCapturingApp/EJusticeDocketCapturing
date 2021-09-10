using E_Justice_Dockect_Capturing.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace E_Justice_Dockect_Capturing.Views
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