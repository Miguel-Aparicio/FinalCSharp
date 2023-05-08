using static System.Console;
namespace PalindromoA;

class Palindromo
{
    public void palindromo()
    {
        while (true)
        {
            Clear();
            WriteLine("Programa indentificador de palindromos...");
            WriteLine("------------------------------------------------------");
            WriteLine("Ingrese una palabra o frase para identificar: ");
            string? input= ReadLine();
            if (input == null)
                {WriteLine("Error. No has introducido caracteres.");}
            else if (input.All(char.IsWhiteSpace))
                {WriteLine("Error. No introduzca solo espacios.");}
            else
            {
                string[] inputnospace = input.Split(" ");
                string solocarac = string.Join("",inputnospace);
                if (solocarac.All(char.IsLetter))
                {
                    string frase = solocarac.ToLower();
                    List<char> fraselist = frase.ToList();
                    List<char> fraseinv = new List<char>();
                    fraseinv.AddRange(fraselist);
                    fraseinv.Reverse();
                    if (new string(fraselist.ToArray()).Equals(new string(fraseinv.ToArray())))
                        {WriteLine($"\nLa frase: {input} es un palíndromo.");}
                    else
                        {WriteLine($"\nLa frase: {input} no es un palíndromo.");}
                }
                else
                    {WriteLine ("Error. No se admite ningún elemento que no sea caracter de texto.");}
            }
            WriteLine("\n¿Quiere comprobar otra frase? ");
            Write(@"Intro o Cualquier tecla (Quiero seguir); n (Salir del Programa)");
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