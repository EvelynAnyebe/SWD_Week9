using System;
using System.Collections.Generic;
using System.Text;

namespace YouTube
{
    public class Calculator
    {
        private Calculation currentCalculation = new Calculation();

        public Calculation CurrentCalculation
        {
            get
            {
                return currentCalculation;
            }

            set
            {
                currentCalculation = value;
                switch (currentCalculation.CalculationOperator)
                {
                    case "+":
                        currentCalculation.Result= add(currentCalculation.Num1, currentCalculation.Num2);
                        break;
                    case "-":
                        currentCalculation.Result = subtract(currentCalculation.Num1, currentCalculation.Num2);
                        break;
                    case "*":
                        currentCalculation.Result = multiply(currentCalculation.Num1, currentCalculation.Num2);
                        break;
                    case "^":
                        currentCalculation.Result = power(currentCalculation.Num1, currentCalculation.Num2);
                        break;

                    default:
                        currentCalculation.Result = 0.00;
                        break;

                }
            }
        }

        public double add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double power(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

    }
}
