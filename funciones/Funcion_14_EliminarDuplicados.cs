using static System.Console;
namespace EliminarDuplicadosA;

class EliminarDuplicados
{
    public void eliminarduplicados()
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
                try
                {
                    List<int> listanumeros = input.Split(',').Select(int.Parse).ToList();
                    List<int> nuevalista = listanumeros.Distinct().ToList();
                    WriteLine($"\nLista de Números originales: {string.Join(",",listanumeros)}.");
                    WriteLine($"\nNueva lista sin repetidos: {string.Join(",",nuevalista)}.");
                }
                catch
                {
                    WriteLine("\nError. Ha introducido caracteres incorrectos.\n\n Solo se permiten números enteros separados por comas.");
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