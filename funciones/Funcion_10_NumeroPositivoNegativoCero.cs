using static System.Console;
namespace NumeroPositivoNegativoCeroA;

class MayorMenor0
{
    public void mayormenor0()
    {
        while (true)
        {
            Clear();
            WriteLine("Programa comparación de número con 0...");
            WriteLine("------------------------------------------------------");
            Write("Ingrese un número para comparar: ");
            string? valor = ReadLine();
            if (valor != null)
            {
                decimal numero;
                if (decimal.TryParse((valor.Replace(".",",")), out numero))
                {
                    if (numero < 0)
                        {WriteLine($"\n{numero} es menor que 0.");}
                    else if (numero > 0)
                        {WriteLine($"\n{numero} es mayor que 0.");}
                    else if (numero == 0)
                        {WriteLine($"\n {numero} es 0, jajaja justo 0.");}
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
            WriteLine("\n¿Quiere comparar otro valor? ");
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