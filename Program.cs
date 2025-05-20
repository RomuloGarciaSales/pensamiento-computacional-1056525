int numero = 0;
do
{
    Console.WriteLine("Ingrese un número para mostrar su tabla de multiplicar");
    numero = Convert.ToInt32(Console.ReadLine());
    for (int actual = 1; actual <= 10; actual++)
    {
        Console.WriteLine(numero * actual);
        Console.WriteLine("La tabla de" + numero + "es");
    }
}while(true);
