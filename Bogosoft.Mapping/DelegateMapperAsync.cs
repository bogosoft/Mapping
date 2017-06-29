using System;
using System.Threading;
using System.Threading.Tasks;

namespace Bogosoft.Mapping
{
    /// <summary>
    /// An implementation of <see cref="IMapAsync{TIn, TOut}"/> that relies on a
    /// given delegate to map an object of one type to an object of another.
    /// </summary>
    /// <typeparam name="TIn">The type of the input object.</typeparam>
    /// <typeparam name="TOut">The type of the output object.</typeparam>
    public sealed class DelegateMapperAsync<TIn, TOut> : IMapAsync<TIn, TOut>
    {
        private AsyncMapper<TIn, TOut> @delegate;

        /// <summary>Create a new mapping strategy from a delegate.</summary>
        /// <param name="delegate">A delegate.</param>
        public DelegateMapperAsync(Func<TIn, Task<TOut>> @delegate)
        {
            this.@delegate = (input, token) =>
            {
                token.ThrowIfCancellationRequested();

                return @delegate.Invoke(input);
            };
        }

        /// <summary>Create a new mapping strategy from a delegate.</summary>
        /// <param name="delegate">A delegate.</param>
        public DelegateMapperAsync(AsyncMapper<TIn, TOut> @delegate)
        {
            this.@delegate = @delegate;
        }

        /// <summary>Map an input object to an output object.</summary>
        /// <param name="input">An object of the input type.</param>
        /// <param name="token">A <see cref="CancellationToken"/> object.</param>
        /// <returns>
        /// An object of the output type.
        /// </returns>
        public Task<TOut> MapAsync(TIn input, CancellationToken token)
        {
            return @delegate.Invoke(input, token);
        }
    }
}