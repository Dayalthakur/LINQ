
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
    new Person { Id = 3, Name = "Charlie", Age = 22, IsActive = true, City = "New York" },
    new Person { Id = 4, Name = "Diana", Age = 35, IsActive = true, City = "Paris" },
    new Person { Id = 5, Name = "Ethan", Age = 28, IsActive = false, City = "London" },
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



            Console.WriteLine("\n---------FirstOrDefault----------\n");
            var fddata = people.FirstOrDefault(p => p.Age > 50);
            Console.WriteLine(fddata!=null ?
                $"The name of customer with age greater than 50 is {fddata.Name}"
                : "No person with age greater than 50");
        }



    }

}




