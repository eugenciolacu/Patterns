using System;

namespace Decorator
{
    public class SlackDecorator : BaseDecorator
    {
        public SlackDecorator(NotificationComponent component) : base(component)
        {
        }

        public override void Send(string msg)
        {
            base.Send(msg);
            Console.WriteLine("Slack notification");
            Console.WriteLine(msg + "\n\n");
        }
    }
}
