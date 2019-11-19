using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndExercise_RepeatedChars
{
    public class RepeatedCharacters
    {
        public char[] FindRepeatedCharacters(string firstString, string secondString)
        {
            var common = firstString.Intersect(secondString);
            return common.ToArray();
        }
    }
}
