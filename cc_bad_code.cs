using System;

namespace cc_bad_code_assignment4
{
    class Person
    {

        public string name;
        public int age;

        public void Insert(string n, int a)
        {

            name = n;
            age = a;

        }

        public void ShowData()
        {

            Console.WriteLine("Name: {0}, age: {1}.", name, age);

        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            String s;
            int a;

            string personName;
            int personAge;

            Person p = new Person();

            Console.Write("Enter your name: ");
            s = Console.ReadLine();
            personName = s;

            Console.Write("Enter your age: ");
            s = Console.ReadLine();
            a = int.Parse(s);
            personAge = a;

            p.Insert(personName, personAge);
            p.ShowData();


        }
    }
}
