
namespace iSMBIOS.ConsoleAppCoreNuget
{
    using iTin.Core.Hardware;
    using iTin.Core.Hardware.Specification;
    using iTin.Core.Hardware.Specification.Dmi;
    using iTin.Core.Hardware.Specification.Dmi.Property;

    class Program
    {
        static void Main(string[] args)
        {
            DmiStructureCollection structures = DMI.Instance.Structures;

            // type 0
            string biosVersion = GetSmbiosProperty(structures, DmiProperty.Bios.BiosVersion);
            string biosVersionTyped = structures.GetProperty<string>(DmiProperty.Bios.BiosVersion);
        }

        private static string GetSmbiosProperty(DmiStructureCollection structure, IPropertyKey key)
        {
            string result = null;

            result = structure.GetProperty(key).ToString();

            return result;
        }
    }
}
