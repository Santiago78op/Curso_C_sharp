using System.Runtime.InteropServices;
using UnsafeLinkedList.Interfaces;

namespace UnsafeLinkedList.Models;

/**
 * Clase que define una lista enlazada simple
 */
public unsafe class Linked_List<T> : ILinkedList<T>, IDisposable where T : class
{
    private Node<T>* _head;
    private Node<T>* _tail;
    int length;

    /**
     * Constructor de la lista enlazada
     * @param persona Dato a almacenar en el nodo
     */
    public Linked_List(T estudiante)
    {   
        /* Se reserva memoria para el nuevo nodo */
        Node<T>* newNode = (Node<T>*)Marshal.AllocHGlobal(sizeof(Node<T>));
        if (newNode == null)
        {
            throw new OutOfMemoryException("No se pudo reservar memoria para el nuevo nodo");
        }
            
        /* Se asigna el dato al nuevo nodo */
        *newNode = new Node<T>(estudiante);
        newNode->_next = null;
            
        _head = newNode; // El primer nodo es el nuevo nodo
        _tail = newNode; // El ultimo nodo es el nuevo nodo
        length = 1;      // La lista tiene un solo nodo
    }
    
    /**
     * Metodo para agregar un nuevo nodo al final de la lista
     * @param persona Dato a almacenar en el nodo
     */
    public void append(T persona)
    {
        // Agregar un nuevo nodo al final de la lista
        Node<T>* newNode = (Node<T>*)Marshal.AllocHGlobal(sizeof(Node<T>));
            
        // Se asigna el dato al nuevo nodo
        *newNode = new Node<T>(persona);
        newNode->_next = null;
            
        // Se asigna el dato al nuevo nodo
        if( length == 0 )
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            // Se asigna el puntero al siguiente nodo
            _tail->_next = newNode;
            _tail = newNode;
        }

        length++;
    }
    
    /**
   * Metodo para eliminar un nodo de la lista
   * @param id Identificador de la persona a eliminar
   */
    public void remove(int id)
    {
        Node<T>* temp = _head;
        Node<T>* prev = null;
        while (temp != null)
        {
            if (temp->_data is Estudiante estudiante && estudiante.Id == id)
            {
                if (prev == null)
                {
                    _head = temp->_next;
                }
                else
                {
                    prev->_next = temp->_next;
                }
                length--;
                Marshal.FreeHGlobal((IntPtr)temp);
                return;
            }
            prev = temp;
            temp = temp->_next;
        }
    }
    
    /**
     * Metodo para imprimir la lista
     */
    public void printList()
    {
        Node<T>* temp = _head;

        if (temp == null)
        {
            Console.WriteLine("La lista esta vacia");
        }
        else
        {
            while (temp != null)
            {
                Console.WriteLine("Persona: " + temp->_data.ToString());
                temp = temp->_next;
            }
        }
    }
    
    /**
     * Metodo Dispose para liberar la memoria de la lista enlazada
     * Se libera la memoria de cada nodo de la lista
     * Se asigna null a la cabeza de la lista
     * Se suprime la finalizacion del objeto
     * Se invoca al recolector de basura
     */
    public void Dispose()
    {
        Node<T>* temp = _head;
        while (temp != null)
        {
            Node<T>* next = temp->_next;
            Marshal.FreeHGlobal((IntPtr)temp);
            temp = next;
        }
        
        _head = null;
        
        GC.SuppressFinalize(this);
    }
    
    /**
     * Destructor de la lista enlazada
     */
    ~Linked_List()
    {
        Dispose();
    }

}