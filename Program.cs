using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Programa para notas de los Estudiantes");
string [] nombres = ["Juan","Pedro","Luisa","Adriana","Sofia"];
int [] notas = [88,75,96,77,59];
int suma = 0;

for (int a=0; a<notas.Length; a++)
{
    Console.WriteLine($"Las notas correspondientes son {a}:" + nombres[a]+  "-" + notas[a]);
}

int promedio = suma/notas.Length;
Console.WriteLine($"El promedio de las notas es:" + promedio);