using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator is a structural design pattern that lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors.");
            Console.WriteLine();

            NotificationComponent component = new EmailNotificationConcreteComponent();
            //component.Send("email notification");

            BaseDecorator smsDecorator = new SmsDecorator(component);
            //smsDecorator.Send("email and sms notification");

            BaseDecorator facebookDecorator = new FacebookDecorator(smsDecorator);
            //facebookDecorator.Send("email, sms and facebook notification");

            BaseDecorator slackDecorator = new SlackDecorator(facebookDecorator);
            slackDecorator.Send("email, sms, facebook and slack notification");
        }
    }
}
