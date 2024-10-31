using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace NotificationSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EmailButton_Click(object sender, RoutedEventArgs e)
        {
            INotification emailNotification = new EmailNotification();
            NotificationService emailService = new EmailNotificationService(emailNotification);
            emailService.Notify("Email check");
        }

        private void SmsButton_Click(object sender, RoutedEventArgs e)
        {
            INotification smsNotification = new SmsNotification();
            NotificationService smsService = new SmsNotificationService(smsNotification);
            smsService.Notify("SMS check");
        }
        // EmailNotification.cs
        public class EmailNotification : INotification
        {
            public void Send(string message)
            {
                // Логика отправки email уведомления
                MessageBox.Show($"Email отправленное вместе с сообщением: {message}", "Email Уведомление");
            }
        }

        // SmsNotification.cs
        public class SmsNotification : INotification
        {
            public void Send(string message)
            {
                // Логика отправки SMS уведомления
                MessageBox.Show($"SMS отправленное вместе с сообщением: {message}", "SMS Уведомление");
            }
        }
    }
}
