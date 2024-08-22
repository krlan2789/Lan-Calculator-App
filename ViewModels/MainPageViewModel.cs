using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lan_Calculator_App.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _expressionDisplay = string.Empty;

        [ObservableProperty]
        private string _resultDisplay = string.Empty;

        public MainPageViewModel()
        {
            ExpressionDisplay = "4 + 8";
            ResultDisplay = "12";
        }

        [RelayCommand]
        public void OnButtonClicked(string buttonText)
        {
            Debug.WriteLine(buttonText);
            ExpressionDisplay += buttonText;
        }
    }
}
