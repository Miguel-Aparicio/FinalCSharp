using static System.Console;
namespace CapicuaA;

class Capicua
{
    public void capicua()
    {
        while (true)
        {
            Clear();
            WriteLine("Programa eliminador de numeros duplicados de una lista...");
            WriteLine("------------------------------------------------------");
            Write("Ingrese una lista de numeros separados por comas: ");
            string? input = ReadLine();
            if (string.IsNullOrWhiteSpace(input)) {WriteLine("Error. No ha introducido ningún valor.");}
            else
            {
                
            }
        }
    }
}