using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpersLibrary.Components
{
    public static class Extensions
    {
       // public static IEnumerable Apply(this IEnumerable collection, Action actionToPerform)
        public static void Apply<T>(this IEnumerable<T> collection, Action<T> actionToPerform)
        {
            foreach (var item in collection)
            {
                actionToPerform(item);
            }
        }
        /*
        public static IEnumerable<T> Apply<T>(this IEnumerable<T> collection, Action<T> actionToPerform)
        {
            var result = new List<T>();
            foreach (var item in collection)
            {
                //result.Add(actionToPerform(item));
            }
           // return 
        }
        */
        public static IEnumerable<T> ApplyReturn<T>(this IEnumerable<T> collection, Func<T,T> actionToPerform)
        {
            foreach (var item in collection)
            {
                yield return actionToPerform(item);
            }
        }


        //Validation for ref types
        public static T CheckIfArgIsNull<T>(this T arg, string argName) where T:class
        {
            if (arg == null)
            {
                throw new ArgumentNullException(argName);
            }
            return arg;
        }

        //validation for struct types
        public static T? CheckIfArgIsNull<T>(this T? arg, string argName) where T : struct
        {
            if (!arg.HasValue)
            {
                throw new ArgumentNullException(argName);
            }
            return arg;
        }
    }
}
