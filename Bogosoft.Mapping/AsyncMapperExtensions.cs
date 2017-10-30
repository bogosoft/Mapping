using System.Threading;
using System.Threading.Tasks;

namespace Bogosoft.Mapping
{
    /// <summary>
    /// Extended functionality for the <see cref="AsyncMapper{TIn, TOut}"/> contract.
    /// </summary>
    public static class AsyncMapperExtensions
    {
        /// <summary>
        /// Map an object of one type to an object of another.
        /// </summary>
        /// <typeparam name="TIn">The type of the input object.</typeparam>
        /// <typeparam name="TOut">The type of the output object.</typeparam>
        /// <param name="mapper">The current <see cref="AsyncMapper{TIn, TOut}"/> implementation.</param>
        /// <param name="input">An object of the input type.</param>
        /// <returns>
        /// An object of the output type.
        /// </returns>
        public static Task<TOut> MapAsync<TIn, TOut>(this AsyncMapper<TIn, TOut> mapper, TIn input)
        {
            return mapper.Invoke(input, CancellationToken.None);
        }

        /// <summary>
        /// Map an object of one type to an object of another.
        /// </summary>
        /// <typeparam name="TIn">The type of the input object.</typeparam>
        /// <typeparam name="TOut">The type of the output object.</typeparam>
        /// <param name="mapper">The current <see cref="AsyncMapper{TIn, TOut}"/> implementation.</param>
        /// <param name="input">An object of the input type.</param>
        /// <param name="token">A <see cref="CancellationToken"/> object.</param>
        /// <returns>
        /// An object of the output type.
        /// </returns>
        public static Task<TOut> MapAsync<TIn, TOut>(
            this AsyncMapper<TIn, TOut> mapper,
            TIn input,
            CancellationToken token
            )
        {
            return mapper.Invoke(input, token);
        }
    }
}