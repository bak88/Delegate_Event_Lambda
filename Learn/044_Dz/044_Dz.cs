namespace _044_Dz
{
    // Написать метод Resize изменяющий количество эл-ов
    // массива( метод должен иметь возможность увеличить или
    // уменьшить кол-во эл-ов массива)

    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] arr = {1, 4, 6};

            //Array.Resize(ref arr, 5); //Метод позволяет изменять размер массива

            int value = random.Next(4, 10);

            Resize(ref arr, value);
        }

        static void Resize<T>(ref T[] arr, int newSize) 
        {
            
            T[] newArr = new T[newSize];

            for (int i = 0; i < arr.Length && i < newArr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            arr = newArr;
        }
    }
}
