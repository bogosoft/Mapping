using System.Threading.Tasks;

namespace Bogosoft.Mapping
{
    /// <summary>Provides a means of mapping an object of one type to another.</summary>
    /// <typeparam name="TIn">The input type.</typeparam>
    public interface IMapAsync<TIn>
    {
        /// <summary>Map an object of the input type to an object of the output type.</summary>
        /// <typeparam name="TOut">The output type.</typeparam>
        /// <param name="input">An object of the input type.</param>
        /// <returns>An object of the output type.</returns>
        Task<TOut> MapAsync<TOut>(TIn input);
    }

    /// <summary>Provides a means of mapping an object of one type to another.</summary>
    /// <typeparam name="TIn">The input type.</typeparam>
    /// <typeparam name="TOut">The output type.</typeparam>
    public interface IMapAsync<TIn, TOut>
    {
        /// <summary>Map an object of the input type to an object of the output type.</summary>
        /// <param name="input"></param>
        /// <returns>An object of the output type.</returns>
        Task<TOut> MapAsync(TIn input);
    }
}