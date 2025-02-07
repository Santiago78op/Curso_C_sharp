using System.Runtime.InteropServices;

namespace UnsafeLinkedList.Services;

/**
 * Clase que se encarga de la gestion de memoria
 */
public class MemoryManager
{
    public static unsafe T* AllocateMemory<T>() where T : unmanaged
    {
        T* ptr = (T*)Marshal.AllocHGlobal(sizeof(T));
        if (ptr == null)
        {
            throw new OutOfMemoryException("No se pudo reservar memoria para el nuevo nodo");
        }

        return ptr;
    }
    
    public static unsafe void FreeMemory<T>(T* ptr) where T : unmanaged
    {
        if (ptr != null)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
    }
}