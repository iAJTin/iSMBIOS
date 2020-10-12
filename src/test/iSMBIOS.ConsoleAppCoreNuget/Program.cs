﻿
namespace iSMBIOS.ConsoleAppCoreNuget
{
    using iTin.Core.Hardware.Common;

    using iTin.Hardware.Specification;
    using iTin.Hardware.Specification.Dmi;
    using iTin.Hardware.Specification.Dmi.Property;

    class Program
    {
        private static readonly byte[] LenovoL490 =
        {
            0x00, 0x03, 0x01, 0x00, 0x4A, 0x0C, 0x00, 0x00,
            0xDE, 0x0E, 0x00, 0x00, 0x01, 0x99, 0x00, 0x03,
            0x10, 0x01, 0x20, 0x02, 0x30, 0x03, 0x4D, 0x65,
            0x6D, 0x6F, 0x72, 0x79, 0x20, 0x49, 0x6E, 0x69,
            0x74, 0x20, 0x43, 0x6F, 0x6D, 0x70, 0x6C, 0x65,
            0x74, 0x65, 0x00, 0x45, 0x6E, 0x64, 0x20, 0x6F,
            0x66, 0x20, 0x44, 0x58, 0x45, 0x20, 0x50, 0x68,
            0x61, 0x73, 0x65, 0x00, 0x42, 0x49, 0x4F, 0x53,
            0x20, 0x42, 0x6F, 0x6F, 0x74, 0x20, 0x43, 0x6F,
            0x6D, 0x70, 0x6C, 0x65, 0x74, 0x65, 0x00, 0x00,
            0x0E, 0x08, 0x01, 0x00, 0x01, 0xDE, 0x00, 0x00,
            0x49, 0x6E, 0x74, 0x65, 0x6C, 0x28, 0x52, 0x29,
            0x20, 0x53, 0x69, 0x6C, 0x69, 0x63, 0x6F, 0x6E,
            0x20, 0x56, 0x69, 0x65, 0x77, 0x20, 0x54, 0x65,
            0x63, 0x68, 0x6E, 0x6F, 0x6C, 0x6F, 0x67, 0x79,
            0x00, 0x00, 0x10, 0x17, 0x02, 0x00, 0x03, 0x03,
            0x03, 0x00, 0x00, 0x00, 0x02, 0xFE, 0xFF, 0x02,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x11, 0x28, 0x03, 0x00, 0x02,
            0x00, 0xFE, 0xFF, 0x40, 0x00, 0x40, 0x00, 0xFF,
            0x7F, 0x0D, 0x00, 0x01, 0x02, 0x1A, 0x80, 0x00,
            0x6B, 0x0A, 0x03, 0x04, 0x05, 0x06, 0x02, 0x00,
            0x80, 0x00, 0x00, 0x60, 0x09, 0x00, 0x00, 0x00,
            0x00, 0xB0, 0x04, 0x43, 0x68, 0x61, 0x6E, 0x6E,
            0x65, 0x6C, 0x41, 0x2D, 0x44, 0x49, 0x4D, 0x4D,
            0x30, 0x00, 0x42, 0x41, 0x4E, 0x4B, 0x20, 0x30,
            0x00, 0x53, 0x61, 0x6D, 0x73, 0x75, 0x6E, 0x67,
            0x00, 0x30, 0x33, 0x36, 0x37, 0x43, 0x30, 0x36,
            0x39, 0x00, 0x4E, 0x6F, 0x6E, 0x65, 0x00, 0x4D,
            0x34, 0x37, 0x31, 0x41, 0x34, 0x47, 0x34, 0x33,
            0x4D, 0x42, 0x31, 0x2D, 0x43, 0x54, 0x44, 0x20,
            0x20, 0x20, 0x20, 0x00, 0x00, 0x11, 0x28, 0x04,
            0x00, 0x02, 0x00, 0xFE, 0xFF, 0x40, 0x00, 0x40,
            0x00, 0xFF, 0x7F, 0x0D, 0x00, 0x01, 0x02, 0x1A,
            0x80, 0x00, 0x6B, 0x0A, 0x03, 0x04, 0x05, 0x06,
            0x02, 0x00, 0x80, 0x00, 0x00, 0x60, 0x09, 0x00,
            0x00, 0x00, 0x00, 0xB0, 0x04, 0x43, 0x68, 0x61,
            0x6E, 0x6E, 0x65, 0x6C, 0x42, 0x2D, 0x44, 0x49,
            0x4D, 0x4D, 0x30, 0x00, 0x42, 0x41, 0x4E, 0x4B,
            0x20, 0x32, 0x00, 0x53, 0x61, 0x6D, 0x73, 0x75,
            0x6E, 0x67, 0x00, 0x30, 0x33, 0x36, 0x37, 0x43,
            0x30, 0x44, 0x39, 0x00, 0x4E, 0x6F, 0x6E, 0x65,
            0x00, 0x4D, 0x34, 0x37, 0x31, 0x41, 0x34, 0x47,
            0x34, 0x33, 0x4D, 0x42, 0x31, 0x2D, 0x43, 0x54,
            0x44, 0x20, 0x20, 0x20, 0x20, 0x00, 0x00, 0x13,
            0x1F, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF,
            0xFF, 0xFF, 0x03, 0x02, 0x00, 0x02, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xDD, 0x0C, 0x06, 0x00, 0x01, 0x01, 0x00, 0x02,
            0x00, 0x00, 0xBD, 0x10, 0x42, 0x49, 0x4F, 0x53,
            0x20, 0x47, 0x75, 0x61, 0x72, 0x64, 0x00, 0x00,
            0xDD, 0x1A, 0x07, 0x00, 0x03, 0x01, 0x00, 0x07,
            0x00, 0x56, 0x50, 0x00, 0x02, 0x00, 0x00, 0x00,
            0x00, 0xC6, 0x00, 0x03, 0x00, 0x01, 0x06, 0x00,
            0x00, 0x00, 0x52, 0x65, 0x66, 0x65, 0x72, 0x65,
            0x6E, 0x63, 0x65, 0x20, 0x43, 0x6F, 0x64, 0x65,
            0x20, 0x2D, 0x20, 0x43, 0x50, 0x55, 0x00, 0x75,
            0x43, 0x6F, 0x64, 0x65, 0x20, 0x56, 0x65, 0x72,
            0x73, 0x69, 0x6F, 0x6E, 0x00, 0x54, 0x58, 0x54,
            0x20, 0x41, 0x43, 0x4D, 0x20, 0x76, 0x65, 0x72,
            0x73, 0x69, 0x6F, 0x6E, 0x00, 0x00, 0xDD, 0x1A,
            0x08, 0x00, 0x03, 0x01, 0x00, 0x07, 0x00, 0x56,
            0x50, 0x00, 0x02, 0x00, 0x0C, 0x00, 0x00, 0x0A,
            0x00, 0x03, 0x04, 0x0C, 0x00, 0x20, 0x8D, 0x05,
            0x52, 0x65, 0x66, 0x65, 0x72, 0x65, 0x6E, 0x63,
            0x65, 0x20, 0x43, 0x6F, 0x64, 0x65, 0x20, 0x2D,
            0x20, 0x4D, 0x45, 0x00, 0x4D, 0x45, 0x42, 0x78,
            0x20, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E,
            0x00, 0x4D, 0x45, 0x20, 0x46, 0x69, 0x72, 0x6D,
            0x77, 0x61, 0x72, 0x65, 0x20, 0x56, 0x65, 0x72,
            0x73, 0x69, 0x6F, 0x6E, 0x00, 0x43, 0x6F, 0x72,
            0x70, 0x6F, 0x72, 0x61, 0x74, 0x65, 0x20, 0x53,
            0x4B, 0x55, 0x00, 0x00, 0xDD, 0x52, 0x09, 0x00,
            0x0B, 0x01, 0x00, 0x07, 0x00, 0x56, 0x50, 0x00,
            0x02, 0x03, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x04,
            0x00, 0xFF, 0xFF, 0xFF, 0x30, 0x00, 0x05, 0x00,
            0xFF, 0xFF, 0xFF, 0x30, 0x00, 0x06, 0x00, 0x02,
            0x0A, 0x00, 0x00, 0x00, 0x07, 0x00, 0x02, 0x00,
            0x00, 0x00, 0x00, 0x08, 0x00, 0x09, 0x00, 0x00,
            0x00, 0x00, 0x09, 0x00, 0x0A, 0x00, 0x00, 0x00,
            0x00, 0x0A, 0x00, 0x07, 0x00, 0x00, 0x00, 0x00,
            0x0B, 0x00, 0x06, 0x00, 0x00, 0x00, 0x00, 0x0C,
            0x00, 0x07, 0x00, 0x00, 0x00, 0x00, 0x52, 0x65,
            0x66, 0x65, 0x72, 0x65, 0x6E, 0x63, 0x65, 0x20,
            0x43, 0x6F, 0x64, 0x65, 0x20, 0x2D, 0x20, 0x43,
            0x4E, 0x4C, 0x20, 0x50, 0x43, 0x48, 0x00, 0x50,
            0x43, 0x48, 0x2D, 0x43, 0x52, 0x49, 0x44, 0x20,
            0x53, 0x74, 0x61, 0x74, 0x75, 0x73, 0x00, 0x44,
            0x69, 0x73, 0x61, 0x62, 0x6C, 0x65, 0x64, 0x00,
            0x50, 0x43, 0x48, 0x2D, 0x43, 0x52, 0x49, 0x44,
            0x20, 0x4F, 0x72, 0x69, 0x67, 0x69, 0x6E, 0x61,
            0x6C, 0x20, 0x56, 0x61, 0x6C, 0x75, 0x65, 0x00,
            0x50, 0x43, 0x48, 0x2D, 0x43, 0x52, 0x49, 0x44,
            0x20, 0x4E, 0x65, 0x77, 0x20, 0x56, 0x61, 0x6C,
            0x75, 0x65, 0x00, 0x4F, 0x50, 0x52, 0x4F, 0x4D,
            0x20, 0x2D, 0x20, 0x52, 0x53, 0x54, 0x20, 0x2D,
            0x20, 0x52, 0x41, 0x49, 0x44, 0x00, 0x43, 0x4E,
            0x4C, 0x20, 0x50, 0x43, 0x48, 0x20, 0x48, 0x20,
            0x41, 0x30, 0x20, 0x48, 0x73, 0x69, 0x6F, 0x20,
            0x56, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x00,
            0x43, 0x4E, 0x4C, 0x20, 0x50, 0x43, 0x48, 0x20,
            0x48, 0x20, 0x41, 0x78, 0x20, 0x48, 0x73, 0x69,
            0x6F, 0x20, 0x56, 0x65, 0x72, 0x73, 0x69, 0x6F,
            0x6E, 0x00, 0x43, 0x4E, 0x4C, 0x20, 0x50, 0x43,
            0x48, 0x20, 0x48, 0x20, 0x42, 0x78, 0x20, 0x48,
            0x73, 0x69, 0x6F, 0x20, 0x56, 0x65, 0x72, 0x73,
            0x69, 0x6F, 0x6E, 0x00, 0x43, 0x4E, 0x4C, 0x20,
            0x50, 0x43, 0x48, 0x20, 0x4C, 0x50, 0x20, 0x42,
            0x30, 0x20, 0x48, 0x73, 0x69, 0x6F, 0x20, 0x56,
            0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x00, 0x43,
            0x4E, 0x4C, 0x20, 0x50, 0x43, 0x48, 0x20, 0x4C,
            0x50, 0x20, 0x42, 0x78, 0x20, 0x48, 0x73, 0x69,
            0x6F, 0x20, 0x56, 0x65, 0x72, 0x73, 0x69, 0x6F,
            0x6E, 0x00, 0x43, 0x4E, 0x4C, 0x20, 0x50, 0x43,
            0x48, 0x20, 0x4C, 0x50, 0x20, 0x44, 0x78, 0x20,
            0x48, 0x73, 0x69, 0x6F, 0x20, 0x56, 0x65, 0x72,
            0x73, 0x69, 0x6F, 0x6E, 0x00, 0x00, 0xDD, 0x36,
            0x0A, 0x00, 0x07, 0x01, 0x00, 0x07, 0x00, 0x56,
            0x50, 0x00, 0x02, 0x00, 0x00, 0x07, 0x01, 0x64,
            0x00, 0x03, 0x00, 0x07, 0x00, 0x56, 0x50, 0x00,
            0x04, 0x05, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x06,
            0x00, 0x00, 0x00, 0x00, 0x0C, 0x00, 0x07, 0x00,
            0x00, 0x00, 0x00, 0x0C, 0x00, 0x08, 0x00, 0xFF,
            0xFF, 0xFF, 0xFF, 0xFF, 0x52, 0x65, 0x66, 0x65,
            0x72, 0x65, 0x6E, 0x63, 0x65, 0x20, 0x43, 0x6F,
            0x64, 0x65, 0x20, 0x2D, 0x20, 0x53, 0x41, 0x20,
            0x2D, 0x20, 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D,
            0x20, 0x41, 0x67, 0x65, 0x6E, 0x74, 0x00, 0x52,
            0x65, 0x66, 0x65, 0x72, 0x65, 0x6E, 0x63, 0x65,
            0x20, 0x43, 0x6F, 0x64, 0x65, 0x20, 0x2D, 0x20,
            0x4D, 0x52, 0x43, 0x00, 0x53, 0x41, 0x20, 0x2D,
            0x20, 0x50, 0x43, 0x49, 0x65, 0x20, 0x56, 0x65,
            0x72, 0x73, 0x69, 0x6F, 0x6E, 0x00, 0x53, 0x41,
            0x2D, 0x43, 0x52, 0x49, 0x44, 0x20, 0x53, 0x74,
            0x61, 0x74, 0x75, 0x73, 0x00, 0x44, 0x69, 0x73,
            0x61, 0x62, 0x6C, 0x65, 0x64, 0x00, 0x53, 0x41,
            0x2D, 0x43, 0x52, 0x49, 0x44, 0x20, 0x4F, 0x72,
            0x69, 0x67, 0x69, 0x6E, 0x61, 0x6C, 0x20, 0x56,
            0x61, 0x6C, 0x75, 0x65, 0x00, 0x53, 0x41, 0x2D,
            0x43, 0x52, 0x49, 0x44, 0x20, 0x4E, 0x65, 0x77,
            0x20, 0x56, 0x61, 0x6C, 0x75, 0x65, 0x00, 0x4F,
            0x50, 0x52, 0x4F, 0x4D, 0x20, 0x2D, 0x20, 0x56,
            0x42, 0x49, 0x4F, 0x53, 0x00, 0x00, 0xDD, 0x0C,
            0x0B, 0x00, 0x01, 0x01, 0x00, 0x04, 0x00, 0x00,
            0x00, 0x00, 0x46, 0x53, 0x50, 0x20, 0x42, 0x69,
            0x6E, 0x61, 0x72, 0x79, 0x20, 0x56, 0x65, 0x72,
            0x73, 0x69, 0x6F, 0x6E, 0x00, 0x00, 0x07, 0x1B,
            0x0C, 0x00, 0x01, 0x80, 0x01, 0x00, 0x01, 0x00,
            0x01, 0x20, 0x00, 0x20, 0x00, 0x00, 0x04, 0x05,
            0x07, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01, 0x00,
            0x00, 0x4C, 0x31, 0x20, 0x43, 0x61, 0x63, 0x68,
            0x65, 0x00, 0x00, 0x07, 0x1B, 0x0D, 0x00, 0x01,
            0x81, 0x01, 0x00, 0x04, 0x00, 0x04, 0x20, 0x00,
            0x20, 0x00, 0x00, 0x05, 0x05, 0x05, 0x00, 0x04,
            0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x4C, 0x32,
            0x20, 0x43, 0x61, 0x63, 0x68, 0x65, 0x00, 0x00,
            0x07, 0x1B, 0x0E, 0x00, 0x01, 0x82, 0x01, 0x00,
            0x20, 0x00, 0x20, 0x20, 0x00, 0x20, 0x00, 0x00,
            0x06, 0x05, 0x08, 0x00, 0x20, 0x00, 0x00, 0x00,
            0x20, 0x00, 0x00, 0x4C, 0x33, 0x20, 0x43, 0x61,
            0x63, 0x68, 0x65, 0x00, 0x00, 0x04, 0x30, 0x0F,
            0x00, 0x01, 0x03, 0xC6, 0x02, 0xEC, 0x06, 0x08,
            0x00, 0xFF, 0xFB, 0xEB, 0xBF, 0x03, 0x87, 0x64,
            0x00, 0x34, 0x08, 0x6C, 0x07, 0x41, 0x3C, 0x0C,
            0x00, 0x0D, 0x00, 0x0E, 0x00, 0x04, 0x05, 0x06,
            0x04, 0x04, 0x08, 0xFC, 0x00, 0xC6, 0x00, 0x04,
            0x00, 0x04, 0x00, 0x08, 0x00, 0x55, 0x33, 0x45,
            0x31, 0x00, 0x49, 0x6E, 0x74, 0x65, 0x6C, 0x28,
            0x52, 0x29, 0x20, 0x43, 0x6F, 0x72, 0x70, 0x6F,
            0x72, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00, 0x49,
            0x6E, 0x74, 0x65, 0x6C, 0x28, 0x52, 0x29, 0x20,
            0x43, 0x6F, 0x72, 0x65, 0x28, 0x54, 0x4D, 0x29,
            0x20, 0x69, 0x37, 0x2D, 0x38, 0x36, 0x36, 0x35,
            0x55, 0x20, 0x43, 0x50, 0x55, 0x20, 0x40, 0x20,
            0x31, 0x2E, 0x39, 0x30, 0x47, 0x48, 0x7A, 0x00,
            0x4E, 0x6F, 0x6E, 0x65, 0x00, 0x4E, 0x6F, 0x6E,
            0x65, 0x00, 0x4E, 0x6F, 0x6E, 0x65, 0x00, 0x00,
            0x86, 0x0D, 0x10, 0x00, 0x08, 0x05, 0x19, 0x20,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x1A, 0x11, 0x00, 0x01, 0x02, 0x00, 0xE0, 0x03,
            0xFF, 0x80, 0x9A, 0x09, 0x7D, 0x00, 0x00, 0x12,
            0x00, 0x03, 0x0D, 0x01, 0x0F, 0x01, 0x0C, 0x20,
            0x00, 0x4C, 0x45, 0x4E, 0x4F, 0x56, 0x4F, 0x00,
            0x52, 0x30, 0x5A, 0x45, 0x54, 0x33, 0x37, 0x57,
            0x20, 0x28, 0x31, 0x2E, 0x31, 0x35, 0x20, 0x29,
            0x00, 0x31, 0x32, 0x2F, 0x31, 0x31, 0x2F, 0x32,
            0x30, 0x31, 0x39, 0x00, 0x00, 0x01, 0x1B, 0x12,
            0x00, 0x01, 0x02, 0x03, 0x04, 0xCC, 0x9A, 0x03,
            0x83, 0x71, 0x24, 0xB2, 0x11, 0xA8, 0x5C, 0xA3,
            0x49, 0x24, 0x1D, 0x54, 0xD4, 0x06, 0x05, 0x06,
            0x4C, 0x45, 0x4E, 0x4F, 0x56, 0x4F, 0x00, 0x32,
            0x30, 0x51, 0x35, 0x5A, 0x34, 0x50, 0x36, 0x55,
            0x53, 0x00, 0x54, 0x68, 0x69, 0x6E, 0x6B, 0x50,
            0x61, 0x64, 0x20, 0x4C, 0x34, 0x39, 0x30, 0x00,
            0x50, 0x46, 0x31, 0x4E, 0x4B, 0x4A, 0x38, 0x56,
            0x00, 0x4C, 0x45, 0x4E, 0x4F, 0x56, 0x4F, 0x5F,
            0x4D, 0x54, 0x5F, 0x32, 0x30, 0x51, 0x35, 0x5F,
            0x42, 0x55, 0x5F, 0x53, 0x4D, 0x42, 0x5F, 0x46,
            0x4D, 0x5F, 0x54, 0x68, 0x69, 0x6E, 0x6B, 0x50,
            0x61, 0x64, 0x20, 0x4C, 0x34, 0x39, 0x30, 0x00,
            0x54, 0x68, 0x69, 0x6E, 0x6B, 0x50, 0x61, 0x64,
            0x20, 0x4C, 0x34, 0x39, 0x30, 0x00, 0x00, 0x02,
            0x0F, 0x13, 0x00, 0x01, 0x02, 0x03, 0x04, 0x05,
            0x09, 0x06, 0x00, 0x00, 0x0A, 0x00, 0x4C, 0x45,
            0x4E, 0x4F, 0x56, 0x4F, 0x00, 0x32, 0x30, 0x51,
            0x35, 0x5A, 0x34, 0x50, 0x36, 0x55, 0x53, 0x00,
            0x53, 0x44, 0x4B, 0x30, 0x4A, 0x34, 0x30, 0x36,
            0x39, 0x37, 0x20, 0x57, 0x49, 0x4E, 0x00, 0x4C,
            0x31, 0x48, 0x46, 0x39, 0x33, 0x57, 0x30, 0x30,
            0x31, 0x56, 0x00, 0x4E, 0x6F, 0x74, 0x20, 0x41,
            0x76, 0x61, 0x69, 0x6C, 0x61, 0x62, 0x6C, 0x65,
            0x00, 0x4E, 0x6F, 0x74, 0x20, 0x41, 0x76, 0x61,
            0x69, 0x6C, 0x61, 0x62, 0x6C, 0x65, 0x00, 0x00,
            0x03, 0x16, 0x14, 0x00, 0x01, 0x0A, 0x02, 0x03,
            0x04, 0x02, 0x02, 0x02, 0x02, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4C, 0x45,
            0x4E, 0x4F, 0x56, 0x4F, 0x00, 0x4E, 0x6F, 0x6E,
            0x65, 0x00, 0x50, 0x46, 0x31, 0x4E, 0x4B, 0x4A,
            0x38, 0x56, 0x00, 0x4E, 0x6F, 0x20, 0x41, 0x73,
            0x73, 0x65, 0x74, 0x20, 0x49, 0x6E, 0x66, 0x6F,
            0x72, 0x6D, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00,
            0x4C, 0x45, 0x4E, 0x4F, 0x56, 0x4F, 0x5F, 0x4D,
            0x54, 0x5F, 0x32, 0x30, 0x51, 0x35, 0x5F, 0x42,
            0x55, 0x5F, 0x53, 0x4D, 0x42, 0x5F, 0x46, 0x4D,
            0x5F, 0x54, 0x68, 0x69, 0x6E, 0x6B, 0x50, 0x61,
            0x64, 0x20, 0x4C, 0x34, 0x39, 0x30, 0x00, 0x00,
            0x08, 0x09, 0x15, 0x00, 0x01, 0x00, 0x02, 0x12,
            0x10, 0x4E, 0x6F, 0x74, 0x20, 0x41, 0x76, 0x61,
            0x69, 0x6C, 0x61, 0x62, 0x6C, 0x65, 0x00, 0x55,
            0x53, 0x42, 0x20, 0x31, 0x00, 0x00, 0x08, 0x09,
            0x16, 0x00, 0x01, 0x00, 0x02, 0x12, 0x10, 0x4E,
            0x6F, 0x74, 0x20, 0x41, 0x76, 0x61, 0x69, 0x6C,
            0x61, 0x62, 0x6C, 0x65, 0x00, 0x55, 0x53, 0x42,
            0x20, 0x32, 0x00, 0x00, 0x08, 0x09, 0x17, 0x00,
            0x01, 0x00, 0x02, 0x12, 0x10, 0x4E, 0x6F, 0x74,
            0x20, 0x41, 0x76, 0x61, 0x69, 0x6C, 0x61, 0x62,
            0x6C, 0x65, 0x00, 0x55, 0x53, 0x42, 0x20, 0x33,
            0x00, 0x00, 0x08, 0x09, 0x18, 0x00, 0x01, 0x00,
            0x02, 0x12, 0x10, 0x4E, 0x6F, 0x74, 0x20, 0x41,
            0x76, 0x61, 0x69, 0x6C, 0x61, 0x62, 0x6C, 0x65,
            0x00, 0x55, 0x53, 0x42, 0x20, 0x34, 0x00, 0x00,
            0x7E, 0x09, 0x19, 0x00, 0x01, 0x00, 0x02, 0x12,
            0x10, 0x4E, 0x6F, 0x74, 0x20, 0x41, 0x76, 0x61,
            0x69, 0x6C, 0x61, 0x62, 0x6C, 0x65, 0x00, 0x55,
            0x53, 0x42, 0x20, 0x35, 0x00, 0x00, 0x7E, 0x09,
            0x1A, 0x00, 0x01, 0x00, 0x02, 0x12, 0x10, 0x4E,
            0x6F, 0x74, 0x20, 0x41, 0x76, 0x61, 0x69, 0x6C,
            0x61, 0x62, 0x6C, 0x65, 0x00, 0x55, 0x53, 0x42,
            0x20, 0x36, 0x00, 0x00, 0x7E, 0x09, 0x1B, 0x00,
            0x01, 0x00, 0x02, 0x12, 0x10, 0x4E, 0x6F, 0x74,
            0x20, 0x41, 0x76, 0x61, 0x69, 0x6C, 0x61, 0x62,
            0x6C, 0x65, 0x00, 0x55, 0x53, 0x42, 0x20, 0x37,
            0x00, 0x00, 0x7E, 0x09, 0x1C, 0x00, 0x01, 0x00,
            0x02, 0x12, 0x10, 0x4E, 0x6F, 0x74, 0x20, 0x41,
            0x76, 0x61, 0x69, 0x6C, 0x61, 0x62, 0x6C, 0x65,
            0x00, 0x55, 0x53, 0x42, 0x20, 0x38, 0x00, 0x00,
            0x7E, 0x09, 0x1D, 0x00, 0x01, 0x00, 0x02, 0x12,
            0x10, 0x4E, 0x6F, 0x74, 0x20, 0x41, 0x76, 0x61,
            0x69, 0x6C, 0x61, 0x62, 0x6C, 0x65, 0x00, 0x55,
            0x53, 0x42, 0x20, 0x39, 0x00, 0x00, 0x08, 0x09,
            0x1E, 0x00, 0x01, 0x00, 0x02, 0x0B, 0x1F, 0x4E,
            0x6F, 0x74, 0x20, 0x41, 0x76, 0x61, 0x69, 0x6C,
            0x61, 0x62, 0x6C, 0x65, 0x00, 0x45, 0x74, 0x68,
            0x65, 0x72, 0x6E, 0x65, 0x74, 0x00, 0x00, 0x7E,
            0x09, 0x1F, 0x00, 0x01, 0x00, 0x02, 0x0B, 0x1F,
            0x4E, 0x6F, 0x74, 0x20, 0x41, 0x76, 0x61, 0x69,
            0x6C, 0x61, 0x62, 0x6C, 0x65, 0x00, 0x45, 0x74,
            0x68, 0x65, 0x72, 0x6E, 0x65, 0x74, 0x00, 0x00,
            0x7E, 0x09, 0x20, 0x00, 0x01, 0x00, 0x02, 0x07,
            0x1C, 0x4E, 0x6F, 0x74, 0x20, 0x41, 0x76, 0x61,
            0x69, 0x6C, 0x61, 0x62, 0x6C, 0x65, 0x00, 0x45,
            0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x20,
            0x4D, 0x6F, 0x6E, 0x69, 0x74, 0x6F, 0x72, 0x00,
            0x00, 0x08, 0x09, 0x21, 0x00, 0x01, 0x00, 0x02,
            0xFF, 0x1C, 0x4E, 0x6F, 0x74, 0x20, 0x41, 0x76,
            0x61, 0x69, 0x6C, 0x61, 0x62, 0x6C, 0x65, 0x00,
            0x48, 0x64, 0x6D, 0x69, 0x31, 0x00, 0x00, 0x7E,
            0x09, 0x22, 0x00, 0x01, 0x00, 0x02, 0xFF, 0x1C,
            0x4E, 0x6F, 0x74, 0x20, 0x41, 0x76, 0x61, 0x69,
            0x6C, 0x61, 0x62, 0x6C, 0x65, 0x00, 0x48, 0x64,
            0x6D, 0x69, 0x32, 0x00, 0x00, 0x7E, 0x09, 0x23,
            0x00, 0x01, 0x00, 0x02, 0xFF, 0x1C, 0x4E, 0x6F,
            0x74, 0x20, 0x41, 0x76, 0x61, 0x69, 0x6C, 0x61,
            0x62, 0x6C, 0x65, 0x00, 0x48, 0x64, 0x6D, 0x69,
            0x33, 0x00, 0x00, 0x7E, 0x09, 0x24, 0x00, 0x01,
            0x00, 0x02, 0xFF, 0x1C, 0x4E, 0x6F, 0x74, 0x20,
            0x41, 0x76, 0x61, 0x69, 0x6C, 0x61, 0x62, 0x6C,
            0x65, 0x00, 0x44, 0x69, 0x73, 0x70, 0x6C, 0x61,
            0x79, 0x50, 0x6F, 0x72, 0x74, 0x31, 0x00, 0x00,
            0x7E, 0x09, 0x25, 0x00, 0x01, 0x00, 0x02, 0xFF,
            0x1C, 0x4E, 0x6F, 0x74, 0x20, 0x41, 0x76, 0x61,
            0x69, 0x6C, 0x61, 0x62, 0x6C, 0x65, 0x00, 0x44,
            0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x50, 0x6F,
            0x72, 0x74, 0x32, 0x00, 0x00, 0x08, 0x09, 0x26,
            0x00, 0x01, 0x00, 0x02, 0x1F, 0x1D, 0x4E, 0x6F,
            0x74, 0x20, 0x41, 0x76, 0x61, 0x69, 0x6C, 0x61,
            0x62, 0x6C, 0x65, 0x00, 0x48, 0x65, 0x61, 0x64,
            0x70, 0x68, 0x6F, 0x6E, 0x65, 0x2F, 0x4D, 0x69,
            0x63, 0x72, 0x6F, 0x70, 0x68, 0x6F, 0x6E, 0x65,
            0x20, 0x43, 0x6F, 0x6D, 0x62, 0x6F, 0x20, 0x4A,
            0x61, 0x63, 0x6B, 0x31, 0x00, 0x00, 0x7E, 0x09,
            0x27, 0x00, 0x01, 0x00, 0x02, 0x1F, 0x1D, 0x4E,
            0x6F, 0x74, 0x20, 0x41, 0x76, 0x61, 0x69, 0x6C,
            0x61, 0x62, 0x6C, 0x65, 0x00, 0x48, 0x65, 0x61,
            0x64, 0x70, 0x68, 0x6F, 0x6E, 0x65, 0x2F, 0x4D,
            0x69, 0x63, 0x72, 0x6F, 0x70, 0x68, 0x6F, 0x6E,
            0x65, 0x20, 0x43, 0x6F, 0x6D, 0x62, 0x6F, 0x20,
            0x4A, 0x61, 0x63, 0x6B, 0x32, 0x00, 0x00, 0x09,
            0x11, 0x28, 0x00, 0x01, 0x01, 0x01, 0x03, 0x01,
            0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00,
            0x4D, 0x65, 0x64, 0x69, 0x61, 0x20, 0x43, 0x61,
            0x72, 0x64, 0x20, 0x53, 0x6C, 0x6F, 0x74, 0x00,
            0x00, 0x09, 0x11, 0x29, 0x00, 0x01, 0x01, 0x01,
            0x03, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x53, 0x69, 0x6D, 0x43, 0x61, 0x72,
            0x64, 0x20, 0x53, 0x6C, 0x6F, 0x74, 0x00, 0x00,
            0x0C, 0x05, 0x2A, 0x00, 0x00, 0x00, 0x00, 0x0D,
            0x16, 0x2B, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x01, 0x65, 0x6E, 0x2D,
            0x55, 0x53, 0x00, 0x00, 0x16, 0x1A, 0x2C, 0x00,
            0x01, 0x02, 0x00, 0x00, 0x03, 0x02, 0xDD, 0x11,
            0x5C, 0x2B, 0x04, 0xFF, 0x5C, 0x00, 0x76, 0x4E,
            0x05, 0x0A, 0x00, 0x00, 0x00, 0x00, 0x46, 0x72,
            0x6F, 0x6E, 0x74, 0x00, 0x53, 0x4D, 0x50, 0x00,
            0x30, 0x31, 0x41, 0x56, 0x34, 0x36, 0x35, 0x00,
            0x30, 0x30, 0x2E, 0x30, 0x30, 0x00, 0x4C, 0x69,
            0x50, 0x00, 0x00, 0x7E, 0x1A, 0x2D, 0x00, 0x01,
            0x02, 0x00, 0x00, 0x03, 0x02, 0x00, 0x00, 0x00,
            0x00, 0x04, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x05,
            0x0A, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x8C,
            0x0F, 0x2E, 0x00, 0x4C, 0x45, 0x4E, 0x4F, 0x56,
            0x4F, 0x0B, 0x09, 0x01, 0x01, 0x02, 0x31, 0x2E,
            0x31, 0x35, 0x20, 0x00, 0x31, 0x2E, 0x31, 0x33,
            0x20, 0x00, 0x00, 0x85, 0x05, 0x2F, 0x00, 0x01,
            0x4B, 0x48, 0x4F, 0x49, 0x48, 0x47, 0x49, 0x55,
            0x43, 0x43, 0x48, 0x48, 0x49, 0x49, 0x00, 0x00,
            0x87, 0x13, 0x30, 0x00, 0x54, 0x50, 0x07, 0x02,
            0x42, 0x41, 0x59, 0x20, 0x49, 0x2F, 0x4F, 0x20,
            0x04, 0x00, 0x00, 0x00, 0x00, 0x82, 0x14, 0x31,
            0x00, 0x24, 0x41, 0x4D, 0x54, 0x01, 0x01, 0x01,
            0x01, 0x01, 0xA5, 0xAF, 0x02, 0xC0, 0x00, 0x01,
            0x00, 0x00, 0x00, 0x83, 0x40, 0x32, 0x00, 0x35,
            0x00, 0x00, 0x00, 0x0C, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x0A, 0x00, 0xF8, 0x00, 0x84, 0x9D, 0x00,
            0x00, 0x00, 0x00, 0x09, 0xC0, 0x00, 0x00, 0x00,
            0x00, 0x0C, 0x00, 0x8D, 0x05, 0x20, 0x00, 0x00,
            0x00, 0x00, 0x00, 0xFE, 0x00, 0xBD, 0x15, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x26,
            0x00, 0x00, 0x00, 0x76, 0x50, 0x72, 0x6F, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x18, 0x05, 0x33,
            0x00, 0x22, 0x00, 0x00, 0x84, 0x07, 0x34, 0x00,
            0x01, 0xD8, 0x36, 0x00, 0x00, 0x12, 0x17, 0x35,
            0x00, 0x03, 0x02, 0x02, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00, 0x80,
            0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x15, 0x07,
            0x36, 0x00, 0x05, 0x04, 0x03, 0x00, 0x00, 0x15,
            0x07, 0x37, 0x00, 0x07, 0x04, 0x02, 0x00, 0x00,
            0x83, 0x16, 0x38, 0x00, 0x01, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x54, 0x56,
            0x54, 0x2D, 0x45, 0x6E, 0x61, 0x62, 0x6C, 0x65,
            0x6D, 0x65, 0x6E, 0x74, 0x00, 0x00, 0x88, 0x06,
            0x39, 0x00, 0x5A, 0x5A, 0x00, 0x00, 0x0F, 0x1F,
            0x3A, 0x00, 0x72, 0x02, 0x00, 0x00, 0x10, 0x00,
            0x04, 0x01, 0x26, 0x00, 0x00, 0x00, 0xF0, 0x00,
            0x00, 0x00, 0x01, 0x04, 0x02, 0x08, 0x04, 0x0A,
            0x00, 0x14, 0x00, 0x16, 0x00, 0x00, 0x00, 0x8C,
            0x0F, 0x3B, 0x00, 0x4C, 0x45, 0x4E, 0x4F, 0x56,
            0x4F, 0x0B, 0x07, 0x01, 0x01, 0x02, 0x52, 0x30,
            0x5A, 0x48, 0x54, 0x33, 0x33, 0x57, 0x00, 0x31,
            0x35, 0x2F, 0x30, 0x39, 0x2F, 0x32, 0x30, 0x31,
            0x39, 0x00, 0x00, 0x0E, 0x08, 0x3C, 0x00, 0x01,
            0xDB, 0x00, 0x00, 0x24, 0x4D, 0x45, 0x49, 0x00,
            0x00, 0xDB, 0x6A, 0x3D, 0x00, 0x01, 0x04, 0x01,
            0x45, 0x02, 0x00, 0xA0, 0x06, 0x81, 0x10, 0x80,
            0x30, 0x00, 0x00, 0x00, 0x00, 0x40, 0x00, 0x00,
            0x01, 0x1F, 0x00, 0x00, 0xC9, 0x0A, 0x40, 0x44,
            0x02, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
            0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
            0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
            0xFF, 0x03, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x4D, 0x45, 0x49, 0x31, 0x00,
            0x4D, 0x45, 0x49, 0x32, 0x00, 0x4D, 0x45, 0x49,
            0x33, 0x00, 0x4D, 0x45, 0x49, 0x34, 0x00, 0x00,
            0x87, 0x12, 0x3E, 0x00, 0x54, 0x50, 0x07, 0x01,
            0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x7F, 0x04, 0xFF, 0xFE,
            0x00, 0x00
        };

        static void Main(string[] args)
        {
            DmiStructureCollection structures = DMI.CreateInstance().Structures;

            // type 0
            string biosVersion = GetSmbiosProperty(structures, DmiProperty.Bios.BiosVersion);
        }

        private static string GetSmbiosProperty(DmiStructureCollection structure, IPropertyKey key)
        {
            QueryPropertyResult queryResult = structure.GetProperty(key);
            if (!queryResult.Success)
            {
                return null;
            }

            return queryResult.Value.Value.ToString();
        }
    }
}
