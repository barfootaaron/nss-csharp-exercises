using System;
// using System.Linq;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("HCA", "HCA Healthcare");
            stocks.Add("AAPL", "Apple Computers");
            stocks.Add("MSFT", "Microsoft");

            // string GM = stocks["GM"];
            // Console.WriteLine(GM);

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add(("GM", 10, 500));
            purchases.Add(("CAT", 15, 400));
            purchases.Add(("HCA", 12, 600));
            purchases.Add(("AAPL", 4, 300));
            purchases.Add(("MSFT", 1, 250));

            /* 
                Define a new Dictionary to hold the aggregated purchase information.
                - The key should be a string that is the full company name.
                - The value will be the valuation of each stock (price*amount)

                {
                    "General Electric": 35900,
                    "AAPL": 8445,
                    ...
                }
            */
            Dictionary<string, double> purchaseInfo = new Dictionary<string, double>();

            // Iterate over the purchases and 
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                // Does the company name key already exist in the report dictionary?
                // If it does, update the total valuation
                // If not, add the new key and set its value
                if (stocks.ContainsKey(purchase.ticker)) 
                {
                    if (purchaseInfo.ContainsKey(stocks[purchase.ticker]))
                    {
                        purchaseInfo[stocks[purchase.ticker]] += purchase.price * purchase.shares;
                    } else
                    {
                        purchaseInfo.Add(stocks[purchase.ticker], purchase.price * purchase.shares);
                    }
                } 
            }

            foreach (KeyValuePair<string, double> stock in purchaseInfo)
            {
                Console.WriteLine(stock);
            }
            // Console.Read();

        }
    }
}
