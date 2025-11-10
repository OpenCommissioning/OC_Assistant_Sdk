namespace OC.Assistant.Sdk;

/// <summary>
/// Represents a record data request structure.
/// </summary>
public struct RecordDataRequest(uint invokeId, uint indexGroup, uint indexOffset, uint cbLength, byte[]? data = null)
{
    /// <summary/>
    public readonly uint InvokeId = invokeId; 
    /// <summary/>   
    public readonly uint IndexGroup = indexGroup;
    /// <summary/> 
    public readonly uint IndexOffset = indexOffset;
    /// <summary/>
    public readonly uint CbLength = cbLength;
    /// <summary/>
    public readonly byte[]? Data = data;
}