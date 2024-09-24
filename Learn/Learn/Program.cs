using Newtonsoft.Json;

Person tom = new("Tom", 18);

string json = JsonConvert.SerializeObject(tom);
Console.WriteLine(json);

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}