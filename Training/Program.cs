using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int x, y;
            string direction, result = "";

            string[] inputValues = ReadInput();
            x = int.Parse(inputValues[0]);
            y = int.Parse(inputValues[1]);
            direction = inputValues[2];


            Console.WriteLine(result);
        }

        public static string[] ReadInput()
        {
            string[] inputValues = new string[3];

            if (Console.ReadLine() is string input)
            {
                string[] values = input.Split(' ');
                for (int i = 0; i < 3; i++)
                {
                    inputValues[i] = values[i];
                }
            }

            return inputValues;
        }


    }
}
