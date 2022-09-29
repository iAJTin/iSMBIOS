
#if NETSTANDARD2_1 || NET5_0_OR_GREATER

using System.Linq;

#else

using System;

#endif

using System.Runtime.Versioning;

namespace iTin.Core.ComponentModel
{
    /// <summary>
    /// This class allows to obtain the .net framework folder for a specific version.
    /// </summary>
    public class FrameworkVersion
    {
        #region constructor

        #region [internal] FrameworkVersion(TargetFrameworkAttribute): Initialize a new instance of the class
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Drawing.Clipping" /> class.
        /// </summary>
        /// <param name="frameworkAttribute">Framework compiled information</param>
        internal FrameworkVersion(TargetFrameworkAttribute frameworkAttribute)
        {

#if NETSTANDARD2_1 || NET5_0_OR_GREATER

            var items = frameworkAttribute.FrameworkName.SplitString(new[] {','}).AsEnumerable().ToList();
            VersionName = items.ElementAt(0);

            var frameworkVersionItems = items.ElementAt(1).SplitString(new[] {'='}).AsEnumerable();
            VersionNumber = frameworkVersionItems.ElementAt(1).Replace("v", string.Empty);

#else
            var items = frameworkAttribute.FrameworkName.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
            VersionName = items[0];

            var frameworkVersionItems = items[1].Split(new[] {'='}, StringSplitOptions.RemoveEmptyEntries);
            VersionNumber = frameworkVersionItems[1].Replace("v", string.Empty);

#endif
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) VersionName: Gets a framework version name
        /// <summary>
        /// Gets a framework version name.
        /// </summary>
        /// <value>
        /// Version name.
        /// </value>
        public string VersionName { get; }
        #endregion

        #region [public] (string) VersionNumber: Gets a framework version number
        /// <summary>
        /// Gets a framework version number.
        /// </summary>
        /// <value>
        /// Version number.
        /// </value>
        public string VersionNumber { get; }
        #endregion

        #endregion

        #region public methods

        #region [public] (string) RuntimeOutputFolder(): Returns runtime output folder for this version name and number
        /// <summary>
        /// Returns runtime output folder for this version name and number.
        /// </summary>
        /// <returns>
        /// A <see cref="T:system.String"/> that contains runtime output folder.
        /// </returns>
        public string RuntimeOutputFolder()
        {
            bool isNetFramework = VersionName.Contains("NETFramework");
            if (isNetFramework)
            {
                return $"net{VersionNumber.Replace(".", string.Empty)}";
            }

            bool isNetStandard = VersionName.Contains("NETStandard");
            if (isNetStandard)
            {
                return $"netstandard{VersionNumber}";
            }

            bool isNetCore = VersionName.Contains("NETCore");
            if (isNetCore)
            {
                return $"netcoreapp{VersionNumber}";
            }

            bool isUap = VersionName.Contains("UniversalWindowsPlatform");
            if (isUap)
            {
                return $"uap{VersionNumber}";
            }

            bool isWindowsPhone = VersionName.Contains("WindowsPhone");
            if (isWindowsPhone)
            {
                return $"wp{VersionNumber.Replace(".", string.Empty)}";
            }

            bool isWindowsStore = VersionName.Contains("WindowsStore");
            if (isWindowsStore)
            {
                return $"netcore{VersionNumber.Replace(".", string.Empty)}";
            }

            bool isMicroFramework = VersionName.Contains("NETMicroFramework");
            if (isMicroFramework)
            {
                return $"netmf{VersionNumber.Replace(".", string.Empty)}";
            }

            bool isSilverlight = VersionName.Contains("Silverlight");
            if (isSilverlight)
            {
                return $"sl{VersionNumber.Replace(".", string.Empty)}";
            }

            return string.Empty;
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current instance
        /// <summary>
        /// Returns a string that represents the current instance.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the current object.
        /// </returns>
        public override string ToString() => $"VersionName = \"{VersionName}\", VersionNumber = {VersionNumber}";
        #endregion

        #endregion
    }
}
