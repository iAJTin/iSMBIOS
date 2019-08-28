
namespace iTin.Core.Hardware.Interop.Edid
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;

    using iTin.Core.Interop.Windows.Development.DeviceAndDriverInstallation.SetupApi;

    /// <summary>
    /// Safe natice methods for handle EDID.
    /// </summary>
    public static class SafeNativeMethods
    {
        public static void EnumMonitorDevices()
        {
            uint enumerator = 0;
            Guid GUID_DEVCLASS_MONITOR = new Guid("{0x4d36e96e, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}");

            bool success = true;
            while (success)
            {
                IntPtr devInfo =
                    NativeMethods.SetupDiGetClassDevsEx(
                        ref GUID_DEVCLASS_MONITOR,     // class GUID
                        enumerator,                    // enumerator
                        IntPtr.Zero,         // HWND
                        DiGetClassFlags.DIGCF_PRESENT, // Flags
                        IntPtr.Zero,      // device info, create a new one
                        null,               // machine name, local machine
                        IntPtr.Zero);

                SP_DEVINFO_DATA devInfoData = SP_DEVINFO_DATA.Empty;
                var ok = NativeMethods.SetupDiEnumDeviceInfo(devInfo, 0, ref devInfoData);
                if (!ok)
                {
                    success = false;
                }

                if (success)
                {
                    PlayWithDeviceInfo(devInfo, devInfoData);
                }

                enumerator++;
            }
        }

        public static void PlayWithDeviceInfo(IntPtr devInfo, SP_DEVINFO_DATA devInfoData)
        {
            UInt32 regType;
            UInt32 requiredSize;
            byte[] buffer = new byte[123];

            // build a DevInfo Data structure
            SP_DEVINFO_DATA da = new SP_DEVINFO_DATA();
            da.cbSize = (uint)Marshal.SizeOf(da);

            bool success =
                NativeMethods.SetupDiGetDeviceRegistryProperty(
                    devInfo,
                    ref devInfoData,
                    NativeMethods.KnownSetupDiGetDeviceRegistryProperty.SPDRP_DEVICEDESC,
                    out regType,
                    buffer,
                    124,
                    out requiredSize);
            if (!success)
            {
                return;
            }

            string deviceDescription = Encoding.Unicode.GetString(buffer);

            IntPtr key =
                NativeMethods.SetupDiOpenDevRegKey(
                    devInfo,
                    ref devInfoData,
                    0x00000001,
                    0,
                    0x00000001,
                    0x00000001);

            int i = 0;
        }
    }
}

//if (
//    SetupDiGetDeviceRegistryProperty(
//        devInfo, 
//        devInfoData, 
//        SPDRP_DEVICEDESC, 
//        //SPDRP_UI_NUMBER, 
//        NULL, 
//        (PBYTE)(&uniID), 
//        sizeof(uniID), 
//        NULL))
//{
//    printf("UID: %s\n", uniID);
//}
//else
//{
//    printf("ERROR: %d\n", GetLastError());
//}

//hDevRegKey = SetupDiOpenDevRegKey(
//    devInfo,
//    devInfoData,
//    DICS_FLAG_GLOBAL,
//    0,
//    DIREG_DEV,
//    KEY_ALL_ACCESS);

//if (hDevRegKey)
//{
//    LONG retValue, i;
//    DWORD dwType, AcutalValueNameLength = NAME_SIZE;

//    CHAR valueName[NAME_SIZE];

//    for (i = 0, retValue = ERROR_SUCCESS; retValue != ERROR_NO_MORE_ITEMS; i++)
//    {
//        unsigned char EDIDdata[1024];
//        DWORD j, edidsize = sizeof(EDIDdata);

//        retValue = RegEnumValue(
//            hDevRegKey,
//            i,
//            &valueName[0],
//            &AcutalValueNameLength,
//            NULL,//reserved
//            &dwType,
//            EDIDdata, // buffer
//            &edidsize); // buffer size

//        if (retValue == ERROR_SUCCESS)
//        {
//            if (!strcmp(valueName, "EDID"))
//            {
//                printf("Found value EDID\n");
//                {

//                    for (j = 0; j < edidsize; j++)
//                    {
//                        if (j % 16 == 0) printf("\n");
//                        printf("%02x ", EDIDdata[j]);
//                    }
//                    printf("\n");
//                }

//                break;
//            }
//        }
//    }

//    RegCloseKey(hDevRegKey);
//}
//else
//{
//    printf("ERROR:%d\n", GetLastError());
//}
