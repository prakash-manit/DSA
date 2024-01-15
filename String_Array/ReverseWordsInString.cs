namespace DSA
{
    class ReverseWordsInString
    {
        public static string ReverseWordsInString1(string str)
        {
            string reverse = ReverseString.ReverseString2(str);
            string temp = "";
            foreach (string s in reverse.Split(' '))
            {
                temp += ReverseString.ReverseString2(s) + ' ';
            }

            return temp;
        }
    }
}
