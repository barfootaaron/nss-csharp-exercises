using System;
// using System.Linq;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

            transactions.Add(("Backpack", 35.99, 2));
            transactions.Add(("Pencil", 2.99, 10));
            transactions.Add(("Pen", 1.99, 5));
            transactions.Add(("Eraser", 2.99, 7));
            transactions.Add(("Lunchbox", 150.99, 15));

            double quantity = 0;
            double revenue = 0;

            foreach ((string product, double amount, int quantity) t in transactions)
            {
                // Logic goes here to look up quantity and amount in each transaction
                // Console.WriteLine($"Product: {t.product} {t.amount} {t.quantity}");
                quantity += t.quantity;
                revenue += t.amount; 
            }
            Console.WriteLine($"Items sold today: {quantity}");
            Console.WriteLine($"Total Revenue: ${revenue}");
        }
    }
}
