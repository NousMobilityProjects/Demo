
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
    }
}
