using static System.Console;
namespace NumeroPrimoA;

class NumeroPrimo
{
    public void primos()
    {
        while (true)
        {
            Clear();
            WriteLine("Programa de detección de números primos...");
            WriteLine("------------------------------------------------------");
            Write("Ingrese un número para detectar: ");
            string? input = ReadLine();
            if (input != "")
            {
                int numero;
                if (int.TryParse(input, out numero))
                {
                    if (numero < 0)
                        {WriteLine("\nSolo son numeros primos aquellos enteros divisibles entre ellos y 1. Por tanto, ningún número negativo será primo.");}
                    else if (numero == 0)
                        {WriteLine("\n0 no es primo porque no se puede dividir.");}
                    else if (numero == 1)
                        {WriteLine("\n1 no es primo porque no tiene más de un divisor.");}
                    else if (numero == 2 || numero == 3)
                        {WriteLine($"\nEl numero {numero} ¡Es primo!");}
                    else if (numero > 3)
                    {
                        int divisor = numero - 1;
                        string res = "";
                        while (divisor != 1)
                        {
                            int temporal = numero % divisor;
                            if (temporal != 0)
                            {
                                divisor -= 1;
                            }
                            else
                            {
                                WriteLine($"\n{numero} no es un número primo.");
                                res = "n";
                                divisor = 1;
                            }
                        }
                        if (res == "")
                            {WriteLine($"\n¡{numero} es Primo!");}
                    }

                }
                else
                {
                    WriteLine("\nError. El valor introducido no es valido.\nRecuerde que los decimales no puedes ser primos.");
                }
            }
            else
            {
                WriteLine("\nError. No has introducido ningún valor.");
            }
            WriteLine("\n¿Quiere comprobar otro número? ");
                Write(@"Cualquier tecla (Quiero seguir); m (Volver al menu)");
                Write("\n==> ");
                string? seguir = ReadLine();            
                if (seguir == "m" || seguir == "M")
                    {break;}
                else
                    {continue;}
        }
        Clear();
    }
}