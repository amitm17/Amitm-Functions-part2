using System;
using FunctionExTwo.Abstract;

namespace FunctionExTwo
{
    public class FunctionExTwo : IExerciseTwo
    {
        public bool IsFromFibonacci(int number)
        {
            throw new NotImplementedException();
        }

        public bool IsPalindrom(int number)
        {
            Console.WriteLine(Convert.ToString(number));
            string string_number = Convert.ToString(number);
            if (string_number.Length <= 1)
            {
                return true;
            }
            else
            {
                if (string_number[0] ==  number % 10)
                {
                    int new_number = Convert.ToInt32(string_number.Remove(0));
                    return IsPalindrom(new_number / 10);
                }
                else {
                    return false;
                }
            }

        }

        public int RecursivePower(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}