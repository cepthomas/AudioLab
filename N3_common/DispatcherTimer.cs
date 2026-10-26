using System;


// TODO1 from wpf - use mm timer

namespace N3_common;

public class DispatcherTimer
{
    private DispatcherPriority _priority;

    private TimeSpan _interval;

    private object _tag;

    private bool _isEnabled;

    internal int _dueTimeInTicks;

    public bool IsEnabled
    {
        get
        {
            return _isEnabled;
        }
        set
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

    public TimeSpan Interval
    {
        get
        {
            return _interval;
        }
        set
        {
            _interval = value;
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
    public DispatcherTimer() : this(DispatcherPriority.Background)
    {
    }

    public DispatcherTimer(DispatcherPriority priority)
    {
    }

    //     Starts the System.Windows.Threading.DispatcherTimer.
    public void Start()
    {
        if (!_isEnabled)
        {
            _isEnabled = true;
            Restart();
        }
    }

    public void Stop()
    {
        if (_isEnabled)
        {
            _isEnabled = false;
        }
    }

    private void Restart()
    {
    }

    internal void Promote()
    {
    }

    private object FireTick()
    {
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
