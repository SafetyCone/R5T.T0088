using System;


namespace R5T.T0088
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ConsoleOperator : IConsoleOperator
    {
        #region Static
        
        public static ConsoleOperator Instance { get; } = new();

        #endregion
    }
}