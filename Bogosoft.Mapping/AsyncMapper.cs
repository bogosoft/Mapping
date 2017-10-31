using System.Threading;
using System.Threading.Tasks;

namespace Bogosoft.Mapping
{
    /// <summary>
    /// Represents a template for a method capable of asynchronously mapping objects
    /// of a specified input type to objects of a specified output type.
    /// </summary>
    /// <typeparam name="TIn">The type of the input object.</typeparam>
    /// <typeparam name="TOut">The type of the output object.</typeparam>
    /// <param name="input">An object of the input type.</param>
    /// <param name="token">A <see cref="CancellationToken"/> object.</param>
    /// <returns>
    /// An object of the output type.
    /// </returns>
    public delegate Task<TOut> AsyncMapper<in TIn, TOut>(TIn input, CancellationToken token);
}