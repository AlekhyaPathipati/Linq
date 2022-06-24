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
            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            var querySyntax = from obj in list
                               where obj >2
                               select obj;
            foreach(var item in querySyntax)
            {
                //Console.WriteLine(item);
            }

            Console.WriteLine("............");
            //by using method Syntax

            var methodSyntax = list.Where(obj => obj > 2);
            foreach(var item in methodSyntax)
            {
                //Console.WriteLine(item);
            }

            //ElementAt()
            var ms=list.ElementAt(0);

            //First method
            var mss = list.First();
            var s = list.Where(x => x > 5).First();

            //searching and finding

            Console.WriteLine(list.Contains(2));
            Console.WriteLine(list.Exists(i=>i>=5));
            int ab = list.Find(i => i > 4);
            Console.WriteLine(ab);
            Console.ReadLine();

            //inner join

            var students = new List<Student>()
            {
                new Student() { Id = 1, Name = "A 1", AddressId = 1 },
                new Student() { Id = 2, Name = "A 2", AddressId = 0 },
                new Student() { Id = 3, Name = "A 3", AddressId = 2 },
                new Student() { Id = 4, Name = "A 4", AddressId = 0 },
                new Student() { Id = 5, Name = "A 5", AddressId = 3 },
            };

            var addresses = new List<Address>()
            {
                new Address(){ Id = 1, AddressLine = "Line 1"},
                new Address(){ Id = 2, AddressLine = "Line 2"},
                new Address(){ Id = 3, AddressLine = "Line 3"},
                //new Address(){ Id = 4, AddressLine = "Line 4"},
                //new Address(){ Id = 5, AddressLine = "Line 5"},
            };

            var qs = (from student in students
                     join address in addresses
                     on student.AddressId equals address.Id
                     select new
                     {
                         StudentName=student.Name,
                         Line = address.AddressLine
                     });

            //left join

            var sq = (from std in students
                      join add in addresses
                      on std.AddressId equals add.Id into stdAddress
                     from studentAddress in stdAddress.DefaultIfEmpty()
                     select new {std,studentAddress});

              


        }
    }
}
