namespace DSA
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FirstNonRepeatedCharInString
    {
        /// <summary>
        /// Firsts the non repeated character in string. Complexity: O(n^2)
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public static char FirstNonRepeatedCharInString1 (string str)
        {
            int i, j;
            bool isRepeted = false;

            char[] chars = str.ToCharArray();

            for (i=0; i<chars.Length;i++)
            {
                isRepeted = false;
                for (j=0;j<chars.Length;j++)
                {
                    if ((i!=j) && (chars[i]==chars[j]))
                    {
                        isRepeted = true;
                        break;
                    }
                }

                if (isRepeted ==false)
                {
                    return chars[i];
                }
            }
            return ' ';
        }

        /// <summary>
        /// Firsts the non repeated character in string2. Complexity: O(n)
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public static char FirstNonRepeatedCharInString2(string str)
        {
            Dictionary<char, int> l1 = new Dictionary<char, int>();
            int temp = 0;

            foreach (char c in str.ToCharArray())
            {
                if (l1.Keys.Contains(c))
                {
                    temp = l1[c];
                    l1[c] = temp + 1;
                    continue;
                }
                l1.Add(c,1);
            }

            if (l1.Values.Contains(1))
            {
                return l1.First(x => x.Value == 1).Key;
            }
            return ' ';
        }

        /// <summary>
        /// Firsts the non repeated character in string3. Complexity: O(256) + O(n) + O(n) = O(n)
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public static char FirstNonRepeatedCharInString3(string str)
        {
            int[] chars = new int[256];
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = 0;
            }

            for (int i = 0; i < str.Length; i++)
            {
                chars[str[i]]++;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (chars[str[i]] == 1)
                {
                    return str[i];
                }
            }
            return ' ';
        }
    }
}
