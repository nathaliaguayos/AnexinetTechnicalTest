using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndExercise_RepeatedChars
{
    class Program
    {
        /// <summary>
        /// Given 2 strings of unknown characters (but it cannot be repeated) create a function 
        /// that returns an array of the characters that are repeated in both strings.
        /// NOTE: This is not the most efficient way but is the fastest way.
        /// </summary>
        static void Main(string[] args)
        {
            string firstString = "hjndx";
            string secondString = "kundx";
            RepeatedCharacters repeatedChars = new RepeatedCharacters();
            Console.WriteLine(repeatedChars.FindRepeatedCharacters(firstString, secondString));
        }
    }
}
