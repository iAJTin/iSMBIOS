
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;

using iTin.Core.ComponentModel;
using iTin.Logging;

namespace iTin.Core.Helpers
{
	/// <summary>
	/// Static class which contains methods for retrieve <b>.NET Framework</b> information.
	/// </summary>
	public static class NetFrameworkHelper
    {
        /// <summary>
        /// Returns <see cref="T:iTin.Core.ComponentModel.FrameworkVersion"/> that contains full path to current assembly.
        /// </summary>
        /// <returns>
        /// A <see cref="T:iTin.Core.ComponentModel.FrameworkVersion"/> that contains full path to current assembly.
        /// </returns>
        public static FrameworkVersion GetAssemblyFrameworkVersion(Assembly assembly)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(NetFrameworkHelper).Assembly.GetName().Name}, v{typeof(NetFrameworkHelper).Assembly.GetName().Version}, Namespace: {typeof(NetFrameworkHelper).Namespace}, Class: {nameof(NetFrameworkHelper)}");
            Logger.Instance.Debug($" Returns an {typeof(string)} that contains full path to current assembly");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) GetAssemblyFrameworkVersion({typeof(Assembly)})");

            var frameworkAttribute = (TargetFrameworkAttribute)assembly.GetCustomAttributes(typeof(TargetFrameworkAttribute), false).SingleOrDefault();

            return new FrameworkVersion(frameworkAttribute);
        }
    }


	//public enum FrameworkVersion
	//{
	//	Unknown,
	//	Version10,
	//	Version11,
	//	Version20,
	//	Version30,
	//	Version35,
	//	Version40,
	//	Version45
	//}

	//public class FrameworkHelper
	//{
	//	private const string STR_NETFrameWork = "SOFTWARE\\Microsoft\\.NETFramework";
	//	private const string STR_NETFremeworkAssemblyFolders = "SOFTWARE\\Microsoft\\.NETFramework\\AssemblyFolders";
	//	private const string STR_GACKey = "SOFTWARE\\Microsoft\\Fusion";
	//	private const string STR_CacheLocation = "CacheLocation";
	//	private const string STR_InstallRoot = "InstallRoot";
	//	private const string STR_MsCorLib = "mscorlib.dll";
	//	private const string STR_MicrosoftVisualBasic = "Microsoft.VisualBasic.dll";
	//	private const string STR_Star = "*";
	//	private const string Framework10 = "v1.0";
	//	private const string Framework11 = "v1.1";
	//	private const string Framework20 = "v2.0";
	//	private const string Framework30 = "v3.0";
	//	private const string Framework35 = "v3.5";
	//	private const string Framework40 = "v4.0";
	//	private const string Framework45 = "v4.5";
	//	private const string STR_NETSilverlightSdk = "SOFTWARE\\Microsoft\\Microsoft SDKs\\Silverlight";
	//	private const string STR_AssemblyFoldersEx = "AssemblyFoldersEx";
	//	private const string STR_ReferenceAssemblies = "ReferenceAssemblies";
	//	private const string STR_SLRuntimeInstallPath = "SLRuntimeInstallPath";
	//	private const string STR_VS2010Key = "SOFTWARE\\Microsoft\\VisualStudio\\10.0";
	//	private const string STR_VS2008Key = "SOFTWARE\\Microsoft\\VisualStudio\\9.0";
	//	private const string STR_VS2005Key = "SOFTWARE\\Microsoft\\VisualStudio\\8.0";



	//	private FrameworkHelper()
	//	{
	//	}



	//	public static string GetFrameworkRootPath() => GetFrameworkIntstallRootPath();

	//	public static string GetFrameworkRootPath(FrameworkVersion version)
	//	{
	//		if (version == FrameworkVersion.Version20 || version == FrameworkVersion.Version30 || version == FrameworkVersion.Version35)
	//		{
	//			return GetFrameworkIntstallRootPath();
	//		}

	//		const string referenceAssembliesFolder = @"\Reference Assemblies\Microsoft\Framework\.NETFramework\";
	//		string programFiles = Environment.GetEnvironmentVariable("programfiles");
	//		string path = programFiles + referenceAssembliesFolder;
	//		if (Directory.Exists(path))
	//		{
	//			return path;
	//		}

	//		programFiles = Environment.GetEnvironmentVariable("programfiles(x86)");
	//		path = programFiles + referenceAssembliesFolder;

	//		return Directory.Exists(path) ? path : GetFrameworkIntstallRootPath();
 //       }

	//	public static string[] GetFrameworkPaths(FrameworkVersion version)
	//	{
	//		string root = GetFrameworkRootPath(version);
	//		string versionPrefix = GetVersionPrefix(version);
	//		if (string.IsNullOrEmpty(versionPrefix))
	//		{
	//			return new string[0];
	//		}

	//		string[] directories = Directory.GetDirectories(root, string.Concat(versionPrefix, STR_Star));
	//		if (version != FrameworkVersion.Version30 && version != FrameworkVersion.Version35 && version != FrameworkVersion.Version40)
	//		{
	//			return directories;
	//		}

	//		ArrayList result = new ArrayList();
	//		result.AddRange(directories);
	//		try
	//		{
	//			using (RegistryKey assemblyFolders = Registry.LocalMachine.OpenSubKey($"{STR_NETFremeworkAssemblyFolders}\\{versionPrefix}", false))
	//			{
	//				if (assemblyFolders != null)
	//				{
	//					string key = assemblyFolders.GetValue("All Assemblies In") as string;
	//					if (!string.IsNullOrEmpty(key))
	//					{
	//						result.Add(key);
	//					}
	//				}
	//			}
	//		}
	//		catch
	//		{
	//		}

	//		return (string[])result.ToArray(typeof(string));
	//	}

	//	public static string GetFrameworkPath(FrameworkVersion version)
 //       {
 //           string[] directories = GetFrameworkPaths(version);
 //           return directories == null || directories.Length == 0 ? string.Empty : directories[0];
 //       }

	//	public static string GetActiveFrameworkPath()
	//	{
	//		string path = GetActiveMSCorLibPath();
	//		return string.IsNullOrEmpty(path) ? null : Path.GetDirectoryName(path);
 //       }

	//	public static string GetMSCorLibPath(FrameworkVersion version)
	//	{
	//		if (version == FrameworkVersion.Unknown)
	//		{
	//			return GetActiveMSCorLibPath();
	//		}

	//		string[] paths = GetFrameworkPaths(version);
	//		if (paths == null || paths.Length == 0)
	//		{
	//			return string.Empty;
	//		}

	//		for (int i = paths.Length - 1; i >= 0; i--)
	//		{
	//			string msCorLibPath = Path.Combine(paths[i], STR_MsCorLib);
	//			if (File.Exists(msCorLibPath))
	//			{
	//				return msCorLibPath;
	//			}
	//		}

	//		return string.Empty;
	//	}

	//	public static string GetVBRuntimeLibPath() => GetVBRuntimeLibPath(FrameworkVersion.Unknown);

	//	public static string GetVBRuntimeLibPath(FrameworkVersion frameworkVersion)
	//	{
	//		string mscorlibPath = GetMSCorLibPath(frameworkVersion);
	//		if (string.IsNullOrEmpty(mscorlibPath))
	//		{
	//			return null;
	//		}

	//		int slashIndex = mscorlibPath.LastIndexOf('\\');
	//		if (slashIndex < 0)
	//		{
	//			return null;
	//		}

	//		return $"{mscorlibPath.Substring(0, slashIndex)}\\{STR_MicrosoftVisualBasic}";
	//	}

	//	public static string GetActiveMSCorLibPath()
	//	{
	//		Type lType = typeof(int);
 //           Assembly lAssembly = lType.Assembly;

 //           return lAssembly.Location;
	//	}

	//	public static string[] GetAssemblyFoldersPaths()
	//	{
	//		var result = new ArrayList();

	//		try
	//		{
	//			using (RegistryKey assemblyFolders = Registry.LocalMachine.OpenSubKey(STR_NETFremeworkAssemblyFolders, false))
	//			{
	//				if (assemblyFolders == null)
	//				{
	//					return new string[0];
	//				}

	//				foreach (string subKeyName in assemblyFolders.GetSubKeyNames())
	//				{
	//					using (RegistryKey subKey = assemblyFolders.OpenSubKey(subKeyName, false))
	//					{
	//						string key = subKey.GetValue("All Assemblies In") as string;
	//						if (string.IsNullOrEmpty(key))
	//						{
	//							key = subKey.GetValue("") as string;
	//						}

	//						if (!string.IsNullOrEmpty(key))
	//						{
	//							result.Add(key);
	//						}
	//					}
	//				}
	//			}
	//		}
	//		catch
	//		{
	//		}

	//		return (string[])result.ToArray(typeof(string));
	//	}

	//	public static string[] GetAssemblyFoldersPaths(FrameworkVersion version)
	//	{
	//		List<string> result = new List<string>();
	//		try
	//		{
	//			using (RegistryKey assemblyFolders = Registry.LocalMachine.OpenSubKey(STR_NETFrameWork, false))
	//			{
	//				if (assemblyFolders == null)
	//				{
	//					return result.ToArray();
	//				}

	//				string[] subKeys = assemblyFolders.GetSubKeyNames();
	//				if (subKeys.Length == 0)
	//				{
	//					return result.ToArray();
	//				}

	//				string versionPrefix = GetVersionPrefix(version);
	//				if (string.IsNullOrEmpty(versionPrefix))
	//				{
	//					return result.ToArray();
	//				}

	//				List<string> versionSubKeys = new List<string>();
	//				foreach (string subKey in subKeys)
	//				{
	//					if (string.IsNullOrEmpty(subKey))
	//					{
	//						continue;
	//					}

	//					if (subKey.StartsWith(versionPrefix))
	//					{
	//						versionSubKeys.Add(subKey);
	//					}
	//				}

	//				foreach (string versionSubKey in versionSubKeys)
	//				{
	//					try
	//					{
	//						using (RegistryKey versionKey = assemblyFolders.OpenSubKey(versionSubKey))
	//						{
	//							ReadAssemblyFolders(result, versionKey);
	//						}
	//					}
	//					catch
	//					{
 //                       }
	//				}
	//			}
	//		}
	//		catch
	//		{
	//		}

	//		return result.ToArray();
	//	}

	//	public static string[] GetVSInstallFoldersPaths()
	//	{
	//		ArrayList result = new ArrayList();
	//		string path = GetInstallDirKey(STR_VS2010Key);
	//		if (!string.IsNullOrEmpty(path))
	//		{
	//			result.Add(path);
	//		}

	//		path = GetInstallDirKey(STR_VS2008Key);
	//		if (!string.IsNullOrEmpty(path))
	//		{
	//			result.Add(path);
	//		}

	//		path = GetInstallDirKey(STR_VS2005Key);
	//		if (!string.IsNullOrEmpty(path))
	//		{
	//			result.Add(path);
	//		}

	//		return (string[])result.ToArray(typeof(string));
	//	}

	//	public static bool IsInstalled(FrameworkVersion version)
	//	{
	//		string lPath = GetFrameworkPath(version);
	//		return !string.IsNullOrEmpty(lPath);
	//	}

	//	public static string GetAssemblyPath(AssemblyName name)
	//	{
	//		if (name == null)
	//		{
	//			return null;
	//		}

	//		string lPath = name.EscapedCodeBase;
	//		if (lPath != null)
	//		{
	//			return PathHelper.GetLocalPath(lPath);
	//		}

	//		string[] lSearchPaths = GetAssemblySearchPaths();

	//		return SearchForAssembly(lSearchPaths, name);
	//	}

	//	public static string GetAssemblyPath(string assemblyFileName)
	//	{
	//		if (string.IsNullOrEmpty(assemblyFileName))
	//		{
	//			return null;
	//		}

	//		string[] lSearchPaths = GetAssemblySearchPaths();

	//		return SearchForAssembly(lSearchPaths, assemblyFileName);
	//	}

	//	public static string GetAssemblyPath(string assemblyFileName, string[] paths) => string.IsNullOrEmpty(assemblyFileName) ? null : SearchForAssembly(paths, assemblyFileName);

 //       public static string GetSilverlightAssemblyPath(string assemblyFileName)
	//	{
	//		if (string.IsNullOrEmpty(assemblyFileName))
	//		{
	//			return null;
	//		}

	//		string[] paths;
	//		try
	//		{
	//			paths = GetSilverlightAssemblySearchPaths();
	//		}
	//		catch
	//		{
	//			paths = new string[0];
	//		}

	//		return SearchForAssembly(paths, assemblyFileName);
	//	}



	//	private static string GetVersionPrefix(FrameworkVersion version)
	//	{
	//		switch (version)
	//		{
	//			case FrameworkVersion.Version10:
	//				return Framework10;

	//			case FrameworkVersion.Version11:
	//				return Framework11;

	//			case FrameworkVersion.Version20:
	//				return Framework20;

	//			case FrameworkVersion.Version30:
	//				return Framework30;

	//			case FrameworkVersion.Version35:
	//				return Framework35;

	//			case FrameworkVersion.Version40:
	//				return Framework40;

	//			case FrameworkVersion.Version45:
	//				return Framework45;
	//		}

	//		return string.Empty;
	//	}

	//	private static bool ContainsKey(string[] names, string key)
	//	{
 //           if (names == null || names.Length == 0 || key == null)
 //           {
 //               return false;
 //           }

	//		int count = names.Length;
	//		for (int i = 0; i < count; i++)
	//		{
	//			string name = names[i];
 //               if (string.Compare(name, key, StringComparison.OrdinalIgnoreCase) == 0)
 //               {
 //                   return true;
 //               }
	//		}
	//		return false;
	//	}

	//	private static string GetGACPath()
	//	{
	//		RegistryPermission permission = new RegistryPermission(RegistryPermissionAccess.Read, STR_GACKey);
	//		permission.Demand();
	//		string cacheLocation = string.Empty;
	//		using (RegistryKey key = Registry.LocalMachine.OpenSubKey(STR_GACKey))
	//		{
	//			string[] subKeys = key.GetSubKeyNames();
	//			if (ContainsKey(subKeys, STR_CacheLocation))
	//				cacheLocation = (string)key.GetValue(STR_CacheLocation);
	//		}

	//		if (string.IsNullOrEmpty(cacheLocation))
	//		{
	//			string systemDir = Environment.SystemDirectory;
	//			string parentSystemDir = Path.GetDirectoryName(systemDir);
	//			cacheLocation = Path.Combine(parentSystemDir, "Assembly");
	//		}

	//		return cacheLocation;
	//	}

	//	private static string[] GetAssemblySearchPaths()
	//	{
	//		var lPaths = new ArrayList
	//		{
	//			GetActiveFrameworkPath()
	//		};

	//		lPaths.AddRange(GetFrameworkPaths(FrameworkVersion.Version10));
	//		lPaths.AddRange(GetFrameworkPaths(FrameworkVersion.Version11));
	//		lPaths.AddRange(GetFrameworkPaths(FrameworkVersion.Version20));
	//		lPaths.AddRange(GetFrameworkPaths(FrameworkVersion.Version30));
	//		lPaths.AddRange(GetFrameworkPaths(FrameworkVersion.Version35));
	//		lPaths.AddRange(GetFrameworkPaths(FrameworkVersion.Version40));

	//		return (string[])lPaths.ToArray(typeof(string));
	//	}

	//	private static string[] FindAssemblyFiles(string path, string pattern)
	//	{
	//		if (string.IsNullOrEmpty(path))
	//		{
	//			return new string[0];
	//		}

	//		if (string.IsNullOrEmpty(pattern))
	//		{
	//			return new string[0];
	//		}

	//		ArrayList result = new ArrayList();
	//		FindAssemblyFiles(result, path, pattern);

	//		return (string[])result.ToArray(typeof(string));
	//	}

	//	private static void FindAssemblyFiles(ArrayList result, string path, string pattern)
	//	{
	//		try
	//		{
	//			DirectoryInfo info = new DirectoryInfo(path);
	//			if (!info.Exists)
	//			{
	//				return;
	//			}

	//			string[] files = Directory.GetFiles(path, pattern, SearchOption.AllDirectories);
	//			if (files.Length > 0)
	//			{
	//				result.AddRange(files);
 //               }
	//		}
	//		catch
	//		{
 //           }
	//	}

	//	private static string[] GetAssemblyFiles(string path, string name)
	//	{
	//		if (string.IsNullOrEmpty(path) || string.IsNullOrEmpty(name))
	//		{
	//			return null;
	//		}

	//		string assemblyFile = name.EndsWith(".dll") ? name : string.Concat(name, ".dll");

	//		return FindAssemblyFiles(path, assemblyFile);
	//	}

	//	private static string SearchForAssembly(string[] paths, string assemblyFileName)
	//	{
	//		if (paths == null || paths.Length == 0)
	//		{
	//			return null;
	//		}

	//		if (string.IsNullOrEmpty(assemblyFileName))
	//		{
	//			return null;
	//		}

	//		foreach (var lPath in paths)
 //           {
 //               string[] lFiles = GetAssemblyFiles(lPath, assemblyFileName);
 //               if (lFiles != null && lFiles.Length > 0)
 //               {
 //                   return lFiles[0];
 //               }
 //           }

	//		return null;
	//	}

	//	private static string SearchForAssembly(string[] paths, AssemblyName name)
	//	{
	//		if (paths == null || paths.Length == 0)
	//		{
	//			return null;
	//		}

	//		if (name == null)
	//		{
	//			return null;
	//		}

	//		foreach (var lPath in paths)
 //           {
 //               string[] lFiles = GetAssemblyFiles(lPath, name.Name);
 //               string lAssemblyPath = SearchForAssemblyInsideFiles(lFiles, name);
 //               if (lAssemblyPath != null)
 //               {
 //                   return lAssemblyPath;
 //               }
 //           }

	//		return null;
	//	}

	//	private static string SearchForAssemblyInsideFiles(string[] files, AssemblyName name)
	//	{
	//		if (files == null || files.Length == 0)
	//		{
	//			return null;
	//		}

	//		foreach (var lFile in files)
 //           {
 //               AssemblyName lAssemblyName;

 //               try
 //               {
 //                   lAssemblyName = AssemblyName.GetAssemblyName(lFile);
 //               }
 //               catch
 //               {
 //                   continue;
 //               }

 //               if (lAssemblyName == null)
 //               {
 //                   continue;
 //               }

 //               if (lAssemblyName.FullName == name.FullName)
 //               {
 //                   return lFile;
 //               }
 //           }

	//		return null;
	//	}

	//	private static void ReadAssemblyFolders(List<string> result, RegistryKey key)
	//	{
	//		if (result == null || key == null)
	//		{
	//			return;
	//		}

	//		using (RegistryKey assemblyFoldersKey = key.OpenSubKey(STR_AssemblyFoldersEx))
	//		{
	//			if (assemblyFoldersKey == null)
	//			{
	//				return;
	//			}

	//			foreach (string subKeyName in assemblyFoldersKey.GetSubKeyNames())
	//			{
	//				using (RegistryKey subKey = assemblyFoldersKey.OpenSubKey(subKeyName))
	//				{
	//					if (subKey == null)
	//					{
	//						continue;
	//					}

	//					string path = subKey.GetValue(String.Empty) as string;
	//					if (!string.IsNullOrEmpty(path))
	//					{
	//						result.Add(path);
	//					}
	//				}
	//			}
	//		}
	//	}

	//	private static void ReadReferenceAssemblies(List<string> result, RegistryKey key, string valueName)
	//	{
	//		if (result == null || key == null)
	//		{
	//			return;
	//		}

	//		using (RegistryKey referenceAssembliesKey = key.OpenSubKey(STR_ReferenceAssemblies))
	//		{
	//			string path = (string)referenceAssembliesKey.GetValue(valueName);
	//			if (!string.IsNullOrEmpty(path))
	//			{
	//				result.Add(path);
	//			}
	//		}
	//	}

	//	private static string[] GetSilverlightAssemblySearchPaths()
	//	{
	//		List<string> result = new List<string>();
	//		RegistryPermission regPermission = new RegistryPermission(RegistryPermissionAccess.Read, STR_NETSilverlightSdk);
	//		regPermission.Demand();

	//		using (RegistryKey key = Registry.LocalMachine.OpenSubKey(STR_NETSilverlightSdk))
	//		{
	//			string[] versions = key.GetSubKeyNames();
	//			if (versions.Length == 0)
	//			{
	//				return null;
	//			}

	//			string version = versions[versions.Length - 1];
	//			using (RegistryKey versionKey = key.OpenSubKey(version))
	//			{
	//				ReadAssemblyFolders(result, versionKey);
	//				ReadReferenceAssemblies(result, versionKey, STR_SLRuntimeInstallPath);
	//			}
	//		}

	//		return result.ToArray();
	//	}

	//	private static string GetInstallDirKey(string registryFolder)
	//	{
	//		if (string.IsNullOrEmpty(registryFolder))
	//		{
	//			return string.Empty;
	//		}

	//		RegistryPermission regPermission = new RegistryPermission(RegistryPermissionAccess.Read, registryFolder);
	//		regPermission.Demand();

	//		using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registryFolder))
	//		{
	//			if (key == null)
	//			{
	//				return string.Empty;
	//			}

	//			return key.GetValue("InstallDir") as string;
	//		}
	//	}

	//	private static string GetFrameworkIntstallRootPath()
	//	{
	//		RegistryPermission lRegPermission = new RegistryPermission(RegistryPermissionAccess.Read, STR_NETFrameWork);
	//		lRegPermission.Demand();

	//		using (RegistryKey lKey = Registry.LocalMachine.OpenSubKey(STR_NETFrameWork))
	//		{
	//			return (string)lKey.GetValue(STR_InstallRoot);
	//		}
	//	}
	//}
}
