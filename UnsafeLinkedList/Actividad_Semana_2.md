# Clase Persona

Se requiere una clase Persona que tenga los siguientes atributos:
* Id
* Nombres
* Apellidos
* Correo
* Contrasenia

Codigo de la clase Persona:

```csharp 
namespace UnsafeLinkedList.Persona;

public unsafe class Person
{
    private int _id;
    private String _nombre;
    private String _apellido;
    private String _correo;
    private String _contrasenia;

    public Person(int id, string nombre, string apellido, string correo, string contrasenia)
    {
        _id = id;
        _nombre = nombre;
        _apellido = apellido;
        _correo = correo;
        _contrasenia = contrasenia;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Nombre
    {
        get => _nombre;
        set => _nombre = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Apellido  
    {
        get => _apellido;
        set => _apellido = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Correo
    {
        get => _correo;
        set => _correo = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Contrasenia
    {
        get => _contrasenia;
        set => _contrasenia = value ?? throw new ArgumentNullException(nameof(value));
    }

    public override string ToString()
    {
        return $"Id: {_id}, Nombre: {_nombre}, Apellido: {_apellido}, Correo: {_correo}, Contrasenia: {_contrasenia}";
    }
}
```

# Clase Nodo

Se requiere una clase Nodo que tenga los siguientes atributos:

* Dato
* Siguiente

Codigo de la clase Nodo:

```csharp
using UnsafeLinkedList.Persona;

namespace UnsafeLinkedList.Nodo;

// Definicion del nodo de una lista enlazada simple
public unsafe class Node
{
    // Dato almacenado en el nodo
    private Person _data;
    // Puntero al siguiente nodo
    private Node* _next;

    // Constructor
    public Node(Person data)
    {
        _data = data;
        _next = null;
    }

    // Propiedad para acceder al dato almacenado en el nodo
    public Person Data
    {
        get => _data;
        set => _data = value;
    }

    // Propiedad para acceder al siguiente nodo
    public Node* Next
    {
        get => _next;
        set => _next = value;
    }
}
```

# Clase ListaEnlazada

Se requiere una clase ListaEnlazada que tenga los siguientes atributos:

* NodoInicio
* NodoFin
* Cantidad

Codigo de la clase ListaEnlazada:

```csharp
using System.Runtime.InteropServices;
using UnsafeLinkedList.Nodo;
using UnsafeLinkedList.Persona;

namespace UnsafeLinkedList.ListaSimple;

public unsafe class LinkedList
{
    private Node* _head;
    private Node* _tail;
    int length;
    
    /**
     * Constructor de la lista enlazada
     * @param persona Dato a almacenar en el nodo
     */
    public LinkedList(Person persona)
    {   
        /* Se reserva memoria para el nuevo nodo */
        Node* newNode = (Node*)Marshal.AllocHGlobal(sizeof(Node)); 
        
        /* Se asigna el dato al nuevo nodo */
        *newNode = new Node(persona);
        newNode->Next = null;
        
        _head = newNode; // El primer nodo es el nuevo nodo
        _tail = newNode; // El ultimo nodo es el nuevo nodo
        length = 1;      // La lista tiene un solo nodo
    }
    
    /**
     * Destructor de la lista enlazada, para liberar la memoria reservada
     */
    public void Deconstruct()
    {
       Node* temp = _head;
       while (_head != null)
       {
           _head = _head->Next;
           // Se libera la memoria reservada para el nodo
           Marshal.FreeHGlobal((IntPtr)temp);
           temp = _head;
       }
    }

    public Node* Head
    {
        get => _head;
        set => _head = value;
    }

    public Node* Tail
    {
        get => _tail;
        set => _tail = value;
    }

    public int Length
    {
        get => length;
        set => length = value;
    }
    
    /**
     * Metodo para agregar un nuevo nodo al final de la lista
     * @param persona Dato a almacenar en el nodo
     */
    public void append(Person persona)
    {
        // Agregar un nuevo nodo al final de la lista
        Node* newNode = (Node*)Marshal.AllocHGlobal(sizeof(Node));
        
        // Se asigna el dato al nuevo nodo
        *newNode = new Node(persona);
        newNode->Next = null;
        
        // Se asigna el dato al nuevo nodo
        if( length == 0 )
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            // Se asigna el puntero al siguiente nodo
            _tail->Next = newNode;
            _tail = newNode;
        }

        length++;
    }
    
    /**
     * Metodo para imprimir la lista
     */
    public void printList()
    {
        Node* temp = _head;

        if (temp == null)
        {
            Console.WriteLine("La lista esta vacia");
        }
        else
        {
            while (temp != null)
            {
                Console.WriteLine("Persona: " + temp->Data.ToString());
                temp = temp->Next;
            }
        }
    }

    /**
     * Metodo para eliminar un nodo de la lista
     * @param id Identificador de la persona a eliminar
     */
    public void delete(int id)
    {
        Node* temp = _head;
        Node* prev = null;
        while (temp != null)
        {
            if (temp->Data.Id == id)
            {
                if (prev == null)
                {
                    _head = temp->Next;
                }
                else
                {
                    prev->Next = temp->Next;
                }
                length--;
                Marshal.FreeHGlobal((IntPtr)temp);
                return;
            }
            prev = temp;
            temp = temp->Next;
        }
    }
}
```

# Clase Program

Codigo de la clase Program:

```csharp

using UnsafeLinkedList.ListaSimple;
using UnsafeLinkedList.Persona;

namespace UnsafeLinkedList
{
    class Program  
    {
        static unsafe void Main(string[] args)
        {
            // Crear una persona -> Estudiante
            Person estudiante_1 = new Person(205807816, "Emilio", "Hernandez", "emilHer27@user.com", "123456");
            Person estudiante_2 = new Person(202107859, "Emerson", "Cordoba", "emrCor48@htomal.com", "123456");
            Person estudiante_3 = new Person(205863815, "Nicol", "Marques", "nicoMa89@gmuikl.com", "123456");
            Person estudiante_4 = new Person(215146889, "Ramiro", "Leon", "RemiL78@nimi.com", "123456");
            Person estudiante_5 = new Person(124863567, "Enio", "Vasquez", "EnVa20@yahoo.com", "123456");
            
            // Crear una lista enlazada
            LinkedList lista = new LinkedList(estudiante_1);
            
            // Agregar estudiantes a la lista
            lista.append(estudiante_2);
            lista.append(estudiante_3);
            lista.append(estudiante_4);
            lista.append(estudiante_5);
            
            // Imprimir la lista
            lista.printList();
            
            // Eliminar un estudiante de la lista, Estudiante_3 Nicol Nicol
            lista.delete(205863815);
            
            // Impreme nueva seccion 
            Console.WriteLine( "\n" + "Lista despues de eliminar un estudiante" + "\n");
            
            // Imprimir la lista
            lista.printList();
        }
    }
}
```

# Imagenes del Programa en Consola

Se insertaron 5 estudiantes a la lista y se elimino el estudiante con id 205863815, nombre Nocol.

![Lista](img/Consola.png)
