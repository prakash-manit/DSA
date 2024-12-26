using System;
using System.Linq;

namespace DSA
{
    internal class BestTimeBuySellStock
    {
        public static void Driver()
        {

            Console.WriteLine("Please enter the size of input array!");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the element of array by seperating space!");
            int[] nums = new int[m];
            nums = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            //int[] nums = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine($"Max ProfitMaxProfit: {MaxProfit2(nums)}");
        }

        private static int MaxProfit(int[] prices)
        {
            int max = 0;
            int diff  = 0;
            for (int i = 0; i < prices.Length; i++) {
                for (int j = i+1; j<prices.Length; j++) {
                    diff = prices[j] - prices[i];
                    if (diff > max) {
                        max = diff;
                    }
                }
            }                      
            return max;
        }

        private static int MaxProfit2(int[] prices)
        {
            int maxPrice = 0;
            int diff = 0;
            int min = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                diff = prices[i] - min;
                maxPrice = Math.Max(maxPrice, diff);
                min = Math.Min(min, prices[i]);
            }
            return maxPrice;
        }
    }
}
