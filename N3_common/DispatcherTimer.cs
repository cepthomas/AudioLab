using System;


// TODO1 from wpf

namespace N3_common;

// internal class DispatcherTimer
// {
//     private object render;

//     public DispatcherTimer(object render)
//     {
//         this.render = render;
//     }

//     public TimeSpan Interval { get; internal set; }

//     public Action<object, object> Tick { get; internal set; }

//     internal void Start()
//     {
//         throw new NotImplementedException();
//     }

//     internal void Stop()
//     {
//         throw new NotImplementedException();
//     }
// }




// using MS.Internal.WindowsBase;
// namespace System.Windows.Threading;

//     A timer that is integrated into the System.Windows.Threading.Dispatcher queue
//     which is processed at a specified interval of time and at a specified priority.
public class DispatcherTimer
{
    private readonly object _instanceLock = new object();

    //private Dispatcher _dispatcher;

    private DispatcherPriority _priority;

    private TimeSpan _interval;

    private object _tag;

    //private DispatcherOperation _operation;

    private bool _isEnabled;

    internal int _dueTimeInTicks;




    //public Dispatcher Dispatcher => _dispatcher;


    public bool IsEnabled
    {
        get
        {
            return _isEnabled;
        }
        set
        {
            lock (_instanceLock)
            {
                if (!value && _isEnabled)
                {
                    Stop();
                }
                else if (value && !_isEnabled)
                {
                    Start();
                }
            }
        }
    }


    //     Gets or sets the period of time between timer ticks.

    public TimeSpan Interval
    {
        get
        {
            return _interval;
        }
        set
        {
            bool flag = false;
            if (value.TotalMilliseconds < 0.0)
            {
                //throw new ArgumentOutOfRangeException("value", SR.TimeSpanPeriodOutOfRange_TooSmall);
            }

            if (value.TotalMilliseconds > 2147483647.0)
            {
                //throw new ArgumentOutOfRangeException("value", SR.TimeSpanPeriodOutOfRange_TooLarge);
            }

            lock (_instanceLock)
            {
                _interval = value;
                if (_isEnabled)
                {
                    _dueTimeInTicks = Environment.TickCount + (int)_interval.TotalMilliseconds;
                    flag = true;
                }
            }

            if (flag)
            {
                //_dispatcher.UpdateWin32Timer();
            }
        }
    }

    //     Gets or sets a user-defined data object.
    public object Tag
    {
        get
        {
            return _tag;
        }
        set
        {
            _tag = value;
        }
    }

    //     Occurs when the timer interval has elapsed.
    public event EventHandler Tick;

    //     Initializes a new instance of the System.Windows.Threading.DispatcherTimer class.
    public DispatcherTimer()
        : this(DispatcherPriority.Background)
    {
    }

    //     Initializes a new instance of the System.Windows.Threading.DispatcherTimer class
    //     which processes timer events at the specified priority.
    public DispatcherTimer(DispatcherPriority priority)
    {
        //Initialize(Dispatcher.CurrentDispatcher, priority, TimeSpan.FromMilliseconds(0L, 0L));
    }

    //public DispatcherTimer(DispatcherPriority priority, Dispatcher dispatcher)
    //{
    //    ArgumentNullException.ThrowIfNull(dispatcher, "dispatcher");
    //    Initialize(dispatcher, priority, TimeSpan.FromMilliseconds(0L, 0L));
    //}

    //     Initializes a new instance of the System.Windows.Threading.DispatcherTimer class
    //     which uses the specified time interval, priority, event handler, and System.Windows.Threading.Dispatcher.
    //public DispatcherTimer(TimeSpan interval, DispatcherPriority priority, EventHandler callback, Dispatcher dispatcher)
    //{
    //    ArgumentNullException.ThrowIfNull(callback, "callback");
    //    ArgumentNullException.ThrowIfNull(dispatcher, "dispatcher");
    //    if (interval.TotalMilliseconds < 0.0)
    //    {
    //        throw new ArgumentOutOfRangeException("interval", SR.TimeSpanPeriodOutOfRange_TooSmall);
    //    }

    //    if (interval.TotalMilliseconds > 2147483647.0)
    //    {
    //        throw new ArgumentOutOfRangeException("interval", SR.TimeSpanPeriodOutOfRange_TooLarge);
    //    }

    //    Initialize(dispatcher, priority, interval);
    //    Tick += callback;
    //    Start();
    //}

    //     Starts the System.Windows.Threading.DispatcherTimer.
    public void Start()
    {
        lock (_instanceLock)
        {
            if (!_isEnabled)
            {
                _isEnabled = true;
                Restart();
            }
        }
    }

    //     Stops the System.Windows.Threading.DispatcherTimer.
    public void Stop()
    {
        bool flag = false;
        lock (_instanceLock)
        {
            if (_isEnabled)
            {
                _isEnabled = false;
                //flag = true;
                //if (_operation != null)
                //{
                //    _operation.Abort();
                //    _operation = null;
                //}
            }
        }

        if (flag)
        {
            //_dispatcher.RemoveTimer(this);
        }
    }

    //private void Initialize(Dispatcher dispatcher, DispatcherPriority priority, TimeSpan interval)
    //{
    //    Dispatcher.ValidatePriority(priority, "priority");
    //    if (priority == DispatcherPriority.Inactive)
    //    {
    //        throw new ArgumentException(SR.InvalidPriority, "priority");
    //    }

    //    _dispatcher = dispatcher;
    //    _priority = priority;
    //    _interval = interval;
    //}

    private void Restart()
    {
        lock (_instanceLock)
        {
            //if (_operation == null)
            //{
            //    _operation = _dispatcher.BeginInvoke(DispatcherPriority.Inactive, (DispatcherOperationCallback)((object state) => ((DispatcherTimer)state).FireTick()), this);
            //    _dueTimeInTicks = Environment.TickCount + (int)_interval.TotalMilliseconds;
            //    if (_interval.TotalMilliseconds == 0.0 && _dispatcher.CheckAccess())
            //    {
            //        Promote();
            //    }
            //    else
            //    {
            //        _dispatcher.AddTimer(this);
            //    }
            //}
        }
    }

    internal void Promote()
    {
        lock (_instanceLock)
        {
            //if (_operation != null)
            //{
            //    _operation.Priority = _priority;
            //}
        }
    }

    private object FireTick()
    {
        //_operation = null;
        if (this.Tick != null)
        {
            this.Tick(this, EventArgs.Empty);
        }

        if (_isEnabled)
        {
            Restart();
        }

        return null;
    }
}


//
// Summary:
//     Describes the priorities at which operations can be invoked by way of the System.Windows.Threading.Dispatcher.
public enum DispatcherPriority
{
    Invalid = -1,
    Inactive,
    SystemIdle,
    ApplicationIdle,
    ContextIdle,
    Background,
    Input,
    Loaded,
    Render,
    DataBind,
    Normal,
    Send
}
