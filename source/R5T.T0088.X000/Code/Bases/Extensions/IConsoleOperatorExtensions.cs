using System;
using System.Runtime.InteropServices;

using R5T.T0087;
using R5T.T0088;

using IConsole = R5T.T0087.IConsole;


namespace System
{
    public static class IConsoleOperatorExtensions
    {
        public static IConsole GetOperatingSystemSpecificConsole(this IConsoleOperator _,
            bool useStandardError = false)
        {
            IConsole output = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? new WindowsConsole(useStandardError)
                : new AnsiConsole(useStandardError)
                ;

            return output;
        }
    }
}
