internal class Program
{
    private static void Main(string[] args)
    {
        //act3 lecc7 inciso1 

        {
            int dia, mes;

            Console.WriteLine("Ingrese el dia:");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el mes (1-12):");
            mes = Convert.ToInt32(Console.ReadLine());

            if ((mes == 3 && dia >= 21) || (mes == 4) || (mes == 5) || (mes == 6 && dia <= 20))
            {
                Console.WriteLine("Primavera");
            }
            else if ((mes == 6 && dia >= 21) || (mes == 7) || (mes == 8) || (mes == 9 && dia <= 22))
            {
                Console.WriteLine("Verano");
            }
            else if ((mes == 9 && dia >= 23) || (mes == 10) || (mes == 11) || (mes == 12 && dia <= 20))
            {
                Console.WriteLine("Otoño");
            }
            else
            {
                Console.WriteLine("Invierno");
            }
        }
    }
}
