// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
Console.WriteLine("Ejercicio 1");
Console.WriteLine("Bienvenido, ingrese su nombre");
string Nombre;
Nombre= Console.ReadLine();
Console.WriteLine("Ingrese su altura con un número entero y dos decimales");
double Altura;
Altura=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese su edad");
int Edad= Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ingrese la inicial de su mascota");
char Inicialmascota;
Inicialmascota= Convert.ToChar(Console.ReadLine());
Console.WriteLine(Nombre);
Console.WriteLine(Altura);
Console.WriteLine(Edad);
Console.WriteLine(Inicialmascota);