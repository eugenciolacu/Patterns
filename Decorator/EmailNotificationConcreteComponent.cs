using System;

namespace Decorator
{
    public class EmailNotificationConcreteComponent : NotificationComponent
    {
        public override void Send(string msg)
        {
            Console.WriteLine("Email notification");
            Console.WriteLine(msg + "\n\n");
        }
    }
}
