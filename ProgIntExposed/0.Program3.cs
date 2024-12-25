using System;

namespace DSA
{
    class Program3
    {
        static void Main_02(string[] args)
        {
            int[] nums = new int[] { 7, 0, 11, 13, 9 };
            Console.WriteLine(MaxValueInArray.CompareToMax(nums));
            Console.WriteLine(MaxValueInArray.CompareToAll(nums));
            Console.WriteLine(MaxValueInArray.CompareToAll2(nums));


            //Console.WriteLine($"{CalculateFact(5)}");
            //Console.WriteLine($"{CalculateFactRec(5)}");

            char[] str1 = ("geeksforgeeks").ToCharArray();
            char[] str2 = ("forgeeksgeeks").ToCharArray();


            if (areAnagram(str1, str2))
                Console.WriteLine("The two strings are"
                                  + "anagram of each other");
            else
                Console.WriteLine("The two strings are not"
                                  + " anagram of each other");
        }


        static int NO_OF_CHARS = 256;

        static bool areAnagram(char[] str1, char[] str2)
        {
            // Create 2 count arrays and initialize 
            // all values as 0 
            int[] count1 = new int[NO_OF_CHARS];
            int[] count2 = new int[NO_OF_CHARS];

            if (str1.Length != str2.Length)
                return false;

            int i;

            // For each character in input strings, 
            // increment count in the corresponding 
            // count array 
            for (i = 0; i < str1.Length && i < str2.Length; i++)
            {
                count1[str1[i]]++;
                count2[str2[i]]++;
            }

            // Compare count arrays 
            for (i = 0; i < NO_OF_CHARS; i++)
                if (count1[i] != count2[i])
                    return false;

            return true;
        }

        private static int CalculateFactRec(int num)
        {
            if (num == 1)
            {
                return 1;
            }

            return num * CalculateFactRec(num - 1);
        }

        private static int CalculateFact(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        //Que.GetAllUniqueSetWhoseSumIsGivenNumber(5);
        //int [] result = ArrayManipulation.ReplaceArrayElementWithSum(new int[] { 5, 12, 18, 22, 27 });
        //foreach (int a in result )
        //{
        //    Console.WriteLine(a);
        //}

        //int[] tempA = new int[9] { 1, 8, 6, 2, 5, 9, 3, 7, 4 };
        ////int[] tempA2 = new int[5] { 1, 2, 3, 4, 5 };
        //int[] resultArray;
        ////float[] resultArray2;
        ////resultArray2 = PrefixAverage.PrefixAverages1(tempA2, tempA2.Length);
        ////resultArray2 = PrefixAverage.PrefixAverages2(tempA2, tempA2.Length);
        //resultArray = Insertion.InsertionSort(tempA);
        //resultArray = Quick.QuickSort_Rec(tempA, 0, tempA.Length - 1);

        //resultArray = Sort_Quick.QuickSort_Ite(tempA, 0, tempA.Length - 1);

        //foreach (int n in resultArray)
        //{
        //    Console.WriteLine(n);
        //}

        //Console.WriteLine(MaxValueInArray.CompareToMax(tempA)); 

        //int[] Arr1 = new int[7] { 2, 4, 5, 7, 8, 11, 14 };
        //Console.WriteLine("Position of key value is: {0}", BinarySearch.BinarySearchRecursive(Arr1, 2, 0, 6));
        //Console.WriteLine("Position of key value is: {0}", BinarySearch.BinarySearchIterative(Arr1, 14, 0, 6));
        //Console.WriteLine("The first Non-Repeted char of an string is: {0}", FirstNonRepeatedCharInString.FirstNonRepeatedCharInString3("ADBMBAD"));
        //Console.WriteLine("Reverse string: {0}", ReverseString.ReverseString1("PRAKASH TRIPATHI"));
        //Console.WriteLine("Reverse string: {0}", ReverseString.ReverseString2("PRAKASH TRIPATHI"));
        //Console.WriteLine("Reverse string: {0}", ReverseString.ReverseString3("PRAKASH TRIPATHI"));
        //Console.WriteLine("Reverse string: {0}", ReverseString.ReverseString4("PRAKASH TRIPATHI"));
        //Console.WriteLine("Reverse string: {0}", ReverseString.ReverseString5("PRAKASH TRIPATHI"));
        //Console.WriteLine("Reverse string: {0}", ReverseString.ReverseString6("PRAKASH TRIPATHI"));
        //Console.WriteLine("Reverse string: {0}", ReverseString.ReverseString7("PRAKASH TRIPATHI"));

        //Console.WriteLine("Reverse string: {0}", ReverseString.ReverseString_Rec("PRAKASH TRIPATHI"));   
        //Console.WriteLine("Reverse string: {0}", ReverseString.ReverseString_Rec2("PRAKASH TRIPATHI",0));

        //Console.WriteLine("Reverse words in sentence: {0}", ReverseWordsInString.ReverseWordsInString1("PRAKASH TRIPATHI"));
        //Console.WriteLine("Is it Prime? {0}", CheckPrimeNumber.CheckPrimeNumber1(89));
        //Console.WriteLine("Is it Prime? {0}", CheckPrimeNumber.CheckPrimeNumber2(89));
        //Console.WriteLine("Is it Prime? {0}", CheckPrimeNumber.CheckPrimeNumber3(89));
        //Console.WriteLine("Is it Prime? {0}", CheckPrimeNumber.CheckPrimeNumber4(89));

        //Console.WriteLine("Fact of number: {0}", Factorial.Factorial_Iterative(2));
        //Console.WriteLine("Fact of number: {0}", Factorial.Factorial_Recursive(6));
        //Console.WriteLine("Is Leap Year? {0}",LeapYear.IsLeapYear(1900));
        //Fibonacci.Fibonacci_Iterative(9); Console.WriteLine();

        //Fibonacci.Fibonacci_Recursive(11); Console.WriteLine();

        //Fibonacci.Fibonacci_Recursive2(9);
        //Console.WriteLine(Fibonacci.GetNthFibonacci_Rec(8-1));
        //Console.WriteLine(Fibonacci.GetNthFibonacci_Ite(8));

        //Console.WriteLine(SquareRoot.FindSquareRoot1(9));
        //Console.WriteLine(SquareRoot.FindSquareRoot_BS(9));

        //int[] stockPriceArray = new int[7] { 6, 4, 1, 2, 1, 3, 7 };
        //int[] spanArray;
        //spanArray = ComputeSpan.ComputeSpan1(stockPriceArray);
        //foreach (int i in spanArray)
        //{
        //    Console.WriteLine(i);
        //}
        //Console.WriteLine();
        //spanArray = ComputeSpan.ComputeSpan2(stockPriceArray);
        //foreach (int i in spanArray)
        //{
        //    Console.WriteLine(i);
        //}      

        //Sort s = new Sort();
        //int [] arr = new int[] {8, 6, 5, 3, 1};
        ////s.BubbleSort(arr);
        //s.InsertionSort(arr);

        //Queue que = new Queue();
        //Console.WriteLine("Enqued: {0}" ,que.Enque(10));
        //Console.WriteLine("Enqued: {0}", que.Enque(8));
        //Console.WriteLine("Enqued: {0}", que.Enque(7));
        //Console.WriteLine("Enqued: {0}", que.Enque(13));
        //Console.WriteLine("Enqued: {0}", que.Enque(15));

        //Console.WriteLine("Dequed: {0}", que.Deque());
        //Console.WriteLine("Dequed: {0}", que.Deque());
        //Console.WriteLine("Dequed: {0}", que.Deque());

        //ReverseNumber.ReverseNumber1(100);
        //Palindrome.ReverseString("12321");

        //PrimePrint.PrintPrimeNumber1(100);
        //PrimePrint.PrintPrimeNumber2(100);
        //PrimePrint.PrintPrimeNumber3(100);
        //PrimePrint.PrintPrimeNumber4(100);

        //LinkedList ll = new LinkedList();
        ////Console.WriteLine("Size: {0}", ll.Size());
        //Console.WriteLine("Added Item: {0}", ll.Insert(10));
        //Console.WriteLine("Added Item: {0}", ll.Insert(11));
        //Console.WriteLine("Added Item: {0}", ll.Insert(12));
        //Console.WriteLine("Added Item: {0}", ll.Insert(8));
        //Console.WriteLine("Added Item: {0}", ll.Insert(7));
        //Console.WriteLine();
        //Console.Write("Size: {0}", ll.Size());
        //ll.Print();
        //ll.InsertAfter(12, 15);
        //ll.Print();
        //ll.ReversePrint();
        //ll.SplitPrint();
        //ll.Find(10);
        //ll.Find(13);

        //Console.WriteLine("Deleted Item: {0}", ll.Delete());
        //Console.WriteLine("Deleted Item: {0}", ll.Delete());           
        //Console.WriteLine("Size: {0}", ll.Size());
        //ll.Print();
        //Console.WriteLine("Deleted Item: {0}", ll.Delete());
        //Console.WriteLine("Deleted Item: {0}", ll.Delete());           
        //Console.WriteLine("Size: {0}", ll.Size());
        //ll.Print();
        //Stack_Array sa = new Stack_Array();
        //Console.WriteLine(sa.Peek());
        //Console.WriteLine(sa.Pop());
        //Console.WriteLine(sa.Push(2));
        //Console.WriteLine(sa.Push(1));
        //Console.WriteLine(sa.Push(3));
        //Console.WriteLine(sa.Pop());
        //Console.WriteLine(sa.Peek());
        //Console.WriteLine(sa.Pop());
        //Console.WriteLine(sa.Peek());

        //Console.WriteLine("Stack with Array");
        //Stack_Array sa = new Stack_Array();
        //Console.WriteLine(sa.Peek());
        //Console.WriteLine(sa.Pop());
        //Console.WriteLine(sa.Push(2));
        //Console.WriteLine(sa.Push(1));
        //Console.WriteLine(sa.Push(3));
        //Console.WriteLine(sa.Pop());
        //Console.WriteLine(sa.Peek());
        //Console.WriteLine(sa.Pop());
        //Console.WriteLine(sa.Peek());
        //Console.WriteLine(sa.Pop());
        //Console.WriteLine(sa.Pop());

        //Console.WriteLine("\nStack with Queue");
        //Stack_LL sl = new Stack_LL();
        //Console.WriteLine(sl.Peek());
        //Console.WriteLine(sl.Pop());
        //Console.WriteLine(sl.Push(2));
        //Console.WriteLine(sl.Push(1));
        //Console.WriteLine(sl.Push(3));
        //Console.WriteLine(sl.Pop());
        //Console.WriteLine(sl.Peek());
        //Console.WriteLine(sl.Pop());
        //Console.WriteLine(sl.Peek());
        //Console.WriteLine(sl.Pop());
        //Console.WriteLine(sl.Pop());
    }
}
