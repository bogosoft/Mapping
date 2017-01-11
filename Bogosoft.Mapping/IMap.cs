namespace Bogosoft.Mapping
{
    /// <summary>
    /// Indicates that an implementation is capable of mapping an object of an input type to an object of an output type.
    /// </summary>
    /// <typeparam name="TIn">The input type.</typeparam>
    public interface IMap<TIn>
    {
        /// <summary>
        /// Map an object of the input type to an object of a given output type.
        /// </summary>
        /// <typeparam name="TOut">The output type.</typeparam>
        /// <param name="input">An object of the input type.</param>
        /// <returns>
        /// An object of the output type.
        /// </returns>
        TOut Map<TOut>(TIn input);
    }

    /// <summary>
    /// Indicates that an implementation is capable of mapping an object of an input type to an object of an output type.
    /// </summary>
    /// <typeparam name="TIn">The input type.</typeparam>
    /// <typeparam name="TOut">The output type.</typeparam>
    public interface IMap<TIn, TOut>
    {
        /// <summary>
        /// Map an object of the input type to an object of the output type.
        /// </summary>
        /// <param name="input">An object of the input type.</param>
        /// <returns>
        /// An object of the output type.
        /// </returns>
        TOut Map(TIn input);
    }
}