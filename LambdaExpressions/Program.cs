using LambdaExpressions;

namespace LambdaExpression
{
    public class Program
    {
        public static List<Person> listOfPerson = new List<Person>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lambda Expressions!");
            List<Person> listOfPerson = new List<Person>();
            Console.WriteLine("For adding person details into list");
            AddingPersonDetailsIntoList(listOfPerson);
            PersonDataManagement.RetreiveTop2Records(listOfPerson);
            PersonDataManagement.FindTenageRecords(listOfPerson);
            PersonDataManagement.FindAverageAge(listOfPerson);
        }
        public static void AddingPersonDetailsIntoList(List<Person> list)
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
        public static void DisplayPersonDetails(IEnumerable<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }
        }
    } 
}