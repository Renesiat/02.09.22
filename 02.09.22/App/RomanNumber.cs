using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CalcProject.App
{
    public class RomanNumber
    {
        public static int Parse(string str)
        {
            char[] digits = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            int[] digits_values = { 1, 5, 10, 50, 100, 500, 1000 };
            int value = 0;
            for (int i = str.Length; i > 0; i--)
            {
                int temp = Array.IndexOf(digits, str[i]);
                int current_digits_index = temp;

                if (current_digits_index == -1)
                {
                    throw new ArgumentException($"Invalid digit'{str[i]}'");
                }
                value = digits_values[current_digits_index];

                if (i > 1 && digits_values[i] < value)
                {
                    value -= digits_values[i];
                }
                else if (i > 1)
                {
                    value += digits_values[i];

                }
            }

            return value;
        }
    }
}
