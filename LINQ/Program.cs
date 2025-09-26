
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static LINQ.Program;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LINQ
{
    public class Program
    {
        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Order
        {
            public int OrderId { get; set; }
            public int CustomerId { get; set; }
            public string Product { get; set; }
        }
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public bool IsActive { get; set; }
            public string City { get; set; }
        }
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>
{
    new Person { Id = 1, Name = "Alice", Age = 25, IsActive = true, City = "New York" },
    new Person { Id = 2, Name = "Bob", Age = 30, IsActive = false, City = "London" },
    new Person { Id = 3, Name = "Charlie", Age = 30, IsActive = true, City = "New York" },
    new Person { Id = 4, Name = "Diana", Age = 35, IsActive = true, City = "Paris" },
    new Person { Id = 5, Name = "Ethan", Age = 25, IsActive = false, City = "London" },
    new Person { Id = 6, Name = "Fiona", Age = 40, IsActive = true, City = "Paris" }
};

            //Console.WriteLine("---------Where---------\n");
            //var adults = people.Where(p => p.Age >= 30);
            //if (adults.Count() > 0)
            //{
            //    Console.WriteLine("People with age greater than 30 ");
            //    foreach (var person in adults)
            //    {
            //        Console.WriteLine(person.Name);
            //    }
            //}


            //Console.WriteLine("\n---------Select---------\n");
            //var data = people.Select(p => new { p.Name,p.Age,p.City });
            //var dataone = people.Select(p => p.Name);
            //foreach(var p in data)
            //{
            //    Console.WriteLine($"My name is {p.Name},I am {p.Age} years old. I live in {p.City} city.");
            //}


            //Console.WriteLine("\n---------Order By---------\n");
            //var asco = people.OrderBy(p => p.Age);
            //Console.WriteLine("The Names of the people in Ascending Order of their Age : ");
            //foreach(var a in asco)
            //{
            //    Console.WriteLine(a.Name);
            //}


            //Console.WriteLine("\n---------Order By Descending---------\n");
            //var desc = people.OrderByDescending(p => p.Age);
            //Console.WriteLine("Displaying the names sorted by age in descending order :- ");
            //foreach(var d in desc)
            //{
            //    Console.WriteLine(d.Name);
            //}


            //Console.WriteLine("\n---------Order by---------\n");
            //var norder = people.OrderBy(p => p.Name);
            //Console.WriteLine("Name in Ascending order ");
            //foreach(var n in norder)
            //{
            //    Console.WriteLine(n.Name);
            //}


            //Console.WriteLine("\n---------Group By---------\n");
            //var gdata = people.GroupBy(p => p.City);
            //foreach(var g in gdata)
            //{
            //    Console.WriteLine($"The no. of people from {g.Key}  { g.Count()}");
            //}



            //            Console.WriteLine("---------Join---------");
            //            List<Customer> customers = new List<Customer>
            //            {
            //                new Customer { Id = 1, Name = "Alice" },
            //    new Customer { Id = 2, Name = "Bob" }
            //}
            //            ;

            //            List<Order> orders = new List<Order>
            //{
            //    new Order { OrderId = 101, CustomerId = 1 ,Product="Watch"},
            //    new Order { OrderId = 102, CustomerId = 2 ,Product="Mobile"},
            //    new Order { OrderId = 103, CustomerId = 1 ,Product="Laptop"}
            //};

            //            var res = customers.Join(orders,
            //                customers => customers.Id,
            //                orders => orders.CustomerId,
            //                (customers, orders)
            //                => new
            //                {
            //                    customers.Name,
            //                    orders.OrderId,
            //                    orders.Product
            //                });
            //            foreach(var cust in res)
            //            {
            //                Console.WriteLine($"The {cust.Name} has ordered a {cust.Product} whose Order Id is : {cust.OrderId}");
            //            }


            //Console.WriteLine("\n---------Take---------\n");
            //Console.WriteLine($"Total Count : {people.Count}");
            //Console.Write("Input for showing the Names of top data : ");
            //int count = Convert.ToInt32(Console.ReadLine());
            //if (count > 0 && count <= people.Count())
            //{
            //    var tdata = people.Take(count);
            //    foreach (var t in tdata)
            //    {
            //        Console.WriteLine(t.Name);
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}



            //Console.WriteLine("\n---------Skip---------\n");
            //Console.WriteLine("Input for skipping the no. elements : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //var sdata = people.Skip(num);
            //if (sdata != null)
            //{
            //    Console.WriteLine($"After skipping the {num} elements the name of Customer :-");
            //    foreach (var item in sdata)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //}




            //Console.WriteLine("\n---------Any----------\n");
            //bool adata = people.Any(a => a.Age > 40);
            //Console.WriteLine(adata);



            //Console.WriteLine("\n---------All----------\n");
            //bool bdata = people.All(p => p.Age > 18);
            //Console.WriteLine(bdata);



            //Console.WriteLine("\n---------Count----------\n");
            //int total = people.Count();
            //Console.WriteLine($"The total count of data is : {total}");
            //int midage = people.Count(p => p.Age > 30);
            //Console.WriteLine($"The no. of mid aged peoples : {midage}");



            //Console.WriteLine("\n---------First----------\n");
            //var fdata = people.First(p => p.Age > 30);
            //if (fdata != null)
            //{
            //    Console.WriteLine($"The name of person with age greater than 30 is {fdata.Name}");
            //}



            //Console.WriteLine("\n---------FirstOrDefault----------\n");
            //var fddata = people.FirstOrDefault(p => p.Age > 50);
            //Console.WriteLine(fddata!=null ?
            //    $"The name of customer with age greater than 50 is {fddata.Name}"
            //    : "No person with age greater than 50");



            ////Q1.Find all even numbers from a list using LINQ.
            //var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var evenNumbers = numbers.Where(n => n % 2 == 0);
            //Console.WriteLine("Even Numbers are : ");
            //foreach(var i in evenNumbers)
            //{
            //    Console.Write(i+" ");
            //}



            ////Q2.Select names that start with "A".
            //var names = new List<string> { "Amit", "Rahul", "Anil", "Deepak" };
            //var Anames = names.Where(n => n.StartsWith("A"));
            //Console.WriteLine("Name starting with letter A : ");
            //foreach (var n in Anames)
            //{
            //    Console.WriteLine(n);
            //}


            ////Q3.Find duplicate numbers in a list using LINQ.
            //var numbers = new List<int> { 1, 2, 3, 2, 4, 5, 5, 6 };
            //var duplicatenumbers = numbers.GroupBy(n => n).Where(g => g.Count() > 1).ToList();
            //foreach(var d in duplicatenumbers)
            //{
            //    Console.WriteLine(d.Key);
            //}


            ////Q4.Join two lists(like SQL INNER JOIN).
            //    var students = new[]
            //    {
            //        new{StudentId=1,Name="Alice" },
            //        new{StudentId=2,Name="Bob" },
            //        new{StudentId=3,Name="Charlie" }
            //    };
            //    var scores = new[]
            //    {
            //        new{StudentId=1,Score=85 },
            //        new{StudentId=2,Score=90 },
            //        new{StudentId=4,Score=95 }
            //    };

            //    var result = from s in students
            //                 join sc in scores
            //               on s.StudentId equals sc.StudentId
            //                 select new { s.Name, sc.Score };
            //    Console.WriteLine("Student Scores : ");
            //    foreach (var r in result)
            //    {
            //        Console.WriteLine($"{r.Name} : {r.Score}");
            //    }



            ////Q5.Find the highest salary employee in each department.
            //            var employees = new[]
            //{
            //    new { Id = 1, Dept = "IT", Salary = 50000 },
            //    new { Id = 2, Dept = "HR", Salary = 40000 },
            //    new { Id = 3, Dept = "IT", Salary = 70000 },
            //    new { Id = 4, Dept = "HR", Salary = 45000 }
            //};
            //            var highestsalary = employees.OrderByDescending(s => s.Salary).GroupBy(e => e.Dept).First();
            //            foreach (var h in highestsalary)
            //            {
            //                //var emp = h.First();
            //                Console.WriteLine($"The highest salary in {highestsalary.Key} department is {h.Salary}");
            //            }



            ////Write a LINQ query to get all odd numbers from a list.
            //var num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 89, 10 };
            //var oddnum = num.Where(n => n % 2 != 0);
            //foreach(var o in oddnum)
            //{
            //    Console.WriteLine(o);
            //}



            ////Find the maximum, minimum, sum, and average from a list of integers.
            //var num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 23, 45, 64, 5 };
            //var highnum = num.Max();
            //var lownum = num.Min();
            //var avg = num.Average();
            //var sum = num.Sum();
            //Console.WriteLine($"The maximum number is : {highnum}\nThe minimum number is : {lownum}\nThe average is : {avg}\nThe sum is : {sum}");




            ////Sort a list of strings alphabetically using LINQ.
            //var str=new List<string> { "Banana", "Apple", "Mango", "Pineapple", "Grapes" };
            //var sortstr = str.OrderBy(s => s);
            //foreach(var s in sortstr)
            //{
            //    Console.WriteLine(s);
            //}



            ////Count how many times each number appears in a list.
            //var numbers = new List<int> { 1, 3, 8, 4, 6, 8, 6, 4, 3, 1, 1, 3, 4, 5, 7, 9, 9, 7, 6, 4, 3, 7 };
            //var countnum = numbers.GroupBy(n => n)
            //    .Select(g => new { Number = g.Key, Count = g.Count() });
            //foreach (var c in countnum)
            //{
            //    Console.WriteLine($"The number {c.Number} appears {c.Count} times");

            //}




            ////Find all distinct numbers from a list.
            //int[] numb = { 45, 45, 645, 64, 53,35, 56, 77, 897, 85, 6, 45, 35, 3, 56, 7, 7, 8, 8, 9, 95 };
            //var distinctnum = numb.Distinct();
            //Console.WriteLine("The Distinct numbers are : ");
            //foreach(var d in distinctnum)
            //{
            //    Console.Write(d+" ");
            //}



            ////Write a LINQ query to return employees ordered by department then by salary.
            //var orderemp = people.OrderBy(p => p.Age).ThenBy(p => p.Name);
            //Console.WriteLine("Employees ordered by Age then by Name : ");
            //foreach(var e in orderemp)
            //{
            //    Console.WriteLine($"{e.Name} : {e.Age}");
            //}



            ////Get the first 5 elements from a list and skip the next 5 elements.
            //var numlist = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var first5 = numlist.Take(5);
            //var skipnext5 = numlist.Skip(10);
            //var li= first5.Concat(skipnext5);
            //Console.WriteLine("The first 5 elements and last 5 elements are : ");
            //foreach(var l in li)
            //{
            //    Console.WriteLine(l);
            //}



            ////Return the top 3 highest salaries from the employees list.
            //var employee = new[]
            //{
            //    new {Id=1,Name="Amit",Salary=45000 },
            //    new {Id=2,Name="Rahul",Salary=55000 },
            //    new {Id=3,Name="Anil",Salary=35000 },
            //    new {Id=4,Name="Sumit",Salary=75000 },
            //    new {Id=5,Name="Deepak",Salary=25000 }
            //};
            //var top3 = employee.OrderByDescending(p => p.Salary).Take(3);
            //foreach(var t in top3)
            //{
            //    Console.WriteLine($"{t.Name} : {t.Salary}");
            //}



            ////Return all employees except the one with the lowest salary.
            //var lowest = employee.OrderBy(e => e.Salary).Skip(1);
            //foreach (var i in lowest)
            //{
            //    Console.WriteLine(i.Id+" "+i.Salary+" "+i.Name);
            //}


            ////Find students who scored more than the average marks.
            //var scores = new[]
            //    {
            //        new{StudentId=1,Score=85 },
            //        new{StudentId=2,Score=90 },
            //        new{StudentId=4,Score=95 }
            //    };

            //var avg1 = scores.Where(s => s.Score > scores.Average(s => s.Score));
            //foreach (var s in avg1)
            //{
            //    Console.WriteLine(s.StudentId);
            //}



            ////Check if a list contains a specific element using LINQ (Contains).
            //var listcon=new List<string> { "Apple", "Banana", "Mango", "Orange" };
            //var lis = listcon.Contains("Mango");
            //Console.WriteLine(lis);



            //Find the maximum salary in each department.

            // var employees = new[]
            //{
            //     new { Id = 1, Dept = "IT", Salary = 50000 },
            //         new { Id = 2, Dept = "HR", Salary = 40000 },
            //         new { Id = 3, Dept = "IT", Salary = 70000 },
            //         new { Id = 4, Dept = "HR", Salary = 45000 }
            //     };
            // var sala = employees.GroupBy(e => e.Dept).Select(g => new { Department = g.Key, Salary = g.Max(emp => emp.Salary) });
            // foreach (var s in sala)
            // {
            //     Console.WriteLine($"The highest salary in {s.Department} department is {s.Salary}");
            // }



            ////Find employees whose names start with “R” and end with “h”.
            //var l = people.Where(p => p.Name.StartsWith("A") && p.Name.EndsWith("e"));
            //foreach (var i in l)
            //{
            //    Console.WriteLine(i.Name);
            //}




            ////Split a list into even - indexed and odd-indexed elements using LINQ.

            //var index = people.Select((p, index) => new { Person = p, Index = index });
            //var evenindex = index.Where(x => x.Index % 2 == 0).Select(x => x.Person);
            //var oddindex = index.Where(x => x.Index % 2 != 0).Select(x => x.Person);
            //Console.WriteLine("The even indexed elements are : ");
            //foreach (var e in evenindex)
            //{
            //    Console.WriteLine(e.Name);
            //}




            ////Filter out null or empty strings from a collection.

            //var strings = new List<string> { "Apple", "", null, "Banana", "Mango", "", "Orange", null };
            //var filteredStrings = strings.Where(s => !string.IsNullOrEmpty(s));
            //foreach (var str in filteredStrings)
            //{
            //    Console.WriteLine(str);

            //}
        }
    }


}




