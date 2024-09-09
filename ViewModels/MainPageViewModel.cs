using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

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
            if (text == "AC")
            {
                ExpressionDisplay = "";
            }
            else
            {
                if (text.Replace(" ", "") == "()")
                {
                    char lastChar = ExpressionDisplay.Length > 0 ? ExpressionDisplay[^1] : ' ';
                    if (string.IsNullOrEmpty(ExpressionDisplay) || IsOperator(lastChar))
                        text = "(";
                    else
                        text = ")";
                }

                ExpressionDisplay += text;
                Debug.WriteLine(ExpressionDisplay);

                //while (true)
                //{
                //    string priorityFormula = GetPriorityFormula(text);
                //    Debug.WriteLine($"{priorityFormula}");
                //    //text = text.Replace($"({priorityFormula})", "$$");
                //    break;
                //}
            }
        }

        private long Calculate(string value)
        {
            long result = 0;

            switch (value)
            {
                case "%":
                    break;
                case "*":
                    break;
                case "/":
                    break;
                case "-":
                    break;
                case "+":
                    break;
                case "=":
                    break;
                default:
                    break;
            }

            return result;
        }
        
        private static bool IsOperator(char value)
        {
            return value switch
            {
                '%' or '*' or '/' or '-' or '+' or '=' or '(' or ')' => true,
                _ => false,
            };
        }

        private static string GetPriorityFormula(string value)
        {
            string selectedFormula = "";

            int startBracketCount = value.Replace("(", "").Length;
            int endBracketCount = value.Replace(")", "").Length;

            if (startBracketCount == endBracketCount)
            {
                int openIndex = 0;
                int closeIndex = value.IndexOf(')');

                for (int i = value.IndexOf('('); i < closeIndex; i = value.IndexOf('(', i + 1))
                {
                    if (i < closeIndex)
                    {
                        openIndex = i;
                    }
                    else break;
                }
                int length = value.Length - openIndex - closeIndex;
                if (length < 0) length = 1;
                Debug.WriteLine($"{openIndex} -> {length}", "PriorityFormula");
                if (value.Length > length) selectedFormula = value.Substring(openIndex, length);
            }

            return selectedFormula;
        }
    }
}
