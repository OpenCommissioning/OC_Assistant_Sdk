using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace OC.Assistant.Sdk;

/// <summary>
/// Provides an extended <see cref="Stopwatch"/>,
/// using a high resolution timer that can be used to wait with milliseconds precision.
/// </summary>
public class StopwatchEx : Stopwatch, IDisposable
{
    private readonly IntPtr _timer;
    private readonly WaitHandle _waitHandle;
    
    /// <summary>
    /// Creates a new instance of the <see cref="StopwatchEx"/> class.
    /// </summary>
    public StopwatchEx()
    {
        _timer = CreateWaitableTimerEx(
            IntPtr.Zero,
            null,
            CREATE_WAITABLE_TIMER_MANUAL_RESET | CREATE_WAITABLE_TIMER_HIGH_RESOLUTION,
            TIMER_ALL_ACCESS
        );
        
        _waitHandle = new AutoResetEvent(false)
        {
            SafeWaitHandle = new SafeWaitHandle(_timer, false)
        };
    }
    
    /// <summary>
    /// Releases all resources used by the current instance of the <see cref="StopwatchEx"/> class.
    /// </summary>
    public void Dispose()
    {
        GC.SuppressFinalize(this);
        _waitHandle.Dispose();
        CloseHandle(_timer);
    }

    /// <summary>
    /// Waits an amount of milliseconds,
    /// calculated by the given timeout minus the already elapsed time and restarts the <see cref="Stopwatch"/>.
    /// </summary>
    /// <param name="millisecondsTimeout">The amount of milliseconds.</param>
    public void WaitUntil(long millisecondsTimeout)
    {
        //dueTime in 100 nanosecond intervals, negative values indicate relative time
        var dueTime = ElapsedTicks - millisecondsTimeout * 10000;
        
        if (dueTime >= 0 || !SetWaitableTimer(_timer, ref dueTime,
                0, IntPtr.Zero, IntPtr.Zero, false))
        {
            Restart();
            return;
        }

        _waitHandle.WaitOne();
        Restart();
    }
    
    private const uint TIMER_ALL_ACCESS = 0x001F0003;
    private const uint CREATE_WAITABLE_TIMER_MANUAL_RESET = 0x00000001;
    private const uint CREATE_WAITABLE_TIMER_HIGH_RESOLUTION = 0x00000002;
    
    /// <summary>
    /// See Win32 API documentation for
    /// <a href="https://learn.microsoft.com/en-us/windows/win32/api/synchapi/nf-synchapi-createwaitabletimerexw">
    /// CreateWaitableTimerEx</a>
    /// </summary>
    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr CreateWaitableTimerEx(
        IntPtr lpTimerAttributes,
        string? lpName,
        uint dwFlags,
        uint dwDesiredAccess);

    /// <summary>
    /// See Win32 API documentation for
    /// <a href="https://learn.microsoft.com/en-us/windows/win32/api/synchapi/nf-synchapi-setwaitabletimer">
    /// SetWaitableTimer</a>
    /// </summary>
    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool SetWaitableTimer(
        IntPtr hTimer,
        [In] ref long pDueTime,
        int lPeriod,
        IntPtr pfnCompletionRoutine,
        IntPtr lpArgToCompletionRoutine,
        bool fResume);
    
    /// <summary>
    /// See Win32 API documentation for
    /// <a href="https://learn.microsoft.com/de-de/windows/win32/api/handleapi/nf-handleapi-closehandle">
    /// CloseHandle</a>
    /// </summary>
    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool CloseHandle(IntPtr hObject);
}