Console.WriteLine("Ingrese la hora actual en formato de 24 horas");
int Hora= Convert.ToInt16(Console.ReadLine());
switch (Hora)
{
    case int HA when (HA >= 0 && HA <= 11):
        Console.WriteLine("Buenos días");
        break;
    case int HA when (HA >= 12 && HA <= 18):
        Console.WriteLine("Buenas tardes");
        break;
    case int HA when (HA >= 19 && HA <= 23):
        Console.WriteLine("Buenas noches");
        break;
    default:
        Console.WriteLine("Porfavor, ingrese una hora válida");
        break;
}