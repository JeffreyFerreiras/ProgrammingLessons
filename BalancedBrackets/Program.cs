using System.Collections.Generic;

namespace BalancedBrackets
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string case1 = "{[()]}";        //yes
            string case2 = "[]{}()";        //yes
            string case3 = "({(){}[]})[]";  //yes
            string case4 = "{[(])}";        //no
            string case5 = "[]{}()}";       //no

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
            if (string.IsNullOrWhiteSpace(s) || s.Length % 2 != 0)
            {
                return "No";
            }

            bool isBalanced = IsBalancedBetween(s, 0, s.Length - 1);

            //bool isSubsetMatch = IsSubsetMatch(s);

            return isBalanced ? "Yes" : "No";
        }

        private static bool IsBalancedBetween(string s, int low, int high) //O(n) time, O(1) space
        {
            if (low >= high) return true;
            if (!brackets.ContainsKey(s[low])) return false;

            if (brackets[s[low]] == s[low + 1])
            {
                low += 2;

                return IsBalancedBetween(s, low, high);
            }

            while (s[high] != brackets[s[low]] && low < high)
            {
                if (brackets.ContainsKey(s[high - 1]) && brackets[s[high - 1]] == s[high])
                {
                    high -= 2;
                }
                else
                {
                    high--;
                }
            }

            if (high <= low) return false;

            return IsBalancedBetween(s, ++low, high);
        }

        //private static bool IsBalancedBetween(string s, int start, int end)
        //{
        //    if(start >= end) return true;

        //    bool isBalanced = false;
        //    var pairs = new HashSet<int>();

        //    for(int i = start; i < end; i++)
        //    {
        //        char c = s[i];

        //        if(brackets.ContainsKey(c))
        //        {
        //            char pair = brackets[c];
        //            int indexOfSecondPair = s.LastIndexOf(pair, end);

        //            if(indexOfSecondPair > i)
        //            {
        //                isBalanced = IsBalancedBetween(s, i + 1, indexOfSecondPair - 1);
        //                pairs.Add(indexOfSecondPair);
        //            }
        //            else
        //            {
        //                isBalanced = false;
        //            }
        //        }
        //        else
        //        {
        //            if(pairs.Contains(i))
        //                continue;
        //            else isBalanced = false;
        //        }
        //    }

        //    return isBalanced;
        //}
    }
}