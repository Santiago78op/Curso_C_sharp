using Person;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de la clase Persona
            Persona persona = new Persona(30,1,70.5,"Juan");
            persona.Nombre = "Pepe";
            persona.Edad = 32;

            // Mostrar los datos de la persona
            Console.WriteLine("Nombre: " + persona.Nombre);
            Console.WriteLine("Edad: " + persona.Edad);
            
            // Crear un objeto de la clase Doctor
            Doctor doctor = new Doctor(40,2,80.5,"Maria","Cardiología",1234);
            
            // Mostrar los datos del doctor
            Console.WriteLine(doctor.getDatos());
            Console.WriteLine("Especialidad: " + doctor.Especialidad);
            Console.WriteLine("Número de colegiado: " + doctor.NumColegiado);
        }
        
    }
}

