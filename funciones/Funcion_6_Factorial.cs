using static System.Console;
namespace FactorialA;

class Factorial
{
    public void factorial()
    {
        while (true)
        {
            Clear();
            WriteLine("Programa calculador de factoriales...");
            WriteLine("------------------------------------------------------");
            Write(("Ingrese un número para saber su factorial: "));
            string? input = ReadLine();
            int num = 0, factorial = 1;
            if (int.TryParse(input, out num))
            {
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }
                WriteLine($"El factorial de {input} es {factorial}");
            }
            else
            {WriteLine("\nError. Solo son valores válidos números enteros.");}
            
            WriteLine("\n¿Quiere comprobar un nuevo número? ");
            Write(@"Intro o Cualquier tecla (nueva lista); m (Volver al Menu)");
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