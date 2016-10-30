using System;
using System.Threading.Tasks;

namespace Bogosoft.Mapping
{
    /// <summary>A synchronous mapping strategy that wraps an anonymous function.</summary>
    /// <typeparam name="TIn">The type of the input object.</typeparam>
    /// <typeparam name="TOut">The type of the output object.</typeparam>
    public sealed class LambdaMapper<TIn, TOut> : IMap<TIn, TOut>
    {
        private Func<TIn, TOut> lambda;

        /// <summary>Create a new mapping strategy from an anonymous function.</summary>
        /// <param name="lambda">An anonymous function.</param>
        public LambdaMapper(Func<TIn, TOut> lambda)
        {
            this.lambda = lambda;
        }

        /// <summary>Map an input object to an output object.</summary>
        /// <param name="input">An object of the input type.</param>
        /// <returns>An object of the output type.</returns>
        public TOut Map(TIn input)
        {
            return this.lambda.Invoke(input);
        }
    }

    /// <summary>A mapping strategy that wraps an anonymous function.</summary>
    /// <typeparam name="TIn">The type of the input object.</typeparam>
    /// <typeparam name="TOut">The type of the output object.</typeparam>
    public sealed class LambdaMapperAsync<TIn, TOut> : IMapAsync<TIn, TOut>
    {
        private Func<TIn, Task<TOut>> lambda;

        /// <summary>Create a new mapping strategy from an anonymous function.</summary>
        /// <param name="lambda">An anonymous function.</param>
        public LambdaMapperAsync(Func<TIn, Task<TOut>> lambda)
        {
            this.lambda = lambda;
        }

        /// <summary>Map an input object to an output object.</summary>
        /// <param name="input">An object of the input type.</param>
        /// <returns>A <see cref="Task"/> that will eventually return an object of the output type.</returns>
        public async Task<TOut> MapAsync(TIn input)
        {
            return await this.lambda.Invoke(input);
        }
    }
}