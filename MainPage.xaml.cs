using Lan_Calculator_App.ViewModels;

namespace Lan_Calculator_App
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();

            BindingContext = vm;
        }
    }
}
