internal class Program
{
    private static void Main(string[] args)
    {
       //Act2 Lecc21 Inciso2
        
        int opcion;

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
                Console.WriteLine("Responsable: Carlos Lopez");
                Console.WriteLine("Correo: ventas@empresa.com");
                break;

            case 2:
                Console.WriteLine("Bienvenido al departamento de Recepcion");
                Console.WriteLine("Responsable: Ana Perez");
                Console.WriteLine("Correo: recepcion@empresa.com");
                break;

            case 3:
                Console.WriteLine("Bienvenido al departamento de Direccion");
                Console.WriteLine("Responsable: Maria Gomez");
                Console.WriteLine("Correo: direccion@empresa.com");
                break;

            case 4:
                Console.WriteLine("Bienvenido al departamento de Compras");
                Console.WriteLine("Responsable: Luis Ramirez");
                Console.WriteLine("Correo: compras@empresa.com");
                break;

            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}