using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stExercise_LeapYear
{
    public class FindingALeapYear
    {
        public bool IsLeapYear(String stringDate)
        {
            try
            {
                DateTime date = Convert.ToDateTime(stringDate);
                if ((date.Year % 4 == 0) && (date.Year % 100 != 0) || (date.Year % 400 == 0))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new FormatException();
            }
            return false;
        }
    }
}
