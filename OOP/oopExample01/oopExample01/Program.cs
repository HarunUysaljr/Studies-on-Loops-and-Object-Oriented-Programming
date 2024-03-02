using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopExample01
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    internal class Program
    {

        //Constructor metotlar, bir sınıfın nesnesi (instance) oluşturulduğunda otomatik olarak
        //çağrılan ve nesnenin başlangıç durumunu belirlemek için kullanılan metotlardır.
        //Yani, bir sınıfın nesnesi oluşturulduğunda yapılması gereken işlemleri içerirler.

        static void Main(string[] args)
        {

            // Person sınıfından bir nesne örneği oluşturma
            Person person1 = new Person("Alice", 30);

            // Person sınıfından bir diğer nesne örneği oluşturma
            Person person2 = new Person("Bob", 25);

            // Oluşturulan nesneleri kullanma
            Console.WriteLine($"İsim: {person1.Name}, Yaş: {person1.Age}");
            Console.WriteLine($"İsim: {person2.Name}, Yaş: {person2.Age}");

            Console.ReadLine();

        }
    }
}
