using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    using System;
    using System.Threading.Tasks;

    public class ПримерАсинхронногоМетода
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Начало выполнения");

            await ДолгаяЗадача();

            Console.WriteLine("Конец выполнения");
        }

        public static async Task ДолгаяЗадача()
        {
            Console.WriteLine("Начало долгой задачи");
            await Task.Delay(2000);  // Имитация длительной операции
            Console.WriteLine("Конец долгой задачи");
        }
    }


   





}







