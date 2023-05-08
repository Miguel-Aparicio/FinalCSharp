using static System.Console;
namespace AnyoBisiestoA;

class AnyoBisiesto
{
    public void anyobisiesto()
    {
        while (true)
        {
            Clear();
            WriteLine("Programa detección años bisiestos...");
            WriteLine("------------------------------------------------------");
            Write("Ingrese un año: ");
            string? input = ReadLine();
            int anio;
            if (string.IsNullOrWhiteSpace(input)) {WriteLine("Error. No ha introducido valores");}
            if (int.TryParse(input, out anio))

                if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
                {
                    WriteLine($"\n{anio} es un año bisiesto");
                }
                else
                {
                    WriteLine($"\n{anio} no es un año bisiesto");
                }
            else
                WriteLine("\nError. Ha entrado un año incorrecto");
            WriteLine("\n ¿Quiere comprobar otro año?\n Intro o cualquier tecla (seguir) n (salir):");
            string? seguir = ReadLine();            
            if (seguir == "n" || seguir == "N")
                {break;}
            else
                {continue;}
        }
        Clear();
    }
}