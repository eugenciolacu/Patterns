namespace Decorator
{
    abstract public class BaseDecorator : NotificationComponent
    {
        public NotificationComponent _component;

        public BaseDecorator(NotificationComponent component)
        {
            _component = component;
        }

        public override void Send(string msg)
        {
            _component.Send(msg);
        }
    }
}
