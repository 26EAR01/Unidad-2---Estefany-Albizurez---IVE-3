internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("====MENSAJE DE VOZ====");
        //Variable
        int opc;
        //Crear el menu
        Console.WriteLine("MENU PRINCIPAL");
        Console.WriteLine("1- Recepcion");
        Console.WriteLine("2- Vigilancia");
        Console.WriteLine("3- Mantenimiento");
        Console.WriteLine("4- Sali");
        Console.WriteLine("Digite una opcion[ ]: ");
        opc=Convert.ToInt32(Console.ReadLine());

        //condicion
        if (opc == 1)
            Console.WriteLine("Bienvenido al Dpt. de recepcion");
        if (opc == 2)
            Console.WriteLine("Bienvenido al Dpt. de Vigilancia");
        if (opc == 3)
            Console.WriteLine("Bienvenido al Dpt. de Mantenimiento");
        if (opc != 1 && opc != 2 && opc != 3)
            Console.WriteLine("Saliendo del sistema");

        //limpiar
        Console.Clear();

    }
}