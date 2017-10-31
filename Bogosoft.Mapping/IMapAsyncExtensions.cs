using System.Threading;
using System.Threading.Tasks;

namespace Bogosoft.Mapping
{
    /// <summary>
    /// Extended functionality for the <see cref="IMapAsync{TIn, TOut}"/> contract.
    /// </summary>
    public static class IMapAsyncExtensions
    {
        /// <summary>
        /// Map an object of the input type to an object of a given output type.
        /// </summary>
        /// <typeparam name="TIn">The type of the input object.</typeparam>
        /// <typeparam name="TOut">The type of the output object.</typeparam>
        /// <param name="mapper">The current <see cref="IMapAsync{TIn}"/> implementation.</param>
        /// <param name="input">An object of the input type.</param>
        /// <returns>
        /// An object of the output type.
        /// </returns>
        public static Task<TOut> MapAsync<TIn, TOut>(this IMapAsync<TIn> mapper, TIn input)
        {
            return mapper.MapAsync<TOut>(input, CancellationToken.None);
        }
    }
}