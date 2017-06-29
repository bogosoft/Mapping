using System.Threading;
using System.Threading.Tasks;

namespace Bogosoft.Mapping
{
    /// <summary>
    /// Map an object of one type to an object of another.
    /// </summary>
    /// <typeparam name="TIn">The type of the input object.</typeparam>
    /// <typeparam name="TOut">The type of the output object.</typeparam>
    /// <param name="input">An object of the input type.</param>
    /// <param name="token">A <see cref="CancellationToken"/> object.</param>
    /// <returns>
    /// An object of the output type.
    /// </returns>
    public delegate Task<TOut> AsyncMapper<TIn, TOut>(TIn input, CancellationToken token);
}