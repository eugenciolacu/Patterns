using System;

namespace Decorator
{
    public class FacebookDecorator : BaseDecorator
    {
        public FacebookDecorator(NotificationComponent component) : base(component)
        {
        }

        public override void Send(string msg)
        {
            base.Send(msg);
            Console.WriteLine("Facebook notification");
            Console.WriteLine(msg + "\n\n");
        }
    }
}
