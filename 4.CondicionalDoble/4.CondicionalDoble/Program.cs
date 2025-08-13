namespace _4.CondicionalDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el sueldo");
            sueldo = Int32.Parse(Console.ReadLine());

            if(sueldo>=3000) 
            {
                //verdadera

                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }
            else 
            {
                //falsa

                Console.WriteLine($"La persona {nombre}, no abona impuestos");

            }*/

            /*Console.Write("Ingrese el nombre de la persona: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el sueldo de la persona: ");
            int sueldo;

            Console.WriteLine("Ingrese el sueldo");
            sueldo = Int32.Parse(Console.ReadLine());

    
                if (sueldo > 3000)
                {
                    Console.WriteLine($"{nombre} debe abonar impuestos.");
                }
                else
                {
                    Console.WriteLine("Persona exenta de impuestos.");


                }*/

            Console.Write("Ingrese su edad: ");
            int edad;

            edad = Int32.Parse(Console.ReadLine());
            
                if (edad >= 18)
                {
                    Console.WriteLine("Bienvenido a mi sitio Web.");
                }
                else
                {
                    Console.WriteLine("No es apto para el contenido de este sitio web.");
                }
            



        }
    }
}
