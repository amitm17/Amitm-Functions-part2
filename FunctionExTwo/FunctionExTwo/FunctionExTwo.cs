using System;
using FunctionExTwo.Abstract;
using System.Collections.Generic;

namespace FunctionExTwo
{
    public class FunctionExTwo : IExerciseTwo
    {
        public bool IsFromFibonacci(int number)
        {
            int[] fibonacci_list = { 0, 1 };
            if (number == 0) { return true; }
            while (fibonacci_list[fibonacci_list.Length - 1] < number)
            {   
                int new_first_value = fibonacci_list[1];
                int new_second_value = fibonacci_list[1] + fibonacci_list[0];
                fibonacci_list[0] = new_first_value;
                fibonacci_list[1] = new_second_value;
                if (fibonacci_list[0] == number || fibonacci_list[1] == number) 
                { 
                   return true; 
                }
            }
            return false;
        }

        public bool IsPalindrom(int number)
        {
            string string_number = Convert.ToString(number);
            if (string_number.Length <= 1)
            {
                return true;
            }
            else
            {
                if (string_number[0] == string_number[string_number .Length- 1])
                {   
                     string_number = string_number.Substring(1,string_number.Length - 2);
                    string_number = string_number.Substring(0);
                    int returned_number = int.Parse(string_number);
                    return IsPalindrom(returned_number);
                }
                else 
                {
                    return false;
                }
            }

        }
        

        public int RecursivePower(int x, int y)
        {
            if (y <= 1)
            {
                return x;
            }
            else 
            {
                return x * RecursivePower(x, y - 1);
            }
        }
    }
}
