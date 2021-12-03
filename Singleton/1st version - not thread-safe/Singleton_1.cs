namespace Singleton._1st_version___not_thread_safe
{
    // Bad code! Do not use!
    public sealed class Singleton_1
    {
        private static Singleton_1 instance = null;

        private Singleton_1()
        {
        }

        public static Singleton_1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton_1();
                }
                return instance;
            }
        }

        public override string ToString()
        {
            return "1st version - not thread-safe singleton";
        }
    }
}
