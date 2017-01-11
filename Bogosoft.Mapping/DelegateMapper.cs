using System;

namespace Bogosoft.Mapping
{
    /// <summary>
    /// An implementation of <see cref="IMap{TIn, TOut}"/> that relies on an internal
    /// delegate to map an object of one type to an object of another.
    /// </summary>
    /// <typeparam name="TIn">The type of the input object.</typeparam>
    /// <typeparam name="TOut">The type of the output object.</typeparam>
    public sealed class DelegateMapper<TIn, TOut> : IMap<TIn, TOut>
    {
        private Func<TIn, TOut> @delegate;

        /// <summary>
        /// Create a new mapping strategy from a delegate.
        /// </summary>
        /// <param name="delegate">A delegate.</param>
        public DelegateMapper(Func<TIn, TOut> @delegate)
        {
            this.@delegate = @delegate;
        }

        /// <summary>
        /// Map an object of the input type to an object of the output type.
        /// </summary>
        /// <param name="input">An object of the input type.</param>
        /// <returns>
        /// An object of the output type.
        /// </returns>
        public TOut Map(TIn input)
        {
            return @delegate.Invoke(input);
        }
    }
}