namespace OC.Assistant.Sdk;

public interface IRecordData
{
    public void WriteReq(uint invokeId, uint indexGroup, uint indexOffset, uint cbLength, byte[] data);
    public void ReadReq(uint invokeId, uint indexGroup, uint indexOffset, uint cbLength);
    public event Action<RecordDataResponse>? OnAdsReadCon;
    public event Action<RecordDataResponse>? OnAdsWriteCon;
}