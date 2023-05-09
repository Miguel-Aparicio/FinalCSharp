using static System.Console;
namespace AnagramaA;

class Anagrama
{
    public void anagrama()
    {
        while (true)
        {
            Clear();
            WriteLine("Programa comparador de anagramas...");
            WriteLine("------------------------------------------------------");
            Write("Ingrese una palabra para detectar (sin tildes): ");
            string? input1;
            string? input2;
            input1 = ReadLine();
            if (string.IsNullOrWhiteSpace(input1)) {WriteLine("Error. No ha introducido ningún valor.\nPrueba de nuevo.");}
            else
            {
                string frase1 = input1.ToLower();
                if (frase1.All(char.IsLetter))
                {
                    while (true)
                    {    
                        Clear();
                        WriteLine("Programa comparador de anagramas...");
                        WriteLine("------------------------------------------------------");
                        WriteLine($"Primera palabra introducida: {input1}");
                        Write("Ingrese una segunda palabra (sin tildes): ");
                        input2 = ReadLine();
                        if (string.IsNullOrWhiteSpace(input2)) {WriteLine("Error. No ha introducido ningún valor.\nPulsa intro para probar de nuevo.");ReadLine();continue;}
                        else
                        {
                            string frase2 = input2.ToLower();
                            if (frase2.All(char.IsLetter))
                            {
    
                                char[] array1 = frase1.ToArray();
                                char[] array2 = frase2.ToArray();
                                Array.Sort(array1);
                                Array.Sort(array2);
                                
                                bool sonAnagramas = array1.SequenceEqual(array2);

                                if (sonAnagramas)
                                {
                                    WriteLine($"\n\"{input1}\" y \"{input2}\" son anagrama.");
                                    break;
                                }
                                else
                                {
                                    WriteLine($"\n\"{input1}\" y \"{input2}\" no son anagrama.");
                                    break;
                                }

                            }
                            else {WriteLine("\nError, has introducido caracteres incorrectos.\n Pulse intro para probar de nuevo.");ReadLine();continue;}
                        }
                    }    
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