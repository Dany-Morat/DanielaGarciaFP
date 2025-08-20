namespace _6.CondicioalMultipleTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Condicional Multiple

            float valorCompra = 0;
            float descuento = 0;
            char dia = ' ';

            Console.WriteLine("Ingrese el valor de la compra:");
            valorCompra = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el dia de la semana: L:Lunes, M:Martes, X:Miercoles, J:Jueves, V:Viernes, S: Sabado, D: Domigo");
            dia = Convert.ToChar(Console.ReadLine());

            switch (dia)
            {
                case 'L':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es lunes, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;

                case 'M':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es Martes, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;

                case 'X':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es Miercoles, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;

                case 'J':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es Jueves, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;

                case 'V':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es Viernes, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;

                case 'S':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es Sabado, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;

                case 'D':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es Domingo, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;

                    /*Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas
                     * entre dos números ingresados por el usuario. Las operaciones disponibles serán: suma, resta, 
                     * multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario.*/

            float numero1 = 0;
            float numero2 = 0;
            float resultado = 0;
            char operacion = ' ';

            Console.WriteLine("Ingrese el primer número:");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione la operación a realizar:");
            Console.WriteLine("S: Suma");
            Console.WriteLine("R: Resta");
            Console.WriteLine("M: Multiplicación");
            Console.WriteLine("D: División");
            operacion = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (operacion)
            {
                case 'S':
                    resultado = numero1 + numero2;
                    Console.WriteLine($"La suma de {numero1} + {numero2} es: {resultado}");
                    break;

                case 'R':
                    resultado = numero1 - numero2;
                    Console.WriteLine($"La resta de {numero1} - {numero2} es: {resultado}");
                    break;

                case 'M':
                    resultado = numero1 * numero2;
                    Console.WriteLine($"La multiplicación de {numero1} * {numero2} es: {resultado}");
                    break;

                case 'D':
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"La división de {numero1} / {numero2} es: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    }
                    break;

                default:
                    Console.WriteLine("Operación inválida.");
                    break;
            }
        }
    }
}
