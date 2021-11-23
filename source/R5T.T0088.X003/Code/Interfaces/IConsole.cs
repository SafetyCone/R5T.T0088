using System;


namespace R5T.T0088.X003
{
    /// <summary>
    /// Attempt at a universal console description.
    /// </summary>
    /// <remarks>
    /// Considerations:
    /// * Atomicity of operations.
    /// * Thread-safety of operations.
    /// * Performance.
    /// </remarks>
    public interface IConsole
    {
        void Write(string text);
        void WriteLine(string text);

        void SetBackgroundColor(ConsoleColor color);
        void SetForegroundColor(ConsoleColor color);
    }
}
