using System.Collections.Generic;
using System.Linq;

namespace JobNimbusAssessment
{
    public class Class1
    {
        public static bool HasMatchingBrackets(string target)
        {
            return target.HasMatchingBrackets();
        }
    }

    internal static class ExtensionMethods
    {
        public static bool HasMatchingBrackets(this string target)
        {
            if (target == null)
            {
                return true;
            }

            const char OPEN_BRACKET = '<';
            const char CLOSE_BRACKET = '>';

            Stack<char> openBrackets = new Stack<char>();
            foreach(char character in target)
            {
                if (character == OPEN_BRACKET)
                {
                    openBrackets.Push(OPEN_BRACKET);
                }
                else if (character == CLOSE_BRACKET && !openBrackets.Any())
                {
                    return false;
                }
                else if (character == CLOSE_BRACKET)
                {
                    openBrackets.Pop();
                }
            }

            return !openBrackets.Any();
        }
    }
}
