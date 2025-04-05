using System;

namespace DSA
{
    public class Pow_X_N
    {
        public static void Driver()
        {
            double x = 2.00000;
            int n = -2147483648;
            Console.Write(MyPow2(x,n));
        }

        private static double MyPow2(double x, int n) 
        {
            double ans = 1;
            bool neg = false;
            long num = n;
            if (num < 0) {
                neg = true;
                num = -1 * num;
            }

            while (num > 0) {              
                if (num % 2 == 0) { //TC: O(log n), SC: O(1)
                    x = x*x;
                    num = num/2;
                } else {
                    ans = ans * x;
                    num = num-1;
                }
            }

            if (neg == true){
                ans = 1/ans;
            }          
            return ans;
        }

        private static double MyPow(double x, int n) 
        {
            double ans = 1;
            bool neg = false;
            if (n < 0) {
                neg = true;
                n = -n;
            }
            for (int i = 1; i<= n; i++) { //TC: O(n), SC: O(1)
                ans  = ans * x;
            }
            if (neg == true){
                ans = 1/ans;
            }          
            return ans;
        }
    }
}