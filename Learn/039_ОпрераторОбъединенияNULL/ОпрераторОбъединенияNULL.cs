namespace _039_ОпрераторОбъединенияNULL
{

    // Оператор null-объединения ??

    internal class ОпрераторОбъединенияNULL
    {
        static void Main(string[] args)
        {
            string str = null;

            string result = str ?? "Пустая ссылка";

            Console.WriteLine(result);
        }
    }
}
