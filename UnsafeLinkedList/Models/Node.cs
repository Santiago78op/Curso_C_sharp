namespace UnsafeLinkedList.Models;

/**
 * Definicion del nodo de una lista enlazada simple
 */
public unsafe class Node<T> where T : class
{
    // Dato almacenado en el nodo
    public T _data;
    // Puntero al siguiente nodo
    public Node<T>* _next;

    /**
     * Constructor del nodo
     * @param data Dato a almacenar en el nodo
     */
    public Node(T data)
    {
        _data = data;
        _next = null;
    }
}