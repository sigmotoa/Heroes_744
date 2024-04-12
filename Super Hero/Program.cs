// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var profesorX = new Heroe();
profesorX.Id = 1;
profesorX.Nombre = "Profesor X";
profesorX.Identidad = "Charles Xavier";
profesorX.Ciudad = "UK";
profesorX.Poderes = new[] { "Telepatia", "Telekinesis", "Liderazgo", "Adquisitivo" };

Console.WriteLine(profesorX.Nombre);
class Heroe
{
   public int Id;
   public string Nombre;
   public string Identidad;
   public string Ciudad;
   public string[] Poderes;

}