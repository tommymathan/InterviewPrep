using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleStocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stockPrices = { 15, 4, 7, 9, };
            int[] stockPrices2 = { 15, 4, 7, 9, 1, 19 };


            int maxProfit = MaxProfitFromYesterday(stockPrices);
            int maxProfit2 = MaxProfitFromYesterday(stockPrices2);
            
        }

        public static int MaxProfitFromYesterday(int[] stockPricesFromYesterday)
        {
            if (stockPricesFromYesterday.Length < 2)
            {
                throw new ArgumentException("Getting a profit requires at least 2 prices",
                    nameof(stockPricesFromYesterday));
            }

            int lowestPrice = stockPricesFromYesterday[0];
            int maxProfit = stockPricesFromYesterday[1] - stockPricesFromYesterday[0];

            for(int i = 1; i < stockPricesFromYesterday.Length; i++)
            {
                int currentPrice = stockPricesFromYesterday[i];
                int currentProfit = currentPrice - lowestPrice;
                lowestPrice = Math.Min(currentPrice, lowestPrice);
                maxProfit = Math.Max(maxProfit, currentProfit);
            }

            return maxProfit;
        }
    }
}
