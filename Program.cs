// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Ingrese su nombre por favor!");
var nombreUsuario = Console.ReadLine();
var respuesta = "";
Console.WriteLine($"¡Hola {nombreUsuario}!");
Console.WriteLine("Desea continuar?");
respuesta = Console.ReadLine();

while (respuesta.ToUpper() == "S")
{
    Console.Clear();
    Console.WriteLine("Ingrese su nombre por favor!");
    nombreUsuario = Console.ReadLine();
    Console.WriteLine($"¡Hola {nombreUsuario}!");
    Console.WriteLine("Desea continuar?");
    respuesta = Console.ReadLine();

}

if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado");
}
else
{
    Console.WriteLine("Opcion no valida!!!");
}
    