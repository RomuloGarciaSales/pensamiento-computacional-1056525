using System.Runtime.CompilerServices;
Console.WriteLine("Ingrese un texto:");
string texto = Console.ReadLine();
string[] palabras = texto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int cantidadDePalabras = palabras.Length;
for (int i = 0; i < palabras.Length; i++)
{
    if (palabras[i].Length > 0)
    {
        palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1).ToLower();
    }
}
string textoFinal = string.Join(" ", palabras);
Console.WriteLine("Cantidad de palabras: " + cantidadDePalabras);
Console.WriteLine("Texto con la primera letra de cada palabra en mayúscula:");
Console.WriteLine(textoFinal);