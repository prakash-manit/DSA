using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgQues
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
