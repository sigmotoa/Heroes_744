// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var profesorX = new Heroe();
profesorX.Id = 1;
profesorX.Nombre = "Profesor X";
profesorX.Identidad = "Charles Xavier";
profesorX.Ciudad = "UK";
profesorX.Volar = false;

var imbecibilidad = new Poder();
imbecibilidad.Nombre = "Imbecibilidad";
imbecibilidad.Descripcion = "Firmar por tu compañere que no vine";
imbecibilidad.Nivel = "Nivel 1";

var alientoFuego = new Poder();
alientoFuego.Nombre = "Aliento de Fuego";
alientoFuego.Descripcion = "Lanzar fuego por la boca";
alientoFuego.Nivel = "Semaforo";
profesorX.Poderes = new[] {alientoFuego, imbecibilidad};

Console.WriteLine(profesorX.Nombre);
Console.WriteLine(profesorX.Poderes[0].Nombre);
class Heroe
{
   public int Id;
   public string Nombre;
   public string Identidad;
   public string Ciudad;
   public Poder[] Poderes;
   public bool Volar;

}

class Poder
{
   public string Nombre;
   public string Descripcion;
   public string Nivel;
}