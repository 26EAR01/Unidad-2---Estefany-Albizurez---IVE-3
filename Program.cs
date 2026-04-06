internal class Program
{
    private static void Main(string[] args)
    {
        double nota1, nota2, nota3, nota4, nota5, promedio;

        Console.WriteLine("Ingrese la nota 1:");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la nota 2:");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la nota 3:");
        nota3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la nota 4:");
        nota4 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la nota 5:");
        nota5 = Convert.ToDouble(Console.ReadLine());

        promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

        if (promedio >= 60)
        {
            Console.WriteLine("El alumno APRUEBA");
        }
        else
        {
            Console.WriteLine("El alumno REPRUEBA");

        }
    }
}