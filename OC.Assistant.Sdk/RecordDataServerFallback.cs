namespace OC.Assistant.Sdk;

internal class RecordDataServerFallback : IRecordDataServer
{
    public void WriteReq(RecordDataRequest request)
        => OnWriteRes?.Invoke(new RecordDataResponse(request.InvokeId, 0, 0));
    
    public void ReadReq(RecordDataRequest request)
        => OnReadRes?.Invoke(new RecordDataResponse(request.InvokeId, 0, 0));
    
    public event Action<RecordDataResponse>? OnWriteRes;
    public event Action<RecordDataResponse>? OnReadRes;
}