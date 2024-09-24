namespace _040_ОператорУсловногоNULL
{

    // Оператор условного NULL ?.

    // ?. проверяет значение на null и если он равно null код выполняться дальше не будет

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = GetArray();

            Console.WriteLine("Сумма элементов массива: " + (myArray?.Sum() ?? 0));
        }

        static int[] GetArray()
        {
            int[] array = null; // {1, 2, 3}
            return array;
        }
    }
}
