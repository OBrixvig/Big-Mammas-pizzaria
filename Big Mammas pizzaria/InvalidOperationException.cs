using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mammas_pizzaria
{
    public static class InvalidOperationException
    {

        public static void AddUniqueItem<T>(this List<T> list, T item, bool throwException)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
            }
            else if (throwException)
            {
                throw new System.InvalidOperationException("Pizzaen er allerede i menuen");
            }
        }
        public static bool IsUnique<T>(this List<T> list, IEqualityComparer<T> comparer)
        {
            return list.Count == list.Distinct(comparer).Count();
        }
        public static bool IsUnique<T>(this List<T> list)
        {
            return list.Count == list.Distinct().Count();
        }
    }
}
