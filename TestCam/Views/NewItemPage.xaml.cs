using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestCam.Models;
using TestCam.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCam.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}