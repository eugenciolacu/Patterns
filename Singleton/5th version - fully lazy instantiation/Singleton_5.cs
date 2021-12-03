namespace Singleton._5th_version___fully_lazy_instantiation
{
    public sealed class Singleton_5
    {
        private Singleton_5()
        {
        }

        public static Singleton_5 Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly Singleton_5 instance = new Singleton_5();
        }

        public override string ToString()
        {
            return "5th version - fully lazy instantiation";
        }
    }
}
