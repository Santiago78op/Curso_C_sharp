
using System;
using UnsafeLinkedList.Models;

namespace UnsafeLinkedList
{
    class Program  
    {
        static unsafe void Main(string[] args)
        {
            
            // Crear una persona -> Estudiante
            Estudiante estudiante_1 = new Estudiante(205807816, "Emilio", "Hernandez", "emilHer27@user.com", "123456");
            Estudiante estudiante_2 = new Estudiante(202107859, "Emerson", "Cordoba", "emrCor48@htomal.com", "123456");
            Estudiante estudiante_3 = new Estudiante(205863815, "Nicol", "Marques", "nicoMa89@gmuikl.com", "123456");
            Estudiante estudiante_4 = new Estudiante(215146889, "Ramiro", "Leon", "RemiL78@nimi.com", "123456");
            Estudiante estudiante_5 = new Estudiante(124863567, "Enio", "Vasquez", "EnVa20@yahoo.com", "123456");
            
            using (Linked_List<Estudiante> lista = new Linked_List<Estudiante>(estudiante_1))
            {
                lista.append(estudiante_2);
                lista.append(estudiante_3);
                lista.append(estudiante_4);
                lista.append(estudiante_5);
                
                lista.printList();
                
                Console.WriteLine("\n" + "Eliminar estudiante 202107859" + "\n");
                
                lista.remove(202107859);
                
                lista.printList();
            }
            
            Console.WriteLine("\n" + "Lista liberada" + "\n");
        }
    }
}
