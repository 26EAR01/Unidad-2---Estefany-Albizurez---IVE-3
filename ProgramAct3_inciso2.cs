internal class Program
{
    private static void Main(string[] args)
    {
        //Act3 lecc7 inciso2 

        int ang1, ang2, ang3;

        Console.WriteLine("Ingrese el angulo 1:");
        ang1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el angulo 2:");
        ang2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el angulo 3:");
        ang3 = Convert.ToInt32(Console.ReadLine());

        if (ang1 == ang2 && ang2 == ang3)
        {
            Console.WriteLine("Triangulo Equilatero");
        }
        else if (ang1 == ang2 || ang1 == ang3 || ang2 == ang3)
        {
            Console.WriteLine("Triangulo Isosceles");
        }
        else
        {
            Console.WriteLine("Triangulo Escaleno");
        }
    }
}