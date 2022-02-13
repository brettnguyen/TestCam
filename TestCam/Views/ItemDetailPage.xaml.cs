using System.ComponentModel;
using TestCam.ViewModels;
using Xamarin.Forms;

namespace TestCam.Views
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