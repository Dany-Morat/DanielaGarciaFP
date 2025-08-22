using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
namespace _8.TallerCondicionales

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Variable1=0;
            int Variable2=0;
            int Variable3 = 0;
            int mayor = 0;
            int medio = 0;
            int menor = 0;



            Console.Write("Ingrese su numero 1:");
            Variable1 = Int32.Parse(Console.ReadLine());
            
            Console.Write("Ingrese su numero 2:");
            Variable2 = Int32.Parse(Console.ReadLine());
        
            Console.Write("Ingrese su numero 3:");
            Variable3 = Int32.Parse(Console.ReadLine());

            mayor = Variable1 > Variable2
           ? (Variable1 > Variable3 ? Variable1 : Variable3)
           : (Variable2 > Variable3 ? Variable2 : Variable3);

            Console.WriteLine($"El numero mayor es: {mayor}");

            if (Variable1 == Variable2 || Variable2 == Variable3 || Variable3 == Variable1)
            {
                Console.WriteLine("EROR NO SE PUEDEN IGUALES");

            }

            






        }
    }
}
