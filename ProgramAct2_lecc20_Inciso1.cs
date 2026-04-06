internal class Program
{
    private static void Main(string[] args)
    {
        //Act2 lecc20 inciso1

        string clave;

        Console.WriteLine("Ingrese la contraseña:");
        clave = Console.ReadLine();

        if (clave == "Password123")
        {
            Console.WriteLine("Bienvenida");
        }
        else
        {
            Console.WriteLine("El ingreso esta prohibido");
        }
    }
}