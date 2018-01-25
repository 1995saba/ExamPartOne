using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1 m = new Model1();

            // Task 1 

            //var allOrders = from orders in m.Orders.ToList()
            //                orderby orders.OrderDate
            //                select orders;

            //Console.WriteLine($"Самый старый заказ: {allOrders.First().OrderID}-{allOrders.First().OrderDate}");
            //Console.WriteLine($"Самый новый заказ: {allOrders.Last().OrderID}-{allOrders.Last().OrderDate}");

            // Task 2

            //var ordersByDateDiff = from orders in m.Orders.ToList()
            //                       orderby (orders.RequiredDate - orders.OrderDate).Value.Days descending
            //                       select orders;

            //Console.WriteLine($"Заказ с самой большой разницей даты затребования и даты заказа: \n" +
            //                    $"{ordersByDateDiff.First().OrderID}---{ordersByDateDiff.First().OrderDate}---{ordersByDateDiff.First().RequiredDate}");

            //// Task 3

            //int postalCode;
            //var empIntPostalCode = from employees in m.Employees.ToList()
            //                       let res = Int32.TryParse(employees.PostalCode, out postalCode)
            //                       where res == true
            //                       select employees.EmployeeID;
            //Console.WriteLine("Сотрудники, у которых Postal состоит исключительно из чисел: ");
            //foreach(var item in empIntPostalCode)
            //{
            //    Console.WriteLine(item);
            //}

            // Task 4

            //var customersByCountries = from customers in (from customers in m.Customers.ToList()
            //                                              group customers by customers.Country into c
            //                                              select new
            //                                              {
            //                                                    Country = c.Key,
            //                                                    Count = c.Count(),
            //                                                    Customer = from cust in c select cust.CompanyName
            //                                              })
            //                           orderby customers.Count
            //                           select customers;

            //foreach(var item in customersByCountries)
            //{
            //    Console.WriteLine($"Страна: {item.Country}\tКоличество клиентов: {item.Count}");
            //    foreach(var customer in item.Customer)
            //    {
            //        Console.WriteLine(customer);
            //    }
            //    Console.WriteLine();
            //}

            // Task 5

            //var ordersByEmployees = from orders in m.Orders.ToList()
            //                        orderby orders.EmployeeID
            //                        group orders by orders.EmployeeID into o
            //                        select new
            //                        {
            //                            EmployeeId = o.Key,
            //                            Order = from order in o select order.OrderID
            //                        };

            //foreach(var item in ordersByEmployees)
            //{
            //    Console.WriteLine($"EmployeeID: {item.EmployeeId}");
            //    foreach(var order in item.Order)
            //    {
            //        Console.WriteLine($"OrderID: {order}");
            //    }
            //    Console.WriteLine();
            //}

            // Task 6

            // >= 5000$
            //var mostExpensiveOrders = from orders in (from orderDetails in m.Order_Details.ToList()
            //                                          group orderDetails by orderDetails.OrderID into od
            //                                          select new
            //                                          {
            //                                              OrderId = od.Key,
            //                                              TotalSum = od.Sum(p => (p.Quantity * p.UnitPrice))
            //                                          })
            //                          where orders.TotalSum>=5000
            //                          select orders;

            //// < 5000$ && >= 1000
            //var middleOrders = from orders in (from orderDetails in m.Order_Details.ToList()
            //                                          group orderDetails by orderDetails.OrderID into od
            //                                          select new
            //                                          {
            //                                              OrderId = od.Key,
            //                                              TotalSum = od.Sum(p => (p.Quantity * p.UnitPrice))
            //                                          })
            //                          where orders.TotalSum >= 1000 && orders.TotalSum < 5000
            //                   select orders;

            //// < 1000$
            //var cheapestOrders = from orders in (from orderDetails in m.Order_Details.ToList()
            //                                          group orderDetails by orderDetails.OrderID into od
            //                                          select new
            //                                          {
            //                                              OrderId = od.Key,
            //                                              TotalSum = od.Sum(p => (p.Quantity * p.UnitPrice))
            //                                          })
            //                          where orders.TotalSum < 1000
            //                     select orders;

            //Console.WriteLine("Most expensive orders(>5000$): ");
            //foreach(var item in mostExpensiveOrders)
            //{
            //    Console.WriteLine($"{item.OrderId}-{item.TotalSum}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Middle orders(<5000$ && >1000$): ");
            //foreach (var item in middleOrders)
            //{
            //    Console.WriteLine($"{item.OrderId}-{item.TotalSum}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Cheapest orders(<1000$): ");
            //foreach (var item in cheapestOrders)
            //{
            //    Console.WriteLine($"{item.OrderId}-{item.TotalSum}");
            //}
            //Console.WriteLine();

            //Task 7
            //var orders = model.Order_Details.ToList();
            //var products = model.Products.ToList();
            //int id = orders[0].OrderID;
            //Console.WriteLine(id);
            //foreach (var item in orders)
            //{
            //    if (item.OrderID != id)
            //    {
            //        id = item.OrderID;
            //        Console.WriteLine("{0}:", id);
            //    }

            //    foreach (var inner in products)
            //    {
            //        if(item.ProductID==inner.ProductID)
            //        Console.WriteLine(" {0}", inner.ProductName);
            //    }
            //}
            //Console.ReadLine();

            //Task 8
            //var orders = model.Orders.OrderBy(p=>p.CustomerID).ToList();
            //string cust = orders[0].CustomerID;
            //Console.WriteLine("{0}:",cust);

            //foreach(var item in orders)
            //{
            //    if(item.CustomerID != cust)
            //    {
            //        cust = item.CustomerID;
            //        Console.WriteLine("{0}:", cust);
            //    }
            //    Console.WriteLine(" {0}", item.EmployeeID);
            //}
            //Console.ReadLine();

            //Task 9
            //var product = model.Products.ToList();
            //var orderdet = model.Order_Details.ToList();
            //var orders = model.Orders.ToList();

            //foreach (var item in product)
            //{
            //    Console.WriteLine("{0}:", item.ProductName);
            //    foreach(var inner in orderdet)
            //    {
            //        if(item.ProductID == inner.ProductID)
            //        {
            //            foreach(var ininer in orders)
            //            {
            //                if(ininer.OrderID == inner.OrderID)
            //                {
            //                    Console.WriteLine(" {0}",ininer.CustomerID);
            //                }
            //            }
            //        }
            //    }
            //}
            //Console.ReadLine();

            // Task 10

            //var employeesTotalSum = from employeeSum in (from employees in (from order in m.Orders.ToList()
            //                                                                join orderDetails in m.Order_Details.ToList()
            //                                                                on order.OrderID equals orderDetails.OrderID
            //                                                                select new
            //                                                                {
            //                                                                    order.EmployeeID,
            //                                                                    Sum = orderDetails.Quantity * orderDetails.UnitPrice
            //                                                                })
            //                                             group employees by employees.EmployeeID into e
            //                                             select new
            //                                             {
            //                                                 EmployeeId = e.Key,
            //                                                 TotalSum = e.Sum(p => p.Sum)
            //                                             })
            //                        join employees in m.Employees
            //                        on employeeSum.EmployeeId equals employees.EmployeeID
            //                        select new { employees.FirstName, employees.LastName, employeeSum.TotalSum };

            //foreach(var item in employeesTotalSum)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} - {item.TotalSum}");
            //}


            // Task 11

            //var topThreeProducts = (from products in (from orderDetails in (from orderDetails in (from orderDetails in m.Order_Details.ToList()
            //                                                                   select new
            //                                                                   {
            //                                                                       ProductID = orderDetails.ProductID,
            //                                                                       Quantity = orderDetails.Quantity
            //                                                                   })
            //                                             group orderDetails by orderDetails.ProductID into od
            //                                             select new
            //                                             {
            //                                                 ProductId = od.Key,
            //                                                 TotalQuantity = od.Sum(p => p.Quantity)
            //                                             })
            //                       join products in m.Products
            //                       on orderDetails.ProductId equals products.ProductID
            //                       select new
            //                       {
            //                           products.ProductName,
            //                           orderDetails.TotalQuantity
            //                       })
            //                       orderby products.TotalQuantity descending
            //                       select products).Take(3);

            //foreach(var item in topThreeProducts)
            //{
            //    Console.WriteLine($"{item.ProductName}-{item.TotalQuantity}");
            //}

            // Task 12

            //var topThreeCountries = (from countries in (from groupedOrders in (from orders in m.Orders.ToList()
            //                                                                   select new
            //                                                                   {
            //                                                                       orders.ShipCountry,
            //                                                                       orders.OrderID
            //                                                                   })
            //                                            group groupedOrders by groupedOrders.ShipCountry into g
            //                                            select new
            //                                            {
            //                                                Country = g.Key,
            //                                                QuantityOfOrders = g.Count()
            //                                            })
            //                         orderby countries.Country descending
            //                         select countries.Country).Take(3);

            //foreach(var item in topThreeCountries)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadLine();
        }
    }
}
