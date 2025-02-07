﻿namespace UnsafeLinkedList.Interfaces;

/**
 * Interfaz que define los métodos que debe tener una lista enlazada
 */
public interface ILinkedList<T> where T : class
{
    void append(T data); // Agrega un nodo al final de la lista
    void remove(int id); // Elimina un nodo de la lista
    void printList(); // Imprime la lista
}