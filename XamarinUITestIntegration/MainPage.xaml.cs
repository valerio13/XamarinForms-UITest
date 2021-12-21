using System;
using Xamarin.Forms;

namespace XamarinUITestIntegration
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }
}
