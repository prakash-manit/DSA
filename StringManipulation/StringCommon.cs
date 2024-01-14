// -----------------------------------------------------------------------
// <copyright file="Common.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace ProgQues.General.StringManipulation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Configuration;
    using System.IO;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class StringCommon
    {
        //write a program that takes in a sentence. It should then remove the spaces and print out that sentence 
        //backwards alternating between upper and lowercase letters
        public static void RemoveSpaceReverseAndPrintAltCases(string input)
        {
            //input = "my name is prakash tripathi";
            Console.WriteLine("Input sentence: " + input);
            //string[] tempArray = input.Split(' ');
            //string inputWithoutSpaces = String.Join("", tempArray);
            string inputWithoutSpaces = input.Replace(" ", "");
            char[] charArray = inputWithoutSpaces.ToCharArray();
            Console.WriteLine("Input sentence without spaces: " + inputWithoutSpaces);
            Console.WriteLine("Final string is: ");
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.Write(charArray[i].ToString().ToUpper());
                }
                else
                {
                    Console.Write(charArray[i].ToString());
                }
            }
        }

        //Program to find the number of lines in a text files
        public static void NumberOfLinesInFile()
        {
            string filePath = ConfigurationManager.AppSettings["filePath"];
            StreamReader sr = new StreamReader(filePath);
            int linesInFile = 0;

            while (!sr.EndOfStream)
            {
                if (sr.Read() == '\n')
                {
                    linesInFile++;
                }

            }
            Console.WriteLine("The number of lines in the file " + filePath.Split('\\')[filePath.Split('\\').Length - 1] + " is: " + linesInFile);
        }
    }
}
