internal class Program
{
    private static void Main(string[] args)
    {
        //Act1 lecc7 Inciso2

        int edad;

        Console.WriteLine("Ingrese su edad:");
        edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Es mayor de edad");
        }
        else
        {
            Console.WriteLine("Es menor de edad");
        }
    }
}