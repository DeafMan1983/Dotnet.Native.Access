using System;

namespace Native.Access
{
    public interface IPointer
    {
        IntPtr ToSize();
    }

    public class Pointer : IPointer
    {
        private readonly IntPtr value;

        public Pointer(IntPtr value)
        {
            this.value = value;
        }

        public IntPtr ToSize()
        {
            return (IntPtr)4;
        }

        public new string ToString()
        {
            return "Pointer is " + value.ToInt64() + ".";
        }
    }
}