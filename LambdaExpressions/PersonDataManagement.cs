using LambdaExpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    //Created class
    public class PersonDataManagement
    {
        //Created method for retrived top 2 recordes
        public static void RetreiveTop2Records(List<Person> list)
        {
            Console.WriteLine("\nRetreive Top2 Records based on Age");
            var Top2 = list.Where(p => p.Age < 60).OrderBy(p => p.Age).Take(2);
            Program.DisplayPersonDetails(Top2);
        }
        //Created method for finding tenage records
        public static void FindTenageRecords(List<Person> list)
        {
            Console.WriteLine("\nFind Tenage Records Age Between 13 to 18");
            var result = list.Where(p => p.Age > 13 && p.Age < 18);
            Program.DisplayPersonDetails(result);
        }
        //Created method for Finding average age 
        public static void FindAverageAge(List<Person> list)
        {
            Console.WriteLine("\nFind an average Age");
            double result = list.Average(p => p.Age);
            Console.WriteLine(Math.Round(result, 2));
        }
        //Created method for finding specific person
        public static void FindSpecificPerson(List<Person> list, string input)
        {
            Console.WriteLine("\nFind person");
            var result = list.Where(p => p.Name == input).ToList();
            if (result.Count > 0)
            {
                Program.DisplayPersonDetails(result);
            }
            else
            {
                Console.WriteLine("Given person is not present");
            }
        }
        //Created method for skiped age less than 60yrs
        public static void SkipedAgeLessThan60Records(List<Person> list)
        {
            Console.WriteLine("\nSkiped Age Less Than 60 Records");
            //var result = list.Where(p => p.Age > 60);
            var result = list.OrderBy(p => p.Age).SkipWhile(p => p.Age < 60);
            Program.DisplayPersonDetails(result);
        }
        //Created method for remove person 
        public static void RemovePerson(List<Person> list, string input)
        {
            Console.WriteLine("\nRemove person");
            var result = list.RemoveAll(p => p.Name == input);
            Program.DisplayPersonDetails(list);
        }
    }
}
