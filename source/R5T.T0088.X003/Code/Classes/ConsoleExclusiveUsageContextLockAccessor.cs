using System;
using System.Threading;


namespace R5T.T0088.X003
{
    /// <summary>
    /// Allows client code sites outside the library access to the library internal <see cref="ConsoleExclusiveUsageContext.Lock"/> instance.
    /// </summary>
    public static class ConsoleExclusiveUsageContextLockAccessor
    {
        public static SemaphoreSlim Lock
        {
            get
            {
                return ConsoleExclusiveUsageContext.Lock;
            }
        }
    }
}
