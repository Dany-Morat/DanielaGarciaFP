namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int acumulador = 0;

            while (contador <=5)
            {
                acumulador += contador;
                Console.WriteLine($"C: {contador}-A: {acumulador}");
                contador++; 
            }
            Console.WriteLine($"La suma de los cinco primeros numeros eneteros es: {acumulador}");


        }
    }
}
