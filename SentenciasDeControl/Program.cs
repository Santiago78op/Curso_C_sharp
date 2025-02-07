
namespace SentenciasDeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            // If
            int age = 30;
            if (age >= 18)
            {
                System.Console.WriteLine("You are an adult");
            }
            
            // If-else
            int age2 = 15;
            if (age2 >= 18)
            {
                System.Console.WriteLine("You are an adult");
            }
            else
            {
                System.Console.WriteLine("You are a minor");
            }
            
            // If-else if-else
            int age3 = 65;
            if (age3 >= 65)
            {
                System.Console.WriteLine("You are a senior");
            }
            else if (age3 >= 18)
            {
                System.Console.WriteLine("You are an adult");
            }
            else
            {
                System.Console.WriteLine("You are a minor");
            }
            
            // Switch
            int day = 3;
            switch (day)
            {
                case 1:
                    System.Console.WriteLine("Monday");
                    break;
                case 2:
                    System.Console.WriteLine("Tuesday");
                    break;
                case 3:
                    System.Console.WriteLine("Wednesday");
                    break;
                case 4:
                    System.Console.WriteLine("Thursday");
                    break;
                case 5:
                    System.Console.WriteLine("Friday");
                    break;
                case 6:
                    System.Console.WriteLine("Saturday");
                    break;
                case 7:
                    System.Console.WriteLine("Sunday");
                    break;
                default:
                    System.Console.WriteLine("Invalid day");
                    break;
            }
            
            // While
            int i = 0;
            while (i < 5)
            {
                System.Console.WriteLine(i);
                i++;
            }
            
            // Do-while
            int j = 0;
            do
            {
                System.Console.WriteLine(j);
                j++;
            } while (j < 5);
            
            // For
            for (int k = 0; k < 5; k++)
            {
                System.Console.WriteLine(k);
            }
            
            // Foreach
            string[] names = { "John", "Mary", "Bob" };
            foreach (string name in names)
            {
                System.Console.WriteLine(name);
            }
            
            // Arreglos
            // Tipos de Arreglos
            // Unidimensional
            int[] numbers = { 1, 2, 3, 4, 5 };
            // Multidimensional
            int[,] matrix = new int[2, 2];
            matrix[0, 0] = 1;
            
            // Arreglos de Cadenas
            string[] names2 = { "John", "Mary", "Bob" };
            foreach (string name in names2)
            {
                System.Console.WriteLine(name);
            }
        }
    }
}