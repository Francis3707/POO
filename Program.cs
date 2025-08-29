using System.Runtime.InteropServices;
using System.Security.Cryptography;

public class Coche
{
    public string? Marca { get; set; }
    public int? Velocidad { get; set; }
    //crear el constructor
    public Coche(string marca, int velocidad)
    {
        Marca = marca;
        Velocidad = velocidad;
    }
    //metodos
    public void Acelerar(int incremento)
    {
        Velocidad += incremento;
        Console.WriteLine($"El coche marca {Marca} acelero a: {Velocidad}Km/h");
    }

}
// Clase principal
class Program
{
    static void Main(string[] args)
    {
        Coche coche1 = new Coche("Toyota", 30);
        coche1.Acelerar(20);
        Coche coche2 = new Coche("Ford", 40);
        coche2.Acelerar(20);
        Coche123 coche3 = new Coche123();
        coche3.Acelerar(40);
        Coche123 coche4 = new Coche123();
        coche3.Acelerar(60);
        Coche123 coche5 = new Coche123();
        coche3.Acelerar(-40);
        Vehiculos vehiculo1 = new Vehiculos();
        vehiculo1.Arranque();
        Pisis pii = new Pisis();
        pii.Acelerar();

    }
}
// encapsulamiento
public class Coche123
{
    private int _velocidad1;
    public int Velocidad1
    {
        get { return _velocidad1; }
        set
        {
            if (value >= 0)
                _velocidad1 = value;
            else
                Console.WriteLine("para atras tras tras, para atras tras tras");
        }
    }
    public void Acelerar(int incremento)
    {
        Velocidad1 += incremento;
        Console.WriteLine($"mi chico has acelerao a {Velocidad1}Km/h");
    }
}
// Herencia 
// clase Padre
public class Vehiculos
{
    public string? Marca1 { get; set; }
    public void Arranque()
    {
        Console.WriteLine("Arranco");
    }
}
// Clase hija
public class Pisis : Vehiculos
{
    public void Acelerar()
    {
        Console.WriteLine("coche 2 avanzo");
    }
}