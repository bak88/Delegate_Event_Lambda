namespace _032_ЗаполнениеДвумерногоМассива
{
    internal class ЗаполнениеДвумерногоМассива
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[10,6];

            Random random = new Random();
            
            // 2 цикла что бы не нарушать SOLID принципы

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(10, 100);
                    
                }
                
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
