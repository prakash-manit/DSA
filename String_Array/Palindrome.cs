// -----------------------------------------------------------------------
// <copyright file="Palindrome.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace DSA
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Palindrome
    {
        public static void ReverseString(string str)
        {
            char[] chars = str.ToCharArray();
            Console.WriteLine("Origional array: {0}", new string(chars));
            
            char[] newArray = new char[chars.Length];
            chars.CopyTo(newArray,0);

            int len = newArray.Length;
            for (int i = 0, j = len - 1; i < len/2; i++, j--)
            {
                char c = newArray[i];
                newArray[i] = newArray[len - i - 1];
                newArray[len - i - 1] = c;                               
            }

            Console.WriteLine("Reversed array: {0}", new string(newArray));

            if (string.Compare(new string(chars), new string(newArray)) == 0)
            {
                Console.WriteLine("Input is Palindrome");
            }
            else
            {
                Console.WriteLine("Input is not Palindrome");
            }            
        }                
    }
}
