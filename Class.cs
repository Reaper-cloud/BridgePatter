using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NotificationSystem
{
    // EmailNotificationService
    public class EmailNotificationService : NotificationService
    {
        public EmailNotificationService(INotification notification) : base(notification) { }

        public override void Notify(string message)
        {
            _notification.Send(message);
        }
    }

    // SmsNotificationService
    public class SmsNotificationService : NotificationService
    {
        public SmsNotificationService(INotification notification) : base(notification) { }

        public override void Notify(string message)
        {
            _notification.Send(message);
        }
    }
    public abstract class NotificationService
    {
        protected INotification _notification;

        protected NotificationService(INotification notification)
        {
            _notification = notification;
        }

        public abstract void Notify(string message);
    }
    
}
