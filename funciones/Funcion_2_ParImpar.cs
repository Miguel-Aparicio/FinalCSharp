using static System.Console;
namespace ParImparA;

class ParImpar
{
    public void parimpar()
    {
        while (true)
        {
            Clear();
            WriteLine("Programa detección propiedad par de un número...");
            WriteLine("------------------------------------------------------");
            Write("Ingrese un número para detectar: ");
            string? valor = ReadLine();
            if (! string.IsNullOrWhiteSpace(valor))
            {
                decimal numero;
                if (decimal.TryParse((valor.Replace(".",",")), out numero))
                {
                    if (numero %2 == 0)
                        {WriteLine($"\n El número {numero} es Par.");}
                    else
                        {WriteLine($"\n El número {numero} es impar.");}
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
            WriteLine("\n¿Quiere comprobar otro número? ");
            Write(@"Cualquier tecla (Quiero seguir); n (Salir del Programa)");
            Write("\n==> ");
            string? seguir = ReadLine();            
            if (seguir == "n" || seguir == "N")
                {break;}
            else
                {continue;}
        }
        Clear();
    }
}