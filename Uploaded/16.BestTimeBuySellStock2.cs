using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA
{
    internal class BestTimeBuySellStock2
    {
        public static void Driver()
        {

            //Console.WriteLine("Please enter the size of input array!");
            //int m = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter the element of array by seperating space!");
            //int[] nums = new int[m];
            //nums = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            int[] nums = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine($"Max ProfitMaxProfit: {MaxProfit5(nums)}");
        }

        private static int MaxProfit5(int[] prices)
        {
            int n = prices.Length;
            int currNotBuy, nextNotBuy = 0;
            int currBuy, nextBuy = 0;

            for (int idx = n - 1; idx >= 0; idx--)
            {
                currNotBuy = Math.Max(prices[idx] + nextBuy, 0 + nextNotBuy);
                currBuy = Math.Max(-prices[idx] + nextNotBuy, 0 + nextBuy);

                nextBuy = currBuy;
                nextNotBuy = currNotBuy;
            }
            return nextBuy;
        }

        private static int MaxProfit4(int[] prices)
        {
            int n = prices.Length;
            List<int> next = new List<int> { 0, 0 };
            List<int> current = new List<int> { 0, 0 };

            next[0] = next[1] = 0;

            for (int idx = n - 1; idx >= 0; idx--)
            {
                for (int buy = 0; buy <= 1; buy++)
                {
                    int maxProfit;
                    if (buy == 1)
                    {
                        maxProfit = Math.Max(-prices[idx] + next[0],
                                                0 + next[1]);
                    }
                    else
                    {
                        maxProfit = Math.Max(prices[idx] + next[1],
                                                0 + next[0]);
                    }
                    current[buy] = maxProfit;
                }
                next = current;
            }

            return next[1];
        }

        private static int MaxProfit3(int[] prices)
        {
            int n = prices.Length;
            List<List<int>> list = new List<List<int>>(n + 1);
            for (int i = 0; i <= n; i++)
            {
                list.Add(new List<int> { 0, 0 });
            }            

            for (int idx = n - 1; idx >= 0; idx--)
            {
                for (int buy = 0; buy <= 1; buy++)
                {
                    int maxProfit;
                    if (buy == 1)
                    {
                        maxProfit = Math.Max(-prices[idx] + list[idx + 1][0],
                                                0 + list[idx + 1][1]);
                    }
                    else
                    {
                        maxProfit = Math.Max(prices[idx] + list[idx + 1][1],
                                                0 + list[idx + 1][0]);
                    }
                    list[idx][buy] = maxProfit;
                }
            }

            return list[0][1];
        }

        private static int MaxProfit2(int[] prices)
        {
            List<List<int>> list = new List<List<int>>(prices.Length + 1);
            for (int i = 0; i < prices.Length; i++)
            {
                list.Add(new List<int> { -1, -1 });
            }
            return getMaxProfit2(0, 1, prices, prices.Length, list);
        }

        private static int getMaxProfit2(int idx, int buy, int[] prices, int n, List<List<int>> list)
        {
            if (idx == n) return 0;
            if (list[idx][buy] != -1) return list[idx][buy];

            int maxProfit;
            if (buy == 1)
            {
                maxProfit = Math.Max(-prices[idx] + getMaxProfit2(idx + 1, 0, prices, n, list),
                                        0 + getMaxProfit2(idx + 1, 1, prices, n, list));
            }
            else
            {
                maxProfit = Math.Max(prices[idx] + getMaxProfit2(idx + 1, 1, prices, n, list),
                                        0 + getMaxProfit2(idx + 1, 0, prices, n, list));
            }
            return list[idx][buy] = maxProfit;
        }

        private static int MaxProfit(int[] prices)
        {
            return getMaxProfit(0, 1, prices, prices.Length);
        }

        private static int getMaxProfit(int idx, int buy, int[] prices, int n)
        {
            if (idx == n) return 0;

            int maxProfit;
            if (buy == 1)
            {
                maxProfit = Math.Max(-prices[idx] + getMaxProfit(idx + 1, 0, prices, n),
                                        0 + getMaxProfit(idx + 1, 1, prices, n));
            }
            else
            {
                maxProfit = Math.Max(prices[idx] + getMaxProfit(idx + 1, 1, prices, n),
                                        0 + getMaxProfit(idx + 1, 0, prices, n));
            }
            return maxProfit;
        }
    }
}
