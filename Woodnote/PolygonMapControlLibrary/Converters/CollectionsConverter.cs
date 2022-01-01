using System;
using System.Collections.Generic;
using System.Linq;

namespace PolygonMapControlLibrary.Converters
{
    internal static class CollectionsConverter
    {
        public static IEnumerable<T> ConvertCollection<T, D>(IEnumerable<D> collection, Func<D, T> convertSingleInstance)
        {
            return collection.Select(x => convertSingleInstance(x));
        }
    }
}
