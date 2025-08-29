# Programacion orientado a objetos de c#
# Titulo
### subtitulo
## texto
# Ejemplo de una clase
### (explicado con michis)
``` bash
public class Gato : Imascotas
{
    public string Nombre1 { get; set; }
    public int Edad1 { get; set; }
    public string Raza1 { get; set; }

    public Gato(string nombre1, int edad1, string raza1)
    {
        Nombre1 = nombre1;
        Edad1 = edad1;
        Raza1 = raza1;
    }
    public void Hacer_sonido()
    {
        Console.WriteLine($"Miau Miau(me llamo {Nombre1} y soy de la raza {Raza1}, tengo {Edad1} años)");
        Console.WriteLine("Miau Miau(dame comida)");
    }
}
```
