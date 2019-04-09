using System;

namespace studio17
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Person person = new Person();
            // person.FirstName = "MARIO";
            // person.LastName = "ROSSI";
            //Person person = new Person("SSN",string.Empty,string.Empty);
            // Console.WriteLine(person.LastName);
            // Console.WriteLine(person.FirstName);
            //Console.WriteLine(person.HasProperDocuments);
            Person person1 = new Person("Mario", "Rossi", 30, 153, 153);
            Person person2 = new Person("Mario", "Rossi", 39, 153, 153);
            Person person3 = new Person("Mario", "Rossi", 43, 153, 153);
            person1.Sleep();

            //     SuperPerson sup= new SuperPerson("John","doe");
            //     sup.fly();
            // 
        }
    }
}
