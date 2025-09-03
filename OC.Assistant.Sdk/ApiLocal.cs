using TwinCAT.Ads;

namespace OC.Assistant.Sdk;

/// <summary>
/// Represents the local implementation of the Assistant API.
/// </summary>
public class ApiLocal
{
    private static readonly Lazy<ApiLocal> LazyInstance = new(() => new ApiLocal());
    
    private AmsNetId _netId = AmsNetId.Local;
    private int _port = 851;
    private double _timeScaling = 1.0;
    private CommunicationType _communicationType = CommunicationType.TcpIp;
    
    /// <summary>
    /// Singleton interface for the <see cref="ApiLocal"/>.
    /// </summary>
    public static ApiLocal Interface => LazyInstance.Value;

    /// <summary>
    /// The TwinCAT <see cref="AmsNetId"/>.
    /// </summary>
    public AmsNetId NetId
    {
        get => _netId;
        internal set
        {
            _netId = value;
            NetIdChanged?.Invoke(value);
        }
    }
    
    /// <summary>
    /// Is raised when the TwinCAT <see cref="AmsNetId"/> has been changed.
    /// </summary>
    public event Action<AmsNetId>? NetIdChanged;

    /// <summary>
    /// The TwinCAT PLC Port.
    /// </summary>
    public int Port
    {
        get => _port;
        internal set
        {
            _port = value;
            PortChanged?.Invoke(value);
        }
    }
    
    /// <summary>
    /// Is raised when the TwinCAT PLC Port has been changed.
    /// </summary>
    public event Action<int>? PortChanged;

    /// <summary>
    /// The project TimeScaling value.
    /// </summary>
    public double TimeScaling
    {
        get => _timeScaling;
        internal set
        {
            _timeScaling = value;
            TimeScalingChanged?.Invoke(value);
        }
    }
    
    /// <summary>
    /// Is raised when the TimeScaling value has been changed.
    /// </summary>
    public event Action<double>? TimeScalingChanged;
    
    /// <summary>
    /// The CommunicationType value.
    /// </summary>
    public CommunicationType CommunicationType
    {
        get => _communicationType;
        internal set
        {
            _communicationType = value;
            CommunicationTypeChanged?.Invoke(value);
        }
    }
    
    /// <summary>
    /// Is raised when the CommunicationType value has been changed.
    /// </summary>
    public event Action<CommunicationType>? CommunicationTypeChanged;
    
    /// <summary>
    /// Triggers the <see cref="TcRestarted"/> event.
    /// </summary>
    internal void TriggerTcRestart()
    {
        TcRestarted?.Invoke();
    }
    
    /// <summary>
    /// Is raised when a project is connected and TwinCAT has been restarted.
    /// </summary>
    public event Action? TcRestarted;
}