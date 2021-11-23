using System;

using R5T.T0088.X003;

using IConsole = R5T.T0088.IConsole;


namespace System
{
    public static class IConsoleOperatorExtensions
    {
        public static ConsoleExclusiveUsageContext GetExclusiveUsageContext(this IConsole _)
        {
            var output = ConsoleExclusiveUsageContext.GetExclusiveUsageContext();
            return output;
        }

        public static void WriteInExclusiveUsageContext(this IConsole _,
            string line)
        {
            using var console = _.GetExclusiveUsageContext();

            console.Write(line);
        }

        /// <summary>
        /// Quality-of-life overload for <see cref="WriteInExclusiveUsageContext(IConsole, string)"/>.
        /// </summary>
        public static void Write(this IConsole _,
            string line)
        {
            _.WriteInExclusiveUsageContext(line);
        }

        public static void WriteLineInExclusiveUsageContext(this IConsole _,
            string line)
        {
            using var console = _.GetExclusiveUsageContext();

            console.WriteLine(line);
        }

        /// <summary>
        /// Quality-of-life overload for <see cref="WriteLineInExclusiveUsageContext(IConsole, string)"/>.
        /// </summary>
        public static void WriteLine(this IConsole _,
            string line)
        {
            _.WriteLineInExclusiveUsageContext(line);
        }
    }
}