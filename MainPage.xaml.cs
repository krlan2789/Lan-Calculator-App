using Lan_Calculator_App.ViewModels;

namespace Lan_Calculator_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();

            BindingContext = vm;
        }
    }
}
