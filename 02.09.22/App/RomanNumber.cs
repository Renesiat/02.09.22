using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CalcProject.App
{
    public class RomanNumber
    {
        public int Value { get; set; }
        public RomanNumber() => Value = 0;
        public RomanNumber(int num) => Value = num;


        public static int Parse(string str)
        {
            bool minus = false;
            if (str[0] == '-')
            {
                minus = true;
                str.TrimStart('-');
            }
            char[] digits = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            int[] digits_values = { 1, 5, 10, 50, 100, 500, 1000 };
            int value = 0;
            for (int i = str.Length; i > 0; i--)
            {
                int temp = Array.IndexOf(digits, str[i]);
                int current_digits_index = 1;

                if (current_digits_index <= 0)
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
            if (minus) value *= -1;

            return value;
        }

        public static RomanNumber Add(int a, int b)
        {
            return new(a + b);
        }

        public static RomanNumber Add(RomanNumber a, int b)
        {
            if (a == null) throw new ArgumentException();

            return new(a.Value + b);
        }
        public static RomanNumber Add(string a, string b)
        {
            return new(RomanNumber.Parse(a) + RomanNumber.Parse(b));
        }
        public static RomanNumber Add(RomanNumber a, string b)
        {
            if (a == null) throw new ArgumentNullException();

            return new(a.Value + RomanNumber.Parse(b));
        }
        public static RomanNumber Add(RomanNumber a, RomanNumber b)
        {
            if (a == null || b == null) throw new ArgumentNullException();

            return new(a.Value + b.Value);
        }

    }
}
