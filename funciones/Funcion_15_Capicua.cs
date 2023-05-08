using static System.Console;
namespace CapicuaA;

class Capicua
{
    public void capicua()
    {
        while (true)
        {
            Clear();
            WriteLine("Programa detector de números enteros capicuas...");
            WriteLine("------------------------------------------------------");
            Write("Ingrese un numero entero para de la detección: ");
            string? valor = ReadLine();
            if (! string.IsNullOrWhiteSpace(valor))
            {
                int numero;
                if (int.TryParse((valor.Replace(".",",")), out numero))
                {
                    int numeroinv;
                    char[] arrayinv = valor.Reverse().ToArray();
                    string frasereverse = new string(arrayinv);
                    int.TryParse(frasereverse, out numeroinv);
                    
                    if (numero == numeroinv)
                        {WriteLine($"\n El número {numero} es capicua.");}
                    else
                        {WriteLine($"\n El número {numero} No es capicua.");}
                }
                else
                {
                    WriteLine("\nError. Introduzca un único valor numérico válido.");   
                }
            }
            else
            {
            WriteLine("Error. Introduzca valores para realizar la operación."); 
            }
            WriteLine("\n¿Quiere introducir otro número?");
            WriteLine("Intro o cualquier tecla (continuar) m (Volver al menu)");
            Write("==>");
            string? seguir = ReadLine();
            if (seguir == "m"||seguir == "M") {break;}
            else continue;
        }
        Clear();
    }
}