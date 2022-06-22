using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
     class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 30, 40, 10, 44, 20, 15, 10, 2, 7 };
            var querySyntax = from obj in list
                               where obj >20
                               select obj;
            foreach(var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("............");
            //by using method Syntax

            var methodSyntax = list.Where(obj => obj > 20);
            foreach(var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
                
        }
    }
}
