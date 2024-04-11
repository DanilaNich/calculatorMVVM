using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using кал1.Model;
using кал1.ViewModel.Helpers;

namespace кал1.ViewModel
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private double _firstNumber;
        private double _secondNumber;
        private string _operation;
        private double _result;
        private readonly CalculatorModel _calculator;
        public ICommand SetOperationCommand { get; }


        public double FirstNumber
        {
            get { return _firstNumber; }
            set
            {
                _firstNumber = value;
                OnPropertyChanged();
            }
        }

        public double SecondNumber
        {
            get { return _secondNumber; }
            set
            {
                _secondNumber = value;
                OnPropertyChanged();
            }
        }

        public string Operation
        {
            get { return _operation; }
            set
            {
                _operation = value;
                OnPropertyChanged();
            }
        }

        public double Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }
        private void SetOperation(string operation)
        {
            Operation = operation;
            Calculate();
        }

        public CalculatorViewModel()
        {
            _calculator = new CalculatorModel();

            SetOperationCommand = new RelayCommand<string>(SetOperation);
        }

        private void Calculate()
        {
            try
            {
                Result = _calculator.Calculate(FirstNumber, SecondNumber, Operation);
                OnPropertyChanged(nameof(Result));
            }
            catch (Exception ex)
            {
                Result = double.NaN;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
