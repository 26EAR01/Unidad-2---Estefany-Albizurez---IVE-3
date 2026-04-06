internal class Program
{
    private static int nota;

    private static void Main(string[] args)
    {
        //Act2 lecc7 inciso2
        Console.WriteLine("Ingrese la calificacion:");
        nota = Convert.ToInt32(Console.ReadLine());

        if (nota < 60)
        {
            Console.WriteLine("Deficiente");
        }
        else if (nota < 70)
        {
            Console.WriteLine("Regular");
        }
        else if (nota < 80)
        {
            Console.WriteLine("Bien");
        }
        else if (nota < 90)
        {
            Console.WriteLine("Muy Bien");
        }
        else
        {
            Console.WriteLine("Excelente");
        }
    }
}