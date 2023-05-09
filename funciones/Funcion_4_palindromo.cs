using static System.Console;
namespace PalindromoA;

class Palindromo
{
    public void palindromo()
    {
        while (true)
        {
            Clear();
            WriteLine("Programa detector de palíndromos...");
            WriteLine("------------------------------------------------------");
            Write("Ingrese una palabra o frase para detectar (sin tildes): ");
            string? input = ReadLine();
            if (string.IsNullOrWhiteSpace(input)) {WriteLine("Error. No ha introducido ningún valor.");}
            else
            {
                string frase = input.ToLower();
                frase = frase.Replace(" ","");
                frase = frase.Replace(".","");
                frase = frase.Replace(",","");
                if (frase.All(char.IsLetter))
                {
                    char[] arrayinv = frase.Reverse().ToArray();
                    string frasereverse = new string(arrayinv);
                    if (frase == frasereverse)
                    {
                        WriteLine($"\n La frase \"{input}\" es un palíndromo.\n Se lee igual de derecha a izquierda que de izquierda a derecha.");
                    }
                    else {WriteLine($"\n La frase \"{input}\" NO es un palíndromo.\n No Se lee igual en los dos sentidos de escritura.");}
                }
                else {WriteLine("\nError, has introducido caracteres incorrectos.");}
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