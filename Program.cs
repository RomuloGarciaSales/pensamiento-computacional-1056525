Console.WriteLine("PROGRAMA PARA CONVERSIÓN DE TEMPERATURA");
int opcion;
    do
    {
        MostrarMenu();
         Console.Write("Ingresar opción solicitada:");

        if (int.TryParse(Console.ReadLine(), out opcion))
        {
            switch (opcion)
            {
                case 1:
                    CelciusAFahrenheit();
                    break;
                case 2:
                    FahrenheitACelcius();
                    break;
                case 3:
                    MostrarInformacionProgramador();
                    break;
                case 4:
                    Console.WriteLine("El programa se cerró");
                    break;
                default:
                    Console.WriteLine("Seleccione una opción valida.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número del menú.");
        }
    } while (opcion != 4);

static void MostrarMenu()
{
    Console.WriteLine("Opciones a elegir en el programa:");
    Console.WriteLine("1. Convertir de Celsius a Fahrenheit");
    Console.WriteLine("2. Convertir de Fahrenheit a Celsius");
    Console.WriteLine("3. Información del programador");
    Console.WriteLine("4. Salir");
}

static void CelciusAFahrenheit()
{
    Console.WriteLine("Ingrese la cantidad de grados en Celsius:");
    if (double.TryParse(Console.ReadLine(), out double celcius))
    {
        double fahrenheit = (celcius * 9 / 5) + 32;
        Console.WriteLine($"{celcius}°C equivalen a {fahrenheit}°F");
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor, ingrese un valor numérico.");
    }
}

static void FahrenheitACelcius()
{
    Console.WriteLine("Ingrese la cantidad de grados en Fahrenheit:");
    if (double.TryParse(Console.ReadLine(), out double fahrenheit))
    {
        double celcius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit}°F equivalen a {celcius}°C");
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor, ingrese un valor numérico.");
    }
}

static void MostrarInformacionProgramador()
{
    Console.WriteLine("Información del Programador:");
    Console.WriteLine("Nombre: Rómulo García.");
    Console.WriteLine("Carrera: Ingeniería en Informática y Sistemas.");
}