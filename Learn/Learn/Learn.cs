using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    internal class Learn
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Person4.RetirementAge);
            
        }
    }

    class Person
    {
        int age;
        static int retirementAge = 65;

        public static int RetirementAge
        {
            get => retirementAge;
            set
            { if (value > 1 && value < 100)
                {
                    retirementAge = value;
                }
            }
        }

        public Person(int age)
        {
            this.age = age;
        }

        public void CheckAge()
        {
            if (age >= retirementAge)
                Console.WriteLine("Уже на пенсии");
            else
                Console.WriteLine($"До пенсии {retirementAge - age} лет");

        }
    }

    class Person2
    {
        static int counter = 0;
        public static int Counter
        {
            get => counter;
        }

        public Person2()
        {
            counter++;
        }
    }

    class Person3
    {
        public int Age { get; set; }
        static int retirementAge = 65;

        public Person3(int age)
        {
            Age = age;
        }

        public static void CheckRetirementStatus(Person3 person3)
        {
            if (person3.Age >= retirementAge)
            {
                Console.WriteLine("Вы выжили");
            }
            else
            {
                Console.WriteLine($"Мучайтесь {retirementAge - person3.Age} ");
            }
        }
    }

    class Person4
    {
        static int retirementAge;
        public static int RetirementAge => retirementAge;
        static Person4()
        {
            if (DateTime.Now.Year == 2025)
            {
                retirementAge = 65;
            }
            else
            {
                retirementAge = 67;
            }
        }
    }
}
