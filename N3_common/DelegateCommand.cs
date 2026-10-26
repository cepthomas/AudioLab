using System;
using System.Windows.Input;

// TODO1 from wpf

namespace N3_common;

public class DelegateCommand : ICommand
{
    private readonly Action action;

    public event EventHandler CanExecuteChanged;
    public bool IsEnabled { get; set; }

    public DelegateCommand(Action action)
    {
        this.action = action;
        IsEnabled = true;
    }

    public void Execute(object parameter)
    {
        action();
    }

    public bool CanExecute(object parameter)
    {
        return IsEnabled;
    }

    protected virtual void OnCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
