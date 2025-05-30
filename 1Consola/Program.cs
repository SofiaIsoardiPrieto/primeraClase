namespace _1Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 6;
            int numero2 = 6;
            int resulatado = 0;
            char caracter='k';
            bool booleano = true;
            double numero= 33.2;


            Console.Write("Ingrese primer numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese segundo numero");
            numero2 = int.Parse(Console.ReadLine());
            numero = double.Parse(Console.ReadLine());

            //resulatado = numero1 + numero2;
            //resulatado = numero1 - numero2;

            if (numero2 == 0)
            {
                Console.WriteLine("No se puede dividr por 0, por defecto queda en 1");
                numero2 = 1;

            }
            resulatado = numero1 / numero2;
            Console.WriteLine($"El resultado es: {resulatado}");


            numero1 = 1;
            do
            {
                numero1 = numero1 + 1;
                Console.WriteLine($"El resultado es: {numero1}");

            } while (numero1 < 10);

            for (int i = 0; i < 10; i++)
            {
                numero1 = numero1 + 1;
                Console.WriteLine($"El resultado es: {numero1}");
            }


            numero1 = 0;
            numero1 = int.Parse(Console.ReadLine());
            switch (numero1)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }

        }
    }
}
