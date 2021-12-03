namespace Singleton._3rd_version___attempted_thread_safety_using_double_check_locking
{
    // Bad code! Do not use!
    // Do not work in other languages
    public sealed class Singleton_3
    {
        private static Singleton_3 instance = null;
        private static readonly object padlock = new object();

        private Singleton_3()
        {
        }

        public static Singleton_3 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton_3();
                        }
                    }
                }
                return instance;
            }
        }

        public override string ToString()
        {
            return "3rd version - attempted thread-safety using double-check locking";
        }
    }
}
