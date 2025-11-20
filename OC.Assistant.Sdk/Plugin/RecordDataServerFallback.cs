namespace OC.Assistant.Sdk.Plugin;

internal class RecordDataServerFallback : IRecordDataServer
{
    public void WriteReq(RecordDataTelegram request) => OnWriteRes?.Invoke(request);
    public void ReadReq(RecordDataTelegram request) => OnReadRes?.Invoke(request);
    public event Action<RecordDataTelegram>? OnWriteRes;
    public event Action<RecordDataTelegram>? OnReadRes;
}