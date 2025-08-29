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
        Console.WriteLine($"El coche acelero a: {Velocidad}KM/h");
    }

}
