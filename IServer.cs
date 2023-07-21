using System;
using System.Runtime.InteropServices;

[ComVisible(true)]
[Guid("60AB5838-13DD-4D5A-A976-A6324CFE0D49")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IServer
{
    /// <summary>
    /// Compute the value of the constant Pi.
    /// </summary>
    double ComputePi();
}