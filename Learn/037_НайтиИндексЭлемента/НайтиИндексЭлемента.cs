using System;

namespace _037_НайтиИндексЭлемента
{
    internal class НайтиИндексЭлемента
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива: ");
            uint length = uint.Parse(Console.ReadLine());

            int[] array = FillArrayRandom(length);
            Console.WriteLine(string.Join(", ", array));

            Console.WriteLine("Введите искомый элемент: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Индекс искомого элемента: {SearchElement(array, number)}");
        }

        static int[] FillArrayRandom(uint length)
        {
            Random random = new Random();

            int[] array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(21);
            }
            return array;
        }

        static int SearchElement(int[] array, int number)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                if(number == array[i])
                {
                    return i;
                } 
            }

            return -1;
        }
    }
}
