internal class Program
{
    private static void Main(string[] args)
    {
        //Act1 Lecc2 Inciso1
        int dia;

        Console.WriteLine("Ingrese un numero del 1 al 7:");
        dia = Convert.ToInt32(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("Hoy es lunes");
                break;

            case 2:
                Console.WriteLine("Hoy es martes");
                break;

            case 3:
                Console.WriteLine("Hoy es miercoles");
                break;

            case 4:
                Console.WriteLine("Hoy es jueves");
                break;

            case 5:
                Console.WriteLine("Hoy es viernes");
                break;

            case 6:
                Console.WriteLine("Hoy es sabado");
                break;

            case 7:
                Console.WriteLine("Hoy es domingo");
                break;

            default:
                Console.WriteLine("Numero invalido");
                break;
        }
    }
}