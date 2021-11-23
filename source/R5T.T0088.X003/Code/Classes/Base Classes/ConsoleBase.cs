using System;

using SystemConsole = System.Console;


namespace R5T.T0088.X003
{
    /// <summary>
    /// Basic implementation with no atomicity or thread-safety feautures.
    /// Useful as a component for creating implementations with those features.
    /// </summary>
    public abstract class ConsoleBase : IConsole
    {
        public void SetBackgroundColor(ConsoleColor color)
        {
            SystemConsole.BackgroundColor = color;
        }

        public void SetForegroundColor(ConsoleColor color)
        {
            SystemConsole.ForegroundColor = color;
        }

        public void Write(string text)
        {
            SystemConsole.Write(text);
        }

        public void WriteLine(string text)
        {
            SystemConsole.WriteLine(text);
        }
    }
}
