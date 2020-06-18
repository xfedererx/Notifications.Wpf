using System;

namespace Notifications.Wpf
{
    public interface INotificationManager
    {
        void Show(object content, string areaIdentifier = "", TimeSpan? expirationTime = null, Action onClick = null, Action onClose = null);
    }
}