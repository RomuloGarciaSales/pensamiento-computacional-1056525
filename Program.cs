//Adivinar un número aleatorio
Random generator = new Random();
int numAleatorio = generator.Next(0, 51);
int intento;
Console.WriteLine("Adivina un número entre 0 y 50");
while (true)
{
    Console.WriteLine("Ingresa un número:");
    intento = int.Parse(Console.ReadLine());
    
    if (intento == numAleatorio)
    {
        Console.WriteLine("¡Adivinaste el número!");
        break;
    }
    else if (intento < numAleatorio)
    {
        Console.WriteLine("Número equivocado, el número es mayor, intenta de nuevo");
    }
    else if (intento > numAleatorio)
    {
        Console.WriteLine("Número equivocado, el número es menor, intenta de nuevo");
    }
    else 
    {
        Console.WriteLine("Porfavor, ingrese un carácter válido. Ejemplo: 2");
    }
}