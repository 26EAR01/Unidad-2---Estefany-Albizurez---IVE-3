internal class Program
{
    private static int opcion;

    private static void Main(string[] args)
    {
        //act2 lecc7 inciso1

        Console.WriteLine("BUZON DE VOZ");
        Console.WriteLine("1. Ventas");
        Console.WriteLine("2. Recepcion");
        Console.WriteLine("3. Direccion");
        Console.WriteLine("4. Compras");
        Console.WriteLine("Seleccione una opcion:");

        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Bienvenido al departamento de Ventas");
                break;

            case 2:
                Console.WriteLine("Bienvenido al departamento de Recepcion");
                break;

            case 3:
                Console.WriteLine("Bienvenido al departamento de Direccion");
                break;

            case 4:
                Console.WriteLine("Bienvenido al departamento de Compras");
                break;

            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}