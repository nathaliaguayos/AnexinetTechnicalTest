using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stExercise_LeapYear
{
    public class Program
    {
        static void Main(string[] args)
        {
            string stringDate = "05/05/2000";
            FindingALeapYear findingALeapYear = new FindingALeapYear();
            if (findingALeapYear.IsLeapYear(stringDate))
            {
                Console.WriteLine("Is a Leap year");
            }
            else
            {
                Console.WriteLine("Is not a Leap year");
            }
        }
        
    }
}
