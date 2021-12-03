using System;

namespace Singleton._6th_version___using_.NET_4_s_Lazy_type
{
    public sealed class Singleton_6
    {
        private static readonly Lazy<Singleton_6> lazy = new Lazy<Singleton_6>(() => new Singleton_6());

        public static Singleton_6 Instance { get { return lazy.Value; } }

        private Singleton_6()
        {
        }

        public override string ToString()
        {
            return "6rd version - using .NET 4's Lazy<T> type";
        }
    }
}
