namespace _1Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declaro una variable (reservo espacio en memoria para guardar un dato):
            int numero1;
            // Inicializo la variable (le asigno un valor inicial):
            numero1 = 5;
            // Declaro e inicializo una variable en una sola linea:
            int numero2 = 6;
            //Variable de tipo double (número con decimales):
            double numeroDecimal = 33.2;
            // Variable que guarda un solo caracter:
            char caracter = 'k';
            // Variable que guarda un texto (cadena de caracteres):
            string CadenaCarateres = "Hola Mundo";
            // Variable booleana (verdadero o falso):
            bool booleano = true;

            // Para mostrar un mensaje por consola:
            Console.Write("Ingrese primer numero: ");
            // Para leer un dato ingresado por consola y convertirlo a entero:
            numero1 = int.Parse(Console.ReadLine());
            // Otro ejemlo de lectura de dato ingresado por consola:
            Console.WriteLine("Ingrese segundo numero");
            numero2 = int.Parse(Console.ReadLine());
            // Si tengo una variable de tipo double, puedo usar Parse para convertir un string a double:
            numeroDecimal = double.Parse(Console.ReadLine());
            // Si tengo una variable de tipo string, no necesito Parsear:
            CadenaCarateres = (Console.ReadLine());
            // Si tengo una variable de tipo char, puedo usar Parse para convertir un string a char (debe ser un solo caracter):
            caracter = char.Parse(Console.ReadLine());

            // Puedo inicializar y asignar el valor de la suma de las dos variables:
            int resultado = numero1 + numero2;
            // Puedo restar:
            resultado = numero1 - numero2;
            // Puedo multiplicar:
            resultado = numero1 * numero2;
            // Puedo dividir:
            resultado = numero1 / numero2;

            //Uso del condicional if para validar si el segundo numero es 0 antes de dividir:
            if (numero2 == 0)
            {
                Console.WriteLine("No se puede dividr por 0, por defecto queda en 1");
                numero2 = 1;

            }
            resultado = numero1 / numero2;
            Console.WriteLine($"El resultado es: {resultado}");

            // Uso un buble while para incrementar el valor de numero1 hasta que sea menor a 10:
            numero1 = 1;
            do
            {
                numero1 = numero1 + 1;
                Console.WriteLine($"El resultado es: {numero1}");

            } while (numero1 < 10);

            // Uso un buble for para incrementar el valor de numero1 10 veces:
            for (int i = 0; i < 10; i++)
            {
                numero1 = numero1 + 1;
                Console.WriteLine($"El resultado es: {numero1}");
            }

            // El usuario ingresa un numero  y se muestra a que dia corresponde gracias a un switch,
            // el default me permite manejar excepciones:
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
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

        }
    }
}
