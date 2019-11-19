using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thExercise_BalancedBrackets
{
    public class BracketsEvaluator
    {
        public bool AreBracketsBalanced(string stringToValidate)
        {
            Dictionary<char, char> listOfPossibleBrackets = new Dictionary<char, char>();
            listOfPossibleBrackets.Add('[', ']');
            listOfPossibleBrackets.Add('{', '}');
            listOfPossibleBrackets.Add('(', ')');
            listOfPossibleBrackets.Add('<', '>');

            Stack<char> stack = new Stack<char>();
            try
            {
                foreach (char character in stringToValidate)
                {
                    if (listOfPossibleBrackets.Keys.Contains(character))
                        stack.Push(character);

                    else if (listOfPossibleBrackets.Values.Contains(character))
                    {
                        if (character == listOfPossibleBrackets[stack.First()])
                            stack.Pop();
                    }
                    else
                        continue;
                }
            }
            catch
            {
                return false;
            }
            if (stack.Count == 0)
                return true;

            return false;
        }
    }
}
