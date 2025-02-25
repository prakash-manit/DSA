using System;
using System.Runtime.InteropServices;

namespace DSA
{
    class ReverseString
    {
        /// <summary>
        /// Reverses the string1. Complexity: O(n)
        /// </summary>
        /// <param name="str">Need one extra array for result, need to taverse full array</param>
        /// <returns></returns>
        public static string ReverseString1(string str)
        {
            char[] chars = str.ToCharArray();
            char[] result = new char[chars.Length];

            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                result[i] = chars[j];
            }

            return new string(result);
        }

        /// <summary>
        /// Reverses the string2. Complexity: O(n)/2 ~ O(n)
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public static string ReverseString2(string str)
        {
            char[] chars = str.ToCharArray();

            //for (int i = 0, j = str.Length-1; i < str.Length / 2; i++, j--)
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }
            return new string(chars);
        }
        /// <summary>
        /// Here is the use of in-place swap without any temp variable
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseString3(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }
            return new string(chars);
        }
        /// <summary>
        /// String Reversal without Copy to Char Array it's i <= j as we need to get the 
        /// middle character in case of odd number of characters in the string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseString3b(string str)
        {
            char[] chars = new char[str.Length];
            for (int i = 0, j = str.Length - 1; i <= j; i++, j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }
            return new string(chars);
        }

        /// <summary>
        /// String traversal with stack
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseString4(string str)
        {
            Stack_Array_v2 stk1 = new Stack_Array_v2(str.Length);
            foreach (char c in str)
                stk1.Push(c);
            string revString = null;
            foreach (char c in str)
                revString += stk1.Pop();
            return revString;
        }
        /// <summary>
        /// String traversal with XOR (^); interesting way to traversal
        /// A [i] = A[i] ^ A[len] -> A[i]  = 80 ^ 73 -> A[i] = 25
        /// A [len] = A[len] ^ A[i] -> A[len]  = 73 ^ 25 -> A[len] = 80
        /// A [i] = A[i] ^ A[len] -> A[i]  = 25 ^ 80 -> A[i] = 73
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseString5(string str)
        {
            char[] inputstream = str.ToCharArray();
            int length = str.Length - 1;
            for (int i = 0; i < length; i++, length--)
            {
                inputstream[i] ^= inputstream[length];
                inputstream[length] ^= inputstream[i];
                inputstream[i] ^= inputstream[length];
            }
            return new string(inputstream);
        }

        public static string ReverseString6(string str)
        {
            char[] revStr = new char[str.Length];
            GCHandle handle = GCHandle.Alloc(str, GCHandleType.Pinned);
            IntPtr pointer = handle.AddrOfPinnedObject();
            for (int i = 0, j = str.Length - 1; j >= 0; --j, ++i)
            {
                revStr[i] = (char)Marshal.ReadByte(pointer, 2 * j);
            }
            handle.Free();
            return new string(revStr);
        }

        public static string ReverseString7(string str)
        {
            string reverseStr = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseStr += str[i];
            }
            return reverseStr;
        }

        //// ReverseString_Rec("Hello")
        //// (ReverseString_Rec("ello")) + "H"
        //// ((ReverseString_Rec("llo")) + "e") + "H"
        //// (((ReverseString_Rec("lo")) + "l") + "e") + "H"
        //// ((((ReverseString_Rec("o")) + "l") + "l") + "e") + "H"
        //// (((("o") + "l") + "l") + "e") + "H"
        //// "olleH"
        public static string ReverseString_Rec(string str)
        {
            if (str.Length <= 1)
                return str;
            else
                return ReverseString_Rec(str.Substring(1)) + str[0];
        }
        /// <summary>
        /// Another way of recursion; need to pass index as 0
        /// </summary>
        /// <param name="chars"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string ReverseString_Rec2(string str, int index)
        {
            char[] chars = str.ToCharArray();
            int len = chars.Length;
            if (index < len / 2)
            {
                char c = chars[index];
                chars[index] = chars[len - index - 1];
                chars[len - index - 1] = c;
                index++;
                return ReverseString_Rec2(new string(chars), index);
            }
            else
            {
                return new string(chars);
            }
        }
    }
}
