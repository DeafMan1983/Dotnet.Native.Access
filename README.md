# Dotnet.Native.Access
Native.Access for DotNet 3.1 , It is successor of Java.Native.Access ( JNA ) for C#

You just create simple test for C#
![Show your code](https://raw.githubusercontent.com/DeafMan1983/Dotnet.Native.Access/master/showyourcode.png)

Result:
NativeLong is 8.
Pointer is 8,
PointerType is 4.

## Note for Windows Users:
If all are "4" then it means "hWnd" is 4 size of int.

## Note for structure of "typedef struct" or "typedef uint32_t" from C/C++ should be NativeLong
Example with SDL2-CS ( @flibitijibibo )
```
public class SDL_Window : NativeLong
{
    public SDL_Window(long value) : base(value)
    {
    }

    // ... stuff for SDL_Window for width, height, x, y, id or etc..
}

class SDL_Program
{
    private SDL_Window window;

    // ...

    public void Run()
    {
        // ...

        window = SDL_CreateWindow("Hello Window", 100, 100, 200, 200, 0);

        // ...
    }
}
```
## Pointer / PointerType are from "typedef struct*" like Display* from X11 or SDL_Window* but whatever you want decide 3 different type of alternative to IntPtr.

Enjoy and happy coding!
