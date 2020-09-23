using System;
using System.Runtime.InteropServices;

namespace Native.Access
{ 
    public interface INativeLong
    {
        long ToNative();
    }

    public class NativeLong : INativeLong
    {
        private readonly long value;

        public NativeLong(long value)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // IntPtr.Size = 4
                this.value = (int)value;
            }
            else
            {
                // IntPtr.Size = 8
                this.value = IntPtr.Size == 8 ? value : (int)value;
            }
        }

        public long ToNative()
        {
            return IntPtr.Size == 8 ? value : (int)value;
        }
    }
}