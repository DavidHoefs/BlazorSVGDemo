using Microsoft.AspNetCore.Components.Web;

namespace BlazorSVGDemo.Services
{
    public interface IMouseService
    {
#nullable enable

        event EventHandler<MouseEventArgs>? OnMove;

        event EventHandler<MouseEventArgs>? OnUp;

#nullable disable
    }

    // use MouseService to fire events
    public class MouseService : IMouseService
    {
#nullable enable

        public event EventHandler<MouseEventArgs>? OnMove;

        public event EventHandler<MouseEventArgs>? OnUp;

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
}