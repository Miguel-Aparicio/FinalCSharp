using static System.Console;
namespace MenorMayorA;

class MenorMayor
{
    public void menormayor()
    {

       while (true)
        {
            Clear();
            WriteLine("Programa indentificación de mayor y menor número de una lista...");
            WriteLine("------------------------------------------------------");
            WriteLine("Ingrese una lista de números separados por comas para identificar: ");
            string? cadenastring = ReadLine();
            try
            {
                if (cadenastring == null)
                    {WriteLine("\nError. No ha introducido valores.");}
                else if (cadenastring.Contains("."))
                    {WriteLine("Error. Los valores introducidos no son válidos.\nRecuerde escribir números enteros separados por comas.");}
                else
                {
                List<decimal> listadeci = cadenastring.Split(",").Select(decimal.Parse).ToList();
                decimal mayornum = listadeci.Max();
                decimal menornum = listadeci.Min();
                WriteLine($"El mayor número de su lista es {mayornum}, y el menor {menornum}.");
                }
            }
            catch
            {
                WriteLine("Error. Los valores introducidos no son válidos.\nRecuerde escribir números enteros separados por comas.");
            }
            WriteLine("\n¿Quiere introducir otro valor? ");
            Write(@"Intro o cualquier tecla (Quiero seguir); m (Volver al menu)");
            WriteLine("\n==> ");
            string? seguir = ReadLine();            
            if (seguir == "m" || seguir == "M")
                {break;}
            else
                {continue;}
        }
    }
}