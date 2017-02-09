using System;
using System.Runtime.InteropServices;

namespace ClockSync_Receiver
{
    /// <summary>
    /// Get or set system time using coredll.dll
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEMTIME
    {
        //Define the structure of SYSTEMTIME
        public short wYear;
        public short wMonth;
        public short wDayOfWeek;
        public short wDay;
        public short wHour;
        public short wMinute;
        public short wSecond;
        public short wMilliseconds;

        [DllImport("kernel32.dll", SetLastError = true)]
        private extern static void GetSystemTime(ref SYSTEMTIME lpSystemTime);

        [DllImport("kernel32.dll", SetLastError = true)]
        private extern static uint SetSystemTime(ref SYSTEMTIME lpSystemTime);

        /// <summary>
        /// Set new system time from a <see cref="DateTime"/> instance
        /// </summary>
        /// <param name="dt">The <see cref="DateTime"/> instance to set the valuer.</param>
        public static void Set(DateTime dt)
        {
            // Call the native GetSystemTime method 
            // with the defined structure.
            SYSTEMTIME stime = new SYSTEMTIME();
            stime.wYear = (short)dt.Year;
            stime.wMonth = (short)dt.Month;
            stime.wDay = (short)dt.Day;
            stime.wHour = (short)dt.Hour;
            stime.wMinute = (short)dt.Minute;
            stime.wSecond = (short)dt.Second;
            stime.wMilliseconds = (short)dt.Millisecond;

            SetSystemTime(ref stime);
        }

        /// <summary>
        /// Get current system time in a new <see cref="DateTime"/> instance.
        /// </summary>
        /// <returns>The <see cref="DateTime"/> instance that contains current system time.</returns>
        public static DateTime Get()
        {
            SYSTEMTIME stime = new SYSTEMTIME();
            GetSystemTime(ref stime);
            return new DateTime(stime.wYear, stime.wMonth, stime.wDay, stime.wHour, stime.wMinute, stime.wSecond, stime.wMilliseconds);
        }
    }
}
