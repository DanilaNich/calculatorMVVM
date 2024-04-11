using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кал1.Model
{
    public class CalculatorModel
    {
        public double Calculate(double firstNumber, double secondNumber, object operationObject)
        {
            string operation = operationObject.ToString(); 
            switch (operation)
            {
                case "+":
                    return firstNumber + secondNumber;
                case "-":
                    return firstNumber - secondNumber;
                case "*":
                    return firstNumber * secondNumber;
                case "/":
                    if (secondNumber == 0)
                        throw new DivideByZeroException();
                    return firstNumber / secondNumber;
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }

    }
}
