using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using кал1.Helpers;
using кал1.View;
using кал1.ViewModel.Helpers;

namespace кал1.ViewModel
{
    public class StartWindowViewModel
    {
        public BindCommand OpenSimpleCalc { get; }
        public BindCommand OpenEngenCalc { get; }

        public StartWindowViewModel()
        {
            OpenSimpleCalc = new BindCommand(_ => StartSimlyCal());
            OpenEngenCalc = new BindCommand(_ => StartEngenCal());
        }

        public void StartSimlyCal()
        {
            MainWindow window = new MainWindow();
            window.Show();

        }
        public void StartEngenCal()
        {
            EngineeringCalculatorView engineeringCalculator = new EngineeringCalculatorView();
            engineeringCalculator.Show();
        }
       
    }
}
