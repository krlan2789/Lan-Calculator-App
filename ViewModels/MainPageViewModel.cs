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
        private string _expressionDisplay = "";

        [ObservableProperty]
        private string _resultDisplay = "";

        public MainPageViewModel()
        {
            ExpressionDisplay = "";
            ResultDisplay = "0";
        }

        [RelayCommand]
        private void OnButtonClicked(string text)
        {
            Debug.WriteLine(text);
            ExpressionDisplay += text;
        }
    }
}
