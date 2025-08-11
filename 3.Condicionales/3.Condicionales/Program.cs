namespace _3.Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONDICIONAL SIMPLE
            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();//todo lo q yo leo desde la consola llega aca como string
            Console.WriteLine(nombre);
            Console.WriteLine("Ingrese sueldo");
            sueldo = Convert.ToInt32(Console.ReadLine());

            if (sueldo > 3000) 
            {
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            
            }
        
        }
    }
}
