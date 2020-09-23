using System;
using System.Runtime.InteropServices;

namespace Native.Access
{
    public interface IPointertype
    {
        Pointer ToPointer();
    }

    public class PointerType : IPointertype
    {
        private readonly Pointer ptr;

        public PointerType(Pointer ptr)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                this.ptr = ptr ?? new Pointer(IntPtr.Zero);
            }
            else
            {
                this.ptr = ptr;
            }
        }

        public Pointer ToPointer()
        {
            return ptr;
        }

        public new string ToString()
        {
            return "PointerType is " + ptr.ToSize().ToInt64() + ".";
        }
    }
}
