namespace Bogosoft.Mapping
{
    /// <summary>Provides a means of mapping an object of one type to another.</summary>
    /// <typeparam name="TIn">The input type.</typeparam>
    public interface IMap<TIn>
    {
        /// <summary>Synchronously map an object of the input type to an object of the output type.</summary>
        /// <typeparam name="TOut">The output type.</typeparam>
        /// <param name="input">An object of the input type.</param>
        /// <returns>An object of the output type.</returns>
        TOut Map<TOut>(TIn input);
    }

    /// <summary>Provides a means of mapping an object of one type to another.</summary>
    /// <typeparam name="TIn">The input type.</typeparam>
    /// <typeparam name="TOut">The output type.</typeparam>
    public interface IMap<TIn, TOut>
    {
        /// <summary>Synchronously map an object of the input type to an object of the output type.</summary>
        /// <param name="input">An object of the input type.</param>
        /// <returns>An object of the output type.</returns>
        TOut Map(TIn input);
    }
}