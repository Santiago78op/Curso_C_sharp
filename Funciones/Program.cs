
namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
           // Tipos de funciones
           // Funciones que no retornan valores
           Saludar();
           // Funciones que retornan valores
           System.Console.WriteLine(Sumar(5, 3));
           // Funciones que reciben parámetros
           SaludarA("Juan");
           // Funciones que reciben parámetros y retornan valores
           System.Console.WriteLine(SaludarA2("Pedro"));
        }
        
        // Funciones que no retornan valores
        static void Saludar()
        {
            System.Console.WriteLine("Hola");
        }
        
        // Funciones que retornan valores
        static int Sumar(int a, int b)
        {
            return a + b;
        }
        
        // Funciones que reciben parámetros
        static void SaludarA(string nombre)
        {
            System.Console.WriteLine("Hola " + nombre);
        }
        
        // Funciones que reciben parámetros y retornan valores
        static string SaludarA2(string nombre)
        {
            return "Hola " + nombre;
        }
    }
}

