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
class Principal
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

        Pipirisnais vehi2 = new Waka();
        vehi2.Sonarclaxon();

        Pipirisnais vehi3 = new Pipirisnais();
        vehi3.Sonarclaxon();

        Perro perro1 = new Perro("doge", 10,"Golden_Retriever");
        perro1.Hacer_sonido();

        Gato gato1 = new Gato("xuxo", 5,"Siames");
        gato1.Hacer_sonido();

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
// polimorfismo
public class Pipirisnais
{
    public virtual void Sonarclaxon()
    {
        Console.WriteLine("pip pip");
    }

}
// polimorfismo hijo
public class Waka : Pipirisnais
{
    public override void Sonarclaxon()
    {
        Console.WriteLine("vip vip(rico)");
    }
}
// Ejercicios
// Simulacion de juego de mascotas
public interface Imascotas
{
    void Hacer_sonido();
}
// Perros
public class Perro : Imascotas
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Raza { get; set; }
    public Perro(string nombre, int edad, string raza)
    {
        Nombre = nombre;
        Edad = edad;
        Raza = raza;
    }
    public void Hacer_sonido()
    {
        Console.WriteLine($"guau guau(me llamo {Nombre} y soy de la raza {Raza}, tengo {Edad} años)");
        Console.WriteLine("Guau Guau(Soy un bollo feliz Delicioso es para mí Ser horneado y amasado así Ponme en el desayuno o para almorzar Soy sabroso en la comida O también para cenar Soy un bollo feliz Delicioso es para mí Ser horneado y amasado, qué festín Segunda Parte Soy un bollo feliz Delicioso es para mí Ser horneado y amasado así Ponme en el)");
    }
}
// Gato
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
