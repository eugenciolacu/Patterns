using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SmsDecorator : BaseDecorator
    {
        public SmsDecorator(NotificationComponent component) : base(component)
        {
        }

        public override void Send(string msg)
        {
            base.Send(msg);
            Console.WriteLine("SMS notification");
            Console.WriteLine(msg + "\n\n");
        }
    }
}
