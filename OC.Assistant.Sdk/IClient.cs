namespace OC.Assistant.Sdk;

/// <summary>
/// Client interface for cyclic I/O exchange.
/// </summary>
public interface IClient
{
    /// <summary>
    /// Buffer to store data to write.
    /// </summary>
    byte[] WriteBuffer { get; }

    /// <summary>
    /// Buffer with read data.
    /// </summary>
    byte[] ReadBuffer { get; }

    /// <summary>
    /// Disconnects the client.
    /// </summary>
    void Disconnect();

    /// <summary>
    /// Sets the write index to the given symbol.
    /// </summary>
    /// <param name="symbolName">The symbol name.</param>
    void SetWriteIndex(string symbolName);

    /// <summary>
    /// Sets the read index to the given symbol.
    /// </summary>
    /// <param name="symbolName">The symbol name.</param>
    void SetReadIndex(string symbolName);

    /// <summary>
    /// Writes data from the <see cref="WriteBuffer"/> to the server.
    /// </summary>
    void Write();

    /// <summary>
    /// Writes data from a custom source to the server.
    /// </summary>
    /// <param name="source">The source data.</param>
    /// <param name="sourceOffset">The source offset.</param>
    /// <param name="destinationOffset">The server relative offset.</param>
    /// <param name="length">Data length.</param>
    void Write(byte[] source, int sourceOffset, int destinationOffset, int length);

    /// <summary>
    /// Reads data from the server and copies to the <see cref="ReadBuffer"/>.
    /// </summary>
    void Read();

    /// <summary>
    /// Reads data from the server read- and write buffer.
    /// </summary>
    void ReadAll();
}