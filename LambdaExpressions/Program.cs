using System;
using System.Security.Cryptography.X509Certificates;

namespace LambdaExpressions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lambda Expressions!");
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("1:Adding Person Details Into List");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    List<Person> listOfPerson = new List<Person>();
                    AddingPersonDetailsIntoList(listOfPerson);
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }

            static void AddingPersonDetailsIntoList(List<Person> list)
            {
                list.Add(new Person() { SSN = 1, Name = "Shivani", Address = "Maharashtra", Age = 12 });
                list.Add(new Person() { SSN = 2, Name = "Uvi", Address = "Maharashtra", Age = 70 });
                list.Add(new Person() { SSN = 3, Name = "Shivani", Address = "Maharashtra", Age = 32 });
                list.Add(new Person() { SSN = 4, Name = "Shraddha", Address = "Maharashtra", Age = 16 });
                list.Add(new Person() { SSN = 5, Name = "Malhar", Address = "Maharashtra", Age = 63 });
                list.Add(new Person() { SSN = 6, Name = "Arun", Address = "Maharashtra", Age = 36 });
                list.Add(new Person() { SSN = 1, Name = "Kalpna", Address = "Maharashtra", Age = 14 });
                DisplayPersonDetails(list);
            }
            static void DisplayPersonDetails(IEnumerable<Person> list)
            {
                foreach (Person person in list)
                {
                    Console.WriteLine(person);
                }
            }
        }
    }
}