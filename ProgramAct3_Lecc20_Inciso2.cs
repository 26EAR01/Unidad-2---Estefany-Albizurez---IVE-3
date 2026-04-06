internal class Program
{
    private static void Main(string[] args)
    {
        //Act3 Lecc20 Inciso2

            int nota;

            Console.WriteLine("Ingrese la calificacion:");
            nota = Convert.ToInt32(Console.ReadLine());

            if (nota >= 60)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }
        }
    }

