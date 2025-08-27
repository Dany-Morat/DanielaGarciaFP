namespace _9.ParcialCondicionalesDanielaGarciaMorat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int sala = 0;
            string juego = "";
            int precio = 0;

            
            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

          
            Console.WriteLine("Salas disponibles:");
            if (edad >= 1 && edad <= 5)
            {
                Console.WriteLine("Sala 1");
            }
            else if (edad >= 6 && edad <= 16)
            {
                Console.WriteLine("Sala 2");
            }
            else if (edad >= 17 && edad <= 25)
            {
                Console.WriteLine("Sala 3");
                Console.WriteLine("Sala 4");
            }
            else if (edad >= 26)
            {
                Console.WriteLine("Sala 5");
            }
          
            Console.Write("Seleccione la sala: ");
            sala = int.Parse(Console.ReadLine());

          
            Console.WriteLine("Juegos disponibles:");
            if (sala == 1)
            {
                Console.WriteLine("Juego1");
                Console.WriteLine("Juego5");
            }
            else if (sala == 2)
            {
                Console.WriteLine("Juego3");
                Console.WriteLine("Juego6");
            }
            else if (sala == 3)
            {
                Console.WriteLine("Juego2");
                Console.WriteLine("Juego7");
            }
            else if (sala == 4)
            {
                Console.WriteLine("Juego4");
                Console.WriteLine("Juego8");
            }
            else if (sala == 5)
            {
                Console.WriteLine("Juego9");
                Console.WriteLine("Juego10");
            }
           
            Console.Write("Seleccione el juego: ");
            juego = Console.ReadLine();

           
            if (juego == "1" || juego == "10")
            {
                precio = 3000;
            }
            else if (juego == "2" || juego == "9")
            {
                precio = 5000;
            }
            else if (juego == "3" || juego == "5" || juego == "8")
            {
                precio = 7000;
            }
            else if (juego == "4" || juego == "6")
            {
                precio = 9000;
            }
            else if (juego == "7")
            {
                precio = 10000;
            }
          
            Console.WriteLine("RESUMEN");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Sala: {sala}");
            Console.WriteLine($"Juego: {juego}");
            Console.WriteLine($"Precio: {precio}");
        }
    }


}

