using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgQues.ProgIntExposed
{
    class Program
    {
        static void Main_02(string[] args)
        {
            Console.WriteLine("Stack with Array");
            Stack_Array sa = new Stack_Array();
            Console.WriteLine(sa.Peek());
            Console.WriteLine(sa.Pop());
            Console.WriteLine(sa.Push(2));
            Console.WriteLine(sa.Push(1));
            Console.WriteLine(sa.Push(3));
            Console.WriteLine(sa.Pop());
            Console.WriteLine(sa.Peek());
            Console.WriteLine(sa.Pop());
            Console.WriteLine(sa.Peek());
            Console.WriteLine(sa.Pop());
            Console.WriteLine(sa.Pop());

            Console.WriteLine("\nStack with Queue");
            Stack_LL sl = new Stack_LL();
            Console.WriteLine(sl.Peek());
            Console.WriteLine(sl.Pop());
            Console.WriteLine(sl.Push(2));
            Console.WriteLine(sl.Push(1));
            Console.WriteLine(sl.Push(3));
            Console.WriteLine(sl.Pop());
            Console.WriteLine(sl.Peek());
            Console.WriteLine(sl.Pop());
            Console.WriteLine(sl.Peek());
            Console.WriteLine(sl.Pop());
            Console.WriteLine(sl.Pop());
        }       
    }    
}
