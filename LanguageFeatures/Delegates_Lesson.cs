using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace LanguageFeatures
{
    /*
     * 1. lambda expressions are shorthand for anonymous functions.
     * 2. Anonymous functinos make it easier to write delegate code without
     *    the need to declare a function.
     * 3. The class Func, Action and Predicate are ready made delegate.
     * 4. Func<Type, Type> specifies that up to 9 T can be used for input 
     *    and the last specified is the output. 
     * 5. Action returns void but requires input.
     * 6. Predicates return a boolean value.
     */
    class Delegates_Lesson
    {
        public Delegates_Lesson()
        {
            UseFunc();
        }
        void UseFunc()
        {
            Func<double, double, string> getArea = (x , y) => (3.14 * x * y) .ToString();
            string area = getArea(20, 15);
        }
        void UseAction()
        {
            Action<string> action = x => Console.WriteLine(x);
        }
        void UsePredicate()
        {
            Predicate<int> predicate = x => x == 5;
            bool isFive = predicate(5);
        }
    }
}
