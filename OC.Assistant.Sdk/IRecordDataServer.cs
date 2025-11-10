namespace OC.Assistant.Sdk;

/// <summary>
/// Represents an interface for a record data server.
/// </summary>
public interface IRecordDataServer
{
    /// <summary>
    /// Sends a write-request.
    /// </summary>
    /// <param name="request">The <see cref="RecordDataRequest"/> containing the request data.</param>
    public void WriteReq(RecordDataRequest request);
    
    /// <summary>
    /// Sends a read-request.
    /// </summary>
    /// <param name="request">The <see cref="RecordDataRequest"/> containing the request data.</param>
    public void ReadReq(RecordDataRequest request);
    
    /// <summary>
    /// Is raised whenever a write operation is completed,
    /// providing a <see cref="RecordDataResponse"/> as its argument.
    /// </summary>
    public event Action<RecordDataResponse>? OnWriteRes;
    
    /// <summary>
    /// Is raised whenever a read operation is completed,
    /// providing a <see cref="RecordDataResponse"/> as its argument.
    /// </summary>
    public event Action<RecordDataResponse>? OnReadRes;
}