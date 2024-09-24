using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;





namespace Training
{
    internal class Training
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Bim" };
            person.PrintPers();


            Person person1 = new Employee() { Name = "Jack" };
            person1.PrintPers();
        }



    }

    internal class Person
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void PrintPers()
        {
            Console.WriteLine(Name);
        }

    }

    private protected class Employee : Person
    {

    }

    sealed class Person2
    {
        private string name;
    }



}

