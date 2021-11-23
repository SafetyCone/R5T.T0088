using System;
using System.Threading;


namespace R5T.T0088.X003
{
    public sealed class ConsoleExclusiveUsageContext : ConsoleBase, IDisposable
    {
        #region Static

        /// <summary>
        /// Made internal to prevent pollution of the public intellisense view of <see cref="ConsoleExclusiveUsageContext"/>.
        /// Can be accessed using <see cref="ConsoleExclusiveUsageContextLockAccessor"/>.
        /// </summary>
        internal static SemaphoreSlim Lock { get; } = new SemaphoreSlim(1, 1);


        public static ConsoleExclusiveUsageContext GetExclusiveUsageContext()
        {
            ConsoleExclusiveUsageContext.Lock.Wait();

            var output = new ConsoleExclusiveUsageContext(ConsoleExclusiveUsageContext.Lock);
            return output;
        }

        #endregion


        #region IDisposable

        private bool zDisposed = false;


        public void Dispose()
        {
            if(this.zDisposed)
            {
                return;
            }

            this.Semaphore.Release();

            this.zDisposed = true;
        }

        #endregion


        private SemaphoreSlim Semaphore { get; }


        public ConsoleExclusiveUsageContext(SemaphoreSlim semaphore)
        {
            this.Semaphore = semaphore;
        }
    }
}
