namespace JobNimbusAssessment
{
    public static class StringUtilities
    {
        /// <summary>
        /// Takes a string, target, and returns whether or not characters in the string have matching brackets. 
        /// Meaning for every '<' there is a corresponding '>'
        /// </summary>
        /// <returns>True if the string contains matching brackets, false if not.</returns>
        public static bool HasMatchingBrackets(string target)
        {
            const char OPEN_BRACKET = '<';
            const char CLOSE_BRACKET = '>';

            int openBrackets = 0;
            foreach (char character in target)
            {
                if (character == OPEN_BRACKET)
                {
                    openBrackets++;
                }
                else if (character == CLOSE_BRACKET)
                {
                    openBrackets--;
                }

                if (openBrackets < 0)
                {
                    return false;
                }
            }

            return openBrackets == 0;
        }
    }
}
