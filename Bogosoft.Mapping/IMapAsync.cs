using System.Threading;
using System.Threading.Tasks;

namespace Bogosoft.Mapping
{
    /// <summary>
    /// Indicates that an implementation is capable of mapping an object of an input type to an object of an output type.
    /// </summary>
    /// <typeparam name="TIn">The input type.</typeparam>
    public interface IMapAsync<TIn>
    {
        /// <summary>
        /// Map an object of the input type to an object of a given output type.
        /// </summary>
        /// <typeparam name="TOut">The output type.</typeparam>
        /// <param name="input">An object of the input type.</param>
        /// <param name="token">A <see cref="CancellationToken"/> object.</param>
        /// <returns>
        /// An object of the output type.
        /// </returns>
        Task<TOut> MapAsync<TOut>(TIn input, CancellationToken token);
    }

    /// <summary>
    /// Indicates that an implementation is capable of mapping an object of an input type to an object of an output type.
    /// </summary>
    /// <typeparam name="TIn">The input type.</typeparam>
    /// <typeparam name="TOut">The output type.</typeparam>
    public interface IMapAsync<TIn, TOut>
    {
        /// <summary>
        /// Map an object of the input type to an object of the output type.
        /// </summary>
        /// <param name="input">An object of the input type.</param>
        /// <param name="token">A <see cref="CancellationToken"/> object.</param>
        /// <returns>
        /// An object of the output type.
        /// </returns>
        Task<TOut> MapAsync(TIn input, CancellationToken token);
    }
}