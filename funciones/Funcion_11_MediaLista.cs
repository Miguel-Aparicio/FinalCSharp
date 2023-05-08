using static System.Console;
namespace MediaListaA;

class MediaLista
{
    public void medialista()
    {
        while (true)
        {
            Clear();
            WriteLine("Programa calculador de la media de lista de números enteros...");
            WriteLine("------------------------------------------------------");
            Write("Ingrese una lista de números separados por comas: ");
            string? input = ReadLine();
            if (string.IsNullOrWhiteSpace(input)) {WriteLine("Error. No ha introducido ningún valor.");}
            else
            {
                try
                {
                    input = input.TrimEnd(',').TrimStart(',');
                    string[] arraystrings = input.Split(",");
                    int[] arrayint = new int [arraystrings.Length];
                    for (int i = 0; i <arraystrings.Length; i++)
                        arrayint[i] = int.Parse(arraystrings[i]);
                    ;
                    double media = arrayint.Average();
                    WriteLine($"\nLa media es: {media}.");
                }
                catch
                {
                    WriteLine("\nError. Los valores introducidos no son correctos.\nDebe introducir numeros enteros separados por comas.");
                }
            }
            WriteLine("\n¿Quiere introducir otros valores?");
            WriteLine("Intro o cualquier tecla (continuar) m (Volver al menu)");
            Write("==>");
            string? seguir = ReadLine();
            if (seguir == "m"||seguir == "M") {break;}
            else continue;
        }
        Clear();
    }
}