using DSnA;
using System;

namespace Singleton
{
    class Program
    {   
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                //showMenu = StackCustom.MainMenu();
                showMenu = QueueCustom.MainMenu();
            }
        }

        
    }
}