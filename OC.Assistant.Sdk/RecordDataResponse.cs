namespace OC.Assistant.Sdk;

/// <summary>
/// Represents a recordData response telegram.
/// </summary>
/// <param name="invokeId">The invoke-ID of the telegram.</param>
/// <param name="result">The result code.</param>
/// <param name="length">The data length in bytes.</param>
/// <param name="data">The data. Can be null depending on write- or read-request.</param>
public struct RecordDataResponse(uint invokeId, int result, uint length, byte[]? data)
{
    public readonly uint InvokeId = invokeId;
    public readonly int Result = result;
    public readonly uint CbLength = length;
    public readonly byte[]? Data = data;
}