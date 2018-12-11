
using System;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace NipponDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(); // View Model Binding
        }

        void SimulateCrash(object sender, System.EventArgs e)
        {
            Crashes.GenerateTestCrash();
        }

        void SimulateError(object sender, System.EventArgs e)
        {
            try
            {
                throw new System.NullReferenceException();
            }
            catch (NullReferenceException ex)
            {
                Crashes.TrackError(ex);
            }
        }
    }
}
