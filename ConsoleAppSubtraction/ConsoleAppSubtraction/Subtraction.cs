using System;

namespace ConsoleAppSubtraction
{
    public class Subtraction
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double Result { get; set; }

        public Subtraction(double firstNumber, double secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public double Subtract()
        {
            Result = FirstNumber - SecondNumber;
            return Result;
        } 
            
    }
}


