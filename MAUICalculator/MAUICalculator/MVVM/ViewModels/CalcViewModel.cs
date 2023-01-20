using Dangl.Calculator;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUICalculator.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CalcViewModel
    {
        public string Formula { get; set; } = string.Empty;
        public string Result { get; set; } = "0";

        public ICommand OperationCommand =>
            new Command((number) => { Formula += number; });

        public ICommand ResetCommand =>
            new Command(() =>
            {
                Formula = string.Empty;
                Result = "0";
            });

        public ICommand BackspaceCommand =>
            new Command(() =>
            {
                if (Formula.Length > 0)
                {
                    int count = (char)Formula.ToArray().GetValue(Formula.Length - 1) == ' ' ? 3 : 1;
                    Formula = Formula.Substring(0, Formula.Length - count);
                }
            });

        public ICommand CalculateCommand =>
            new Command(() =>
            {
                if (Formula.Length == 0)
                    return;
                var calculator =
                       Calculator.Calculate(Formula);
                Result = calculator.Result.ToString();

            });
    }
}
