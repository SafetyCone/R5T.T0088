using System;

using R5T.T0088;

using Instances = R5T.T0088.X002.Instances;


namespace System
{
    public static class IConsoleOperatorExtensions
    {
        public static string GetAnsiBackgroundColorEscapeCode(this IConsoleOperator _, ConsoleColor background)
        {
            var output = background switch
            {
                ConsoleColor.Black => Instances.AnsiColorCode.BlackBackground(),
                ConsoleColor.Red => Instances.AnsiColorCode.RedBackground(),
                ConsoleColor.Green => Instances.AnsiColorCode.GreenBackground(),
                ConsoleColor.Yellow => Instances.AnsiColorCode.YellowBackground(),
                ConsoleColor.Blue => Instances.AnsiColorCode.BlueBackground(),
                ConsoleColor.Magenta => Instances.AnsiColorCode.MagentaBackground(),
                ConsoleColor.Cyan => Instances.AnsiColorCode.CyanBackground(),
                ConsoleColor.White => Instances.AnsiColorCode.WhiteBackground(),
                _ => Instances.AnsiColorCode.DefaultBackground(),
            };

            return output;
        }

        public static string GetAnsiForegroundColorEscapeCode(this IConsoleOperator _, ConsoleColor background)
        {
            var output = background switch
            {
                ConsoleColor.Black => Instances.AnsiColorCode.BlackForeground(),
                ConsoleColor.DarkRed => Instances.AnsiColorCode.DarkRedForeground(),
                ConsoleColor.DarkGreen => Instances.AnsiColorCode.DarkGreenForeground(),
                ConsoleColor.DarkYellow => Instances.AnsiColorCode.DarkYellowForeground(),
                ConsoleColor.DarkBlue => Instances.AnsiColorCode.DarkBlueForeground(),
                ConsoleColor.DarkMagenta => Instances.AnsiColorCode.DarkMagentaForeground(),
                ConsoleColor.DarkCyan => Instances.AnsiColorCode.DarkCyanForeground(),
                ConsoleColor.Gray => Instances.AnsiColorCode.GrayForeground(),
                ConsoleColor.Red => Instances.AnsiColorCode.RedForeground(),
                ConsoleColor.Green => Instances.AnsiColorCode.GreenForeground(),
                ConsoleColor.Yellow => Instances.AnsiColorCode.YellowForeground(),
                ConsoleColor.Blue => Instances.AnsiColorCode.BlueForeground(),
                ConsoleColor.Magenta => Instances.AnsiColorCode.MagentaForeground(),
                ConsoleColor.Cyan => Instances.AnsiColorCode.CyanForeground(),
                ConsoleColor.White => Instances.AnsiColorCode.WhiteForeground(),
                _ => Instances.AnsiColorCode.DefaultBackground(),
            };

            return output;
        }
    }
}
