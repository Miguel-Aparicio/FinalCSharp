using static System.Console;
namespace ListaOrdenadaA;

class ListaOrdenada
{
    public void listaordenada()
    {
        while (true)
        {
            Clear();

            Boolean ingresar = true;
            List<string> listanombres = new List<string>();
            while (ingresar)
            {
                WriteLine("Programa ordenación lista de nombres...");
                WriteLine("------------------------------------------------------");
                WriteLine($"Lista actual: {string.Join(", ", listanombres)}");
                Write("\nIngrese un Nombre: ");
                string? txt = ReadLine();
                if (string.IsNullOrWhiteSpace(txt)) {WriteLine("Error.\n No ha ingresado ningun nombre o esta en blanco.");}
                else if (!txt.All(char.IsLetter)) {WriteLine("Error. Solo es valido introducir un nombre y en caracteres alfabeticos.");}
                else
                {
                    listanombres.Add(txt);
                    Clear();
                    WriteLine("Programa ordenación lista de nombres...");
                    WriteLine("------------------------------------------------------");
                    WriteLine($"Lista actual: {string.Join(", ", listanombres)}");
                    WriteLine("\nNombre introducido correctamente\n\t");
                }
                WriteLine(@"¿Quiere ingresar otro nombre? intro o cualquier tecla (seguir) m (Ordenar lista actual)");
                    string? continuar = ReadLine();
                    if (continuar != "m" && continuar != "M") {Clear();continue;}
                    else {break;}
            }
            if (listanombres.Count == 0) {WriteLine("Error. Su lista esta vacía.");}
            else
            {
                Clear();
                WriteLine("Programa ordenación lista de nombres...");
                WriteLine("------------------------------------------------------");
                WriteLine($"Lista actual: {string.Join(", ", listanombres)}");
                listanombres.Sort();
                WriteLine($"\nSu lista de nombres ordenada alfabeticamente es {string.Join(", ", listanombres)}");
            }
            WriteLine("\n¿Quiere comprobar una nueva lista? ");
            Write(@"Intro o Cualquier tecla (nueva lista); m (Volver al menu)");
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