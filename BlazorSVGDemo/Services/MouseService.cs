using Microsoft.AspNetCore.Components.Web;

namespace BlazorSVGDemo.Services;

public interface IMouseService
{
    event EventHandler<MouseEventArgs>? OnMove;

    event EventHandler<MouseEventArgs>? OnUp;
#nullable enable
#nullable disable
}

// use MouseService to fire events
public class MouseService : IMouseService
{
    public event EventHandler<MouseEventArgs>? OnMove;

    public event EventHandler<MouseEventArgs>? OnUp;
#nullable enable
#nullable disable

    public void FireMove(object obj, MouseEventArgs evt)
    {
        OnMove?.Invoke(obj, evt);
    }

    public void FireUp(object obj, MouseEventArgs evt)
    {
        OnUp?.Invoke(obj, evt);
    }
}