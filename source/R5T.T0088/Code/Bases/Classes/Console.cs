using System;


namespace R5T.T0088
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Console : IConsole
    {
        #region Static
        
        public static Console Instance { get; } = new();

        #endregion
    }
}