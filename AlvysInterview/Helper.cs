using System;
using System.Collections.Generic;

namespace AlvysInterview
{
    public class Helper
    {
        //If changing or return type from List<B> to IEnumerable<B>, we could use this implementation
        public static IEnumerable<B> Map1<A, B>(List<A> list, Func<A, B> f)
        {
            foreach (A x in list) yield return f(x);
        }

        //Implementation without changing return type
        public static List<B> Map<A, B>(List<A> list, Func<A, B> f)
        {
            List<B> result = new List<B>();
            foreach (A x in list)
            {
                result.Add(f(x));
            }
            return result;
        }

        public static B Fold<A, B>(List<A> list, B initial, Func<B, A, B> folder)
        {
            dynamic result = default(B);
            List<B> changedElements = new List<B>();

            foreach (A x in list)
            {
                changedElements.Add(folder(initial, x));
            }

            foreach (var element in changedElements)
            {
                result += element;
            }

            return result;
        }

        public static List<B> Map2<A, B>(List<A> list, Func<A, B> f)
        {
            List<B> result = new List<B>();
            Func<B, A, B> f1 = (x, y) => f(y);

            foreach (A x in list)
            {
                var singleElementList = new List<A>() { x };
                result.Add(Fold(singleElementList, default(B), f1));
            }

            return result;
        }
    }
}
