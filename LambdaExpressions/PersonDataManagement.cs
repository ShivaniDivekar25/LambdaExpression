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
    }
}
