using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadSharp
{
  public interface IReader
  {
    /// <summary>
    /// Reads article content from the given uri.
    /// </summary>
    /// <param name="uri">A uri to extract the content from.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>
    /// An article with extracted content and meta information.
    /// </returns>
    /// <exception cref="ReadException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    /// <exception cref="OperationCanceledException"></exception>
    Task<Article> ReadAsync(Uri uri, CancellationToken cancellationToken);

    /// <summary>
    /// Reads article content from the given uri.
    /// </summary>
    /// <param name="uri">A uri to extract the content from.</param>
    /// <param name="options">The transform options.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>
    /// An article with extracted content and meta information.
    /// </returns>
    /// <exception cref="ReadException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    /// <exception cref="OperationCanceledException"></exception>
    Task<Article> ReadAsync(Uri uri, ReadOptions options, CancellationToken cancellationToken);

    /// <summary>
    /// Reads article content from the given stream.
    /// </summary>
    /// <param name="stream">The stream to extract the content from.</param>
    /// <param name="encoding">The stream encoding.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>
    /// An article with extracted content and meta information.
    /// </returns>
    /// <exception cref="ReadException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    /// <exception cref="OperationCanceledException"></exception>
    Article Read(Stream stream, Encoding encoding, CancellationToken cancellationToken);

    /// <summary>
    /// Reads article content from the given stream.
    /// </summary>
    /// <param name="stream">The stream to extract the content from.</param>
    /// <param name="encoding">The stream encoding.</param>
    /// <param name="options">The transform options.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>
    /// An article with extracted content and meta information.
    /// </returns>
    /// <exception cref="ReadException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    /// <exception cref="OperationCanceledException"></exception>
    Article Read(Stream stream, Encoding encoding, ReadOptions options, CancellationToken cancellationToken);
  }
}
