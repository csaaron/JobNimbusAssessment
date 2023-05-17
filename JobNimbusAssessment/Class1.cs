using System.Collections.Generic;

namespace JobNimbusAssessment
{
    public class Class1
    {
        public static bool HasMatchingBrackets(string target)
        {
            const char OPEN_BRACKET = '<';
            const char CLOSE_BRACKET = '>';
            
            if (target == null)
            {
                return true;
            }

            Stack<char> openBrackets = new Stack<char>();
            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] == OPEN_BRACKET)
                {
                    openBrackets.Push(OPEN_BRACKET);
                }

                if (target[i] == CLOSE_BRACKET && openBrackets.Count < 1)
                {
                    return false;
                }
                else if (target[i] == CLOSE_BRACKET)
                {
                    openBrackets.Pop();
                }
            }

            return openBrackets.Count == 0;
        }
    }
}
