using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdExercise_StringCompression
{
    public class StringCompression
    {
        public string StringCompressionProcess(string originalString)
        {
            char current = originalString[0];
            int count = 0;
            StringBuilder stringCompressed = new StringBuilder();

            for (int i = 0; i < originalString.Length; i++)
            {
                if (current == originalString[i])
                {
                    count += 1;
                }
                if (current != originalString[i] || (i + 1) == originalString.Length) /*or if is the last element*/
                {
                    stringCompressed.Append(current.ToString() + count);
                    count = 0;
                    current = originalString[i];
                    count += 1;
                }

            }
            return stringCompressed.ToString();
        }
    }
}
