using System.Collections.Generic;

namespace BalancedBrackets
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string case1 = "{[()]}";
            string case2 = "[]{}()";
            string case3 = "({(){}[]})[]";
            string case4 = "{[(])}";
            string case5 = "[]{}()}";

            string balanced = IsBalancedBracket(case1);
            string balanced2 = IsBalancedBracket(case2);
            string balanced3 = IsBalancedBracket(case3);
            string balanced4 = IsBalancedBracket(case4);
            string balanced5 = IsBalancedBracket(case5);
        }

        private readonly static Dictionary<char, char> brackets = new Dictionary<char, char>
            {
                { '{','}'},
                { '(',')'},
                { '[',']'},
            };

        private static string IsBalancedBracket(string s)
        {
            if(string.IsNullOrWhiteSpace(s) || s.Length % 2 != 0)
            {
                return "No";
            }

            bool isBalanced = IsBalancedBetween(s, 0, s.Length - 1);

            //bool isSubsetMatch = IsSubsetMatch(s);

            return isBalanced ? "Yes" : "No";
        }

        private static bool IsBalancedBetween(string s, int start, int end)
        {
            if(start >= end) return true;

            bool isBalanced = false;
            var pairs = new HashSet<int>();

            for(int i = start; i < end; i++)
            {
                char c = s[i];

                if(brackets.ContainsKey(c))
                {
                    char pair = brackets[c];
                    int indexOfSecondPair = s.LastIndexOf(pair, end);

                    if(indexOfSecondPair > i)
                    {
                        isBalanced = IsBalancedBetween(s, i + 1, indexOfSecondPair - 1);
                        pairs.Add(indexOfSecondPair);
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
                else
                {
                    if(pairs.Contains(i))
                        continue;
                    else isBalanced = 
                            false;
                }
            }

            return isBalanced;
        }
    }
}