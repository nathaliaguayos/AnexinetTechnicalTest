using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thExercise_BalancedBrackets
{
    public class Program
    {
        /// <summary>
        /// Write a function that receives a string and validates if 
        /// all the next brackets '[', '(' are properly closed '), ']' . 
        /// Here are some examples:
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {

            string stringToValidate = "()[]([])([][])(())";
            BracketsEvaluator bracketsEvaluator = new BracketsEvaluator();

            if (bracketsEvaluator.AreBracketsBalanced(stringToValidate))
                Console.WriteLine("The brackets are properly balanced");
            else
                Console.WriteLine("The brackets are not properly balanced");
        }
       
    }
}
