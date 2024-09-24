namespace _034_ТрехмерныйМассив
{
    internal class ТрехмерныйМассив
    {
        static void Main(string[] args)
        {
            int[,,] myArray = 
            {
                { 
                    {12, 23, 34 },
                    {45, 94, 54 },
                    {87, 21, 23}
                },

                {
                    {1, 233, 634 },
                    {455, 944, 5784 },
                    {827, 211, 243}
                },

                {
                    {182, 293, 340 },
                    {454, 942, 534 },
                    {857, 241, 253}
                },
                
            };

            int[,,] myArrayRandom = new int[4, 3, 5];

            Random random = new Random();

            for (int i = 0; i < myArrayRandom.GetLength(0); i++)
            {
                for (int j = 0; j < myArrayRandom.GetLength(1); j++)
                {
                    for (int k = 0; k < myArrayRandom.GetLength(2); k++)
                    {
                        myArrayRandom[i, j, k] = random.Next(100);
                    }
                }
            }

            for (int i = 0; i < myArrayRandom.GetLength(0); i++)
            {

                Console.WriteLine("Страница " + (i + 1));

                for (int j = 0; j < myArrayRandom.GetLength(1); j++)
                {
                    for (int k = 0; k < myArrayRandom.GetLength(2); k++)
                    {
                        Console.Write(myArrayRandom[i, j, k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
