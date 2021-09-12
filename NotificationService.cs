using System;
namespace module_2_homeTask2
{
    public class NotificationService
    {
        private static readonly NotificationService _instance = new NotificationService();
        private SmsNotifier _smsNotifier;
        private EmailNotifier _emailNotifier;

        static NotificationService()
        {
        }

        private NotificationService()
        {
            _smsNotifier = new SmsNotifier();
            _emailNotifier = new EmailNotifier();
        }

        public static NotificationService Instance
        {
            get { return _instance; }
        }

        public void notify(Order order)
        {
            var user = order.User;
            if (user.Email.Length > 0)
            {
                _emailNotifier.Notify(order);
            }

            if (user.Phone.Length > 0)
            {
                _smsNotifier.Notify(order);
            }
        }
    }
}
