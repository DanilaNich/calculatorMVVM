using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using кал1.Helpers;
using кал1.Model;
using кал1.View;

namespace кал1.ViewModel
{
    internal class EngineeringCalculatorViewModel : INotifyPropertyChanged
    {
        private EngineeringCalculatorModel _calculator;
        private double _inputValue;
        private double _result;
        private string _selectedFunction;

        public double InputValue
        {
            get { return _inputValue; }
            set { _inputValue = value; OnPropertyChanged(); }
        }

        public double Result
        {
            get { return _result; }
            set { _result = value; OnPropertyChanged(); }
        }

        public string SelectedFunction
        {
            get { return _selectedFunction; }
            set { _selectedFunction = value; OnPropertyChanged(); }
        }

        public ICommand CalculateCommand { get; }

        public ICommand SquareRootCommand { get; }
        public ICommand SinCommand { get; }
        public ICommand CosCommand { get; }
        public ICommand TanCommand { get; }
        public ICommand CtanCommand { get; }
        public ICommand PowerCommand { get; }

        public EngineeringCalculatorViewModel()
        {
            _calculator = new EngineeringCalculatorModel();
            CalculateCommand = new BindCommand(Calculate);

            SquareRootCommand = new BindCommand(_ => CalculateOperation("SquareRoot"));
            SinCommand = new BindCommand(_ => CalculateOperation("Sin"));
            CosCommand = new BindCommand(_ => CalculateOperation("Cos"));
            TanCommand = new BindCommand(_ => CalculateOperation("Tan"));
            CtanCommand = new BindCommand(_ => CalculateOperation("Ctan"));
            PowerCommand = new BindCommand(_ => CalculateOperation("Power"));

        }

        private void CalculateOperation(string operation)
        {
            SelectedFunction = operation;
            Calculate(null);
        }

        private void Calculate(object parameter)
        {
            try
            {
                switch (SelectedFunction)
                {
                    case "SquareRoot":
                        Result = _calculator.SquareRoot(InputValue);
                        break;
                    case "Sin":
                        Result = _calculator.Sin(InputValue);
                        break;
                    case "Cos":
                        Result = _calculator.Cos(InputValue);
                        break;
                    case "Tan":
                        Result = _calculator.Tan(InputValue);
                        break;
                    case "Ctan":
                        Result = _calculator.Ctan(InputValue);
                        break;
                    case "Power":
                        Result = _calculator.Power(InputValue);
                        break;
                    default:
                        throw new ArgumentException("Invalid function selected");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
