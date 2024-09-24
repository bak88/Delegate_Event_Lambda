namespace _036_МетодыФункции
{
    internal class МетодыФункции
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ: ");
            char symbol = Console.ReadKey().KeyChar;

            Console.WriteLine("\nВведите число: ");
            uint symbolCount = uint.Parse(Console.ReadLine());

            PrintLine(symbol, symbolCount);
        }

        static void PrintLine(char symbol, uint symbolCount)
        {
            for (int i = 0; i < symbolCount; i++)
            {
                Console.Write(symbol);
            }
        }
    }
}
