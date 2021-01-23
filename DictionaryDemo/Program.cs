using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> persons = new MyDictionary<string>();
            persons.Add("Şevval");
            persons.Add("Ayşe");
            persons.Add("Meral");

            
            foreach (var person in persons.Items)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine("Kişi Sayısı:" + persons.Count);

            persons.Add("Sümeyye");
            persons.Add("Kadriye");
            Console.WriteLine("\t");

            foreach (var person1 in persons.Items)
            {
                
                Console.WriteLine(person1);
            }
            Console.WriteLine("Kişi Sayısı:" + persons.Count);

            Console.ReadLine();
        }
    }
}
