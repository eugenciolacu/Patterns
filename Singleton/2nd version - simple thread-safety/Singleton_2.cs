namespace Singleton._2nd_version___simple_thread_safety
{
    // Performance suffers as a lock is acquired every time the instance is requested
    // Do not work in other languages
    public sealed class Singleton_2
    {
        private static Singleton_2 instance = null;
        private static readonly object padlock = new object();

        private Singleton_2()
        {
        }

        public static Singleton_2 Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton_2();
                    }
                    return instance;
                }
            }
        }

        public override string ToString()
        {
            return "2nd version - simple thread-safety";
        }
    }
}
