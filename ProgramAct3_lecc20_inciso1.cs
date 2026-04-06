internal class Program
{
    private static void Main(string[] args)
    {
        //Act3 lecc20 inciso1

        int dia;

        Console.WriteLine("Ingrese un numero del 1 al 7:");
        dia = Convert.ToInt32(Console.ReadLine());

        if (dia >= 1 && dia <= 5)
        {
            Console.WriteLine("Es un dia entre semana");
        }
        else if (dia == 6 || dia == 7)
        {
            Console.WriteLine("Es fin de semana");
        }
        else
        {
            Console.WriteLine("Numero invalido");
        }
    }
}