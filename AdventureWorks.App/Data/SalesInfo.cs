using System;
using System.Collections.Generic;

namespace AdventureWorks.App.Data {
    public class SalesInfo {
        public string Name { get; set; }
        public int Quota { get; set; }
        public int Ytd { get; set; }
    }

    public static class ListExtensions {
        // Basically a Polyfill since we now expose IList instead of List
        // which is better but IList doesn't have AddRange
        public static void AddRange<T>(this IList<T> list, IEnumerable<T> items) {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (items == null)
                throw new ArgumentNullException(nameof(items));

            if (list is List<T> asList) {
                asList.AddRange(items);
            }
            else {
                foreach (T item in items) {
                    list.Add(item);
                }
            }
        }
    }
}