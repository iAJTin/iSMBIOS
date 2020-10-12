
namespace iTin.Core.Helpers
{
    using System.Globalization;

    using Logging;

    /// <summary>
    /// Static class than contains common helper methods.
    /// </summary>
    public static class CommonHelper
    {
        /// <summary>
        /// Determines whether the specified value is numeric.
        /// </summary>
        /// <param name="target">The value.</param>
        /// <param name="numberStyle">The number style.</param>
        /// <returns>
        /// <b>true</b> if is numeric;Otherwise, <b>false</b>.
        /// </returns>
        public static bool IsNumeric(string target, NumberStyles numberStyle)
        {
            Logger.Instance.Debug("External Call");
            Logger.Instance.Info("  Determines whether the specified value is numeric");
            Logger.Instance.Info("  > Library: iTin.Core");
            Logger.Instance.Info("  > Class: CommonHelper");
            Logger.Instance.Info("  > Method: IsNumeric(string, NumberStyles)");
            Logger.Instance.Info("  > Output: bool");

            return double.TryParse(target, numberStyle, CultureInfo.CurrentCulture, out _);
        }
    }
}
