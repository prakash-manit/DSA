namespace DSA
{
    class Factorial
    {
        public static int Factorial_Iterative(int num)
        {
            int result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int Factorial_Recursive(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * Factorial_Recursive(num - 1);
            }
        }
    }
}
