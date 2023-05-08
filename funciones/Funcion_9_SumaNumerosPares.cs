using static System.Console;
namespace SumaNumerosParesA;

class SumaNumerosPares
{
    public void sumanumerospares()
    {
        while (true)
        {
            Clear();
            WriteLine("Programa sumatorio de número pares de una lista...");
            WriteLine("------------------------------------------------------");
            WriteLine("Ingrese una lista de números separados por comas para identificar: ");
            string? cadenastring = ReadLine();
            if (cadenastring == null) {WriteLine("\nError. No ha introducido valores.");}
            else
            {
                try
                {
                    List<decimal> listadeci = cadenastring.Split(",").Select(decimal.Parse).ToList();
                    int suma = 0;

                    foreach (int num in listadeci)
                    {
                        if (num % 2 == 0)
                            suma += num;
                    }
                    WriteLine($"La suma de los números pares es {suma}");
                }
                catch
                {
                    WriteLine("Error. Solo son válidos numeros enteros separados por comas.");
                }
            WriteLine("\nIntro o cualquier letra (nueva lista) m (Volver al menu)");
            string seguir = ReadLine();
            if (seguir == "m" || seguir == "M") break;
            else continue;
            }
        }
        Clear();
    }
}