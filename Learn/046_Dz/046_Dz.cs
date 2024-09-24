using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046_Dz
{

    /* Написать метод для удаления первого эл-та массива,
     * последнего эл-та массива
     * и эл-та по указанному индексу
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 13, 53, 23, 54 };

            RemoveAt(ref arr, 2);

            Console.WriteLine(string.Join(", ", arr));
        }

        static void RemoveAt(ref int[] arr, int index)
        {
            int[] newArr = new int[arr.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArr[i] = arr[i];
            }
            for (int a = index + 1; a < arr.Length; a++)
            {
                newArr[a - 1] = arr[a];
            }

            arr = newArr;
        }

        static void RemoveFirst(ref int[] arr)
        {
            RemoveAt(ref arr, 0);
        }

        static void RemoveLast(ref int[] arr)
        {
            RemoveAt(ref arr, arr.Length - 1);
        }
    }
}
