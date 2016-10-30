using System.Collections.Generic;

namespace Bogosoft.Mapping
{
    /// <summary>Mapping-specific extended functionality for enumerable types.</summary>
    public static class EnumerableExtensions
    {
        /// <summary>Project each element of a sequence into a new form.</summary>
        /// <typeparam name="TSource">The type of each element in the sequence.</typeparam>
        /// <typeparam name="TResult">The projection type.</typeparam>
        /// <param name="source">The current sequence of values.</param>
        /// <param name="selector">
        /// A projection strategy to invoke per element on a sequence of values.
        /// </param>
        /// <returns>A sequence of transformed values.</returns>
        public static IEnumerable<TResult> Select<TSource, TResult>(
            this IEnumerable<TSource> source,
            IMap<TSource, TResult> selector
            )
        {
            foreach(var x in source)
            {
                yield return selector.Map(x);
            }
        }
    }
}