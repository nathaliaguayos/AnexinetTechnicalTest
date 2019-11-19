using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdExercise_StringCompression
{
    /// <summary>
    /// Write a function to perform basic string compression using the counts 
    /// of repeated characters; e.g "aabcccccaaa" would become "a2b1c5a3". 
    /// If the compressed string would not become smaller than the original string, 
    /// just print the original string.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Write a function to perform basic string compression using the counts 
        /// of repeated characters; e.g "aabcccccaaa" would become "a2b1c5a3". 
        /// If the compressed string would not become smaller than the original string, 
        /// just print the original string.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string originalString = "aabcccccaaa"; // aabcccccaaadfrgt
            StringCompression stringCompression = new StringCompression();
            string stringCompressed = stringCompression.StringCompressionProcess(originalString);
            if (stringCompressed.Length < originalString.Length)
                Console.WriteLine(stringCompressed);
            else
                Console.WriteLine(originalString);
        }
        
    }
}
