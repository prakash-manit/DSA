namespace DSA
{
    class PrimeCheck
    {
        public static bool CheckPrimeNumber1(int num)
        {
            if (num == 1 || num == 2)
                return false;
            for (int i = 3; i<num; i++)
            {
                if ((num % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckPrimeNumber2(int num)
        {
            if (num == 1 || num ==2)
                return false;
            for (int i = 3; i <= num/2; i++)
            {
                if ((num % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckPrimeNumber3(int num)
        {
            if (num == 1)
                return false;
            if (num > 2 && (num % 2) == 0)
            {
                return false;
            }
            for (int i = 3; i <= num / 2; i+=2)
            {
                if ((num % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckPrimeNumber4(int num)
        {
            if (num == 1)
                return false;
            if (num > 2 && (num % 2) == 0)
            {
                return false;
            }
            for (int i = 3; i*i <= num; i+=2)
            {
                if ((num % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
