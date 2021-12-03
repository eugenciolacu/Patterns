namespace Singleton._4th_version___not_quite_as_lazy__but_thread_safe_without_using_locks
{
    // good solution if no need of lazy
    public sealed class Singleton_4
    {
        private static readonly Singleton_4 instance = new Singleton_4();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton_4()
        {
        }

        private Singleton_4()
        {
        }

        public static Singleton_4 Instance
        {
            get
            {
                return instance;
            }
        }

        public override string ToString()
        {
            return "4th version - not quite as lazy, but thread-safe without using locks";
        }
    }
}
