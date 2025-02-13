﻿using System;

namespace ProcMemScan.Interop
{
    using NTSTATUS = Int32;

    internal class Win32Consts
    {
        public const NTSTATUS STATUS_SUCCESS = 0;
        public static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);
        public const int ERROR_INSUFFICIENT_BUFFER = 0x7A;
        public const int MAX_PATH = 260;
        public const uint MAX_SYM_NAME = 2000;
    }
}
