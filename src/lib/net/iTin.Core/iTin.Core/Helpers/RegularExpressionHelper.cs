
namespace iTin.Core.Helpers
{
    using System.Diagnostics;
    using System.Text.RegularExpressions;

    using Logging;

    /// <summary> 
    /// Static class than contains methods for regular expressions. http://regexhero.net/tester/
    /// </summary>
    public static class RegularExpressionHelper
    {
        #region private constants

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string EmailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string GuidPattern = @"^[A-Fa-f0-9]{32}$|^({|\()?[A-Fa-f0-9]{8}-([A-Fa-f0-9]{4}-){3}[A-Fa-f0-9]{12}(}|\))?$|^({)?[0xA-Fa-f0-9]{3,10}(, {0,1}[0xA-Fa-f0-9]{3,6}){2}, {0,1}({)([0xA-Fa-f0-9]{3,4}, {0,1}){7}[0xA-Fa-f0-9]{3,4}(}})$";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string IntegerNumberPattern = @"^\d+$";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string IpPattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string PathPattern = @"^(.*/)?(?:$|(.+?)(?:(\.[^.]*$)|$))";

        #endregion

        #region public static methods

        #region [public] {static} (bool) IsNumeric(string): Determines whether value parameter is a valid integer number
        /// <summary>
        /// Determines whether <paramref name="value" /> is a numeric value.is a valid integer number.
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <returns>
        /// <strong>true</strong> if value is numeric; otherwise, <strong>false</strong>.
        /// </returns>
        public static bool IsNumeric(string value)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: RegularExpressionHelper");
            Logger.Instance.Debug(" Determines whether value parameter is a integer number.");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) IsNumeric({typeof(string)})");

            SentinelHelper.ArgumentNull(value, nameof(value));

            Logger.Instance.Debug($"   > value: {value}");

            Regex format = new Regex(IntegerNumberPattern);
            bool match = format.IsMatch(value);

            Logger.Instance.Debug(" > Output:");
            Logger.Instance.Debug($"   > Pattern to use: {IntegerNumberPattern}");
            Logger.Instance.Debug($"   > Value: {match}");

            return match;
        }
        #endregion

        #region [public] {static} (bool) IsValidGuid(string): Determines whether value parameter is valid guid
        /// <summary>
        /// Converts the string representation of a Guid to its Guid 
        /// equivalent. A return value indicates whether the operation 
        /// succeeded. 
        /// </summary>
        /// <param name="value">A string containing a Guid to convert.</param>
        /// <returns>
        /// <strong>true</strong> if ip address is valid; otherwise, <strong>false</strong>.
        /// </returns>
        public static bool IsValidGuid(string value)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: RegularExpressionHelper");
            Logger.Instance.Debug(" Determines whether value parameter is a valid guid.");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) IsValidGuid({typeof(string)})");

            SentinelHelper.ArgumentNull(value, nameof(value));

            Logger.Instance.Debug($"   > value: {value}");

            Regex format = new Regex(GuidPattern);
            bool match = format.IsMatch(value);

            Logger.Instance.Debug(" > Output:");
            Logger.Instance.Debug($"   > Pattern to use: {GuidPattern}");
            Logger.Instance.Debug($"   > Value: {match}");

            return match;
        }
        #endregion

        #region [public] {static} (bool) IsValidIpAddress(string): Determines whether value parameter is valid ip address
        /// <summary>
        /// Determines whether <paramref name="value" /> is valid ip address.
        /// </summary>
        /// <param name="value">Ip address to check.</param>
        /// <returns>
        /// <strong>true</strong> if ip address is valid; otherwise, <strong>false</strong>.
        /// </returns>
        public static bool IsValidIpAddress(string value)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: RegularExpressionHelper");
            Logger.Instance.Debug(" Determines whether value parameter is valid ip address.");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) IsValidIpAddress({typeof(string)})");

            SentinelHelper.ArgumentNull(value, nameof(value));
            SentinelHelper.IsTrue(value.Length > 15);

            Logger.Instance.Debug($"   > value: {value}");

            Regex format = new Regex(IpPattern);
            bool match = format.IsMatch(value);

            Logger.Instance.Debug(" > Output:");
            Logger.Instance.Debug($"   > Pattern to use: {IpPattern}");
            Logger.Instance.Debug($"   > Value: {match}");

            return match;
        }
        #endregion

        #region [public] {static} (bool) IsValidEmailAddress(string): Determines whether value parameter is valid mail address
        /// <summary>
        /// Determines whether <paramref name="value" /> is valid mail address.
        /// </summary>
        /// <param name="value">Mail address to check.</param>
        /// <returns>
        /// <strong>true</strong> if mail address is valid; otherwise, <strong>false</strong>.
        /// </returns>
        public static bool IsValidEmailAddress(string value)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: RegularExpressionHelper");
            Logger.Instance.Debug(" Determines whether value parameter is valid mail address.");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) IsValidEmailAddress({typeof(string)})");

            SentinelHelper.ArgumentNull(value, nameof(value));

            Logger.Instance.Debug($"   > value: {value}");

            Regex format = new Regex(EmailPattern);
            bool match = format.IsMatch(value);

            Logger.Instance.Debug(" > Output:");
            Logger.Instance.Debug($"   > Pattern to use: {EmailPattern}");
            Logger.Instance.Debug($"   > Value: {match}");

            return match;
        }
        #endregion

        #region [public] {static} (bool) IsValidPath(string): Determines whether value parameter is a valid path
        /// <summary>
        /// Determines whether <paramref name="value" /> is a valid path.
        /// </summary>
        /// <param name="value">Path to check.</param>
        /// <returns>
        /// <strong>true</strong> if path is valid; otherwise, <strong>false</strong>.
        /// </returns>
        public static bool IsValidPath(string value)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: RegularExpressionHelper");
            Logger.Instance.Debug(" Determines whether value parameter is a valid path.");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) IsValidPath({typeof(string)})");

            SentinelHelper.ArgumentNull(value, nameof(value));

            Logger.Instance.Debug($"   > value: {value}");

            Regex format = new Regex(PathPattern);
            bool match = format.IsMatch(value);

            Logger.Instance.Debug(" > Output:");
            Logger.Instance.Debug($"   > Pattern to use: {PathPattern}");
            Logger.Instance.Debug($"   > Value: {match}");

            return match;
        }
        #endregion

        #endregion
    }
}
