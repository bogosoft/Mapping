using System.Threading;
using System.Threading.Tasks;

namespace Bogosoft.Mapping
{
    /// <summary>
    /// Extended functionality for the <see cref="IMapAsync{TIn}"/> and <see cref="IMapAsync{TIn, TOut}"/> contracts.
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

        /// <summary>
        /// Map an object of the input type to an object a given output type. Calling this method is equivalent to calling
        /// <see cref="IMapAsync{TIn}.MapAsync{TOut}(TIn, CancellationToken)"/> with a value of
        /// <see cref="CancellationToken.None"/>.
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

        /// <summary>
        /// Map an object of the input type to an object of the output type. Calling this method is equivalent to calling
        /// <see cref="IMapAsync{TIn, TOut}.MapAsync(TIn, CancellationToken)"/> with a value of
        /// <see cref="CancellationToken.None"/>.
        /// </summary>
        /// <typeparam name="TIn">The type of the input object.</typeparam>
        /// <typeparam name="TOut">The type of the output object.</typeparam>
        /// <param name="mapper">The current <see cref="IMapAsync{TIn}"/> implementation.</param>
        /// <param name="input">An object of the input type.</param>
        /// <returns>
        /// An object of the output type.
        /// </returns>
        public static Task<TOut> MapAsync<TIn, TOut>(this IMapAsync<TIn, TOut> mapper, TIn input)
        {
            return mapper.MapAsync(input, CancellationToken.None);
        }
    }
}