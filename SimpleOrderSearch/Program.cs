using System;
using SampleOrderSearch.Service;
using SampleOrderSearch.Model;


namespace SampleOrderSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Service and add data
            ServiceImpl s = new ServiceImpl();

            s.CreateOrder(36, 4, 35, new DateTime(2018, 1, 12, 5, 10, 0), 10, "R4C877FF", 1, 92.00, 1);
            s.CreateOrder(37, 4, 243, new DateTime(2018, 2, 15, 5, 10, 0), 10, "R47077FF", 1, 43.00, 1);
            s.CreateOrder(38, 4, 35, new DateTime(2018, 1, 31, 5, 10, 0), 10, "R6453FF", 2, 120.00, 1);
            s.CreateOrder(39, 4, 35, new DateTime(2018, 1, 31, 5, 10, 0), 10, "R4C877DS", 4, 15.00, 1);
            s.CreateOrder(40, 4, 35, new DateTime(2018, 1, 31, 5, 10, 0), 10, "R4C9999F", 1, 111.00, 1);
            s.CreateOrder(41, 67, 35, new DateTime(2018, 1, 31, 5, 10, 0), 10, "R4C87S32", 1, 54.00, 1);
            s.CreateOrder(42, 4, 35, new DateTime(2018, 1, 31, 5, 10, 0), 10, "R4C87123", 1, 92.00, 1);
            s.CreateOrder(43, 4, 35, new DateTime(2018, 2, 15, 5, 10, 0), 10, "R42G77FF", 1, 40.00, 1);
            s.CreateOrder(44, 4, 35, new DateTime(2018, 1, 31, 5, 10, 0), 20, "R4002WFF", 3, 23.00, 2);
            s.CreateOrder(45, 4, 35, new DateTime(2018, 1, 31, 5, 10, 0), 20, "R400KHFF", 3, 23.00, 1);
            s.CreateOrder(46, 24, 35, new DateTime(2018, 1, 31, 5, 10, 0), 61, "R4C437FF", 1, 92.00, 1);
            s.CreateOrder(47, 121, 35, new DateTime(2018, 3, 1, 5, 10, 0), 10, "R422AQF", 1, 66.00, 2);

            // Get orders and print
            var result = s.GetOrdersByFields(36, 1, 10, new DateTime(2018, 1, 31, 5, 10, 0));
            foreach (OrderInfo orderInfo in result)
            {
                Console.WriteLine("OrderId : " + orderInfo.OrderId);
                Console.WriteLine("ShipperId : " + orderInfo.ShipperId);
                Console.WriteLine("DriverId : " + orderInfo.DriverId);
                Console.WriteLine("CompletionDate : " + orderInfo.CompletionDate);
                Console.WriteLine("Status : " + orderInfo.Status);
                Console.WriteLine("Code : " + orderInfo.Code);
                Console.WriteLine("MSA : " + orderInfo.MSA);
                Console.WriteLine("Duration : " + orderInfo.Duration);
                Console.WriteLine("OfferType : " + orderInfo.OfferType);
                Console.WriteLine("***************************");
            }
        }
    }
}
