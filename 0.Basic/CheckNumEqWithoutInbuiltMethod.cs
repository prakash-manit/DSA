﻿// -----------------------------------------------------------------------
// <copyright file="CheckNumberEqualityWithoutInbuiltMethod.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace DSA
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class CheckNumEqWithoutInbuiltMethod
    {
        public static void CheckNumEqWithoutInbuiltMethod1(int a, int b)
        {
            //int a = 3;
            //int b = 4;
            if ((a & b) == a)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
}
