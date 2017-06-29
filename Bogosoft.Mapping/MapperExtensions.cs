namespace Bogosoft.Mapping
{
    /// <summary>
    /// Extended functionality for the <see cref="Mapper{TIn, TOut}"/> contract.
    /// </summary>
    public static class MapperExtensions
    {
        /// <summary>
        /// Map an object of one type to an object of another.
        /// </summary>
        /// <typeparam name="TIn">The type of the input object.</typeparam>
        /// <typeparam name="TOut">The type of the output object.</typeparam>
        /// <param name="mapper">The current <see cref="Mapper{TIn, TOut}"/> implementation.</param>
        /// <param name="input">An object of the input type.</param>
        /// <returns>
        /// An object of the output type.
        /// </returns>
        public static TOut Map<TIn, TOut>(this Mapper<TIn, TOut> mapper, TIn input)
        {
            return mapper.Invoke(input);
        }
    }
}