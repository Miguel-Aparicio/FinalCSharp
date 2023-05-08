using static System.Console;
namespace AdivinarNumeroA;

class AdivinarNumero
{
    public void adivinarnumero()
    {
        while (true)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);
            int intentos = 0;
            int numeroUsuario = 0;

            while (numeroUsuario != numeroAleatorio)
            {
                Clear();
                WriteLine("Programa Juego de adivinación de número...");
                WriteLine("------------------------------------------------------");
                WriteLine($"Numero de intentos actual: {intentos}");
                WriteLine("Adivine el número (entre 1 y 100):");
                if (!int.TryParse(ReadLine(), out numeroUsuario))
                {
                    WriteLine("Número invalido. Inténtelo de nuevo.");
                    ReadLine();
                    continue;
                }
                intentos++;

                if (numeroUsuario < numeroAleatorio)
                {
                    WriteLine("No, es más grande.\n\nPrueba de nuevo pulsando enter.");
                    ReadLine();
                }
                else if (numeroUsuario > numeroAleatorio)
                {
                    WriteLine("No, es más pequeño.\n\nPrueba de nuevo pulsando enter.");
                    ReadLine();
                }
            }
            Clear();
            WriteLine("Programa Juego de adivinación de número...");
            WriteLine("------------------------------------------------------");
            WriteLine($"¡Has acertado! ¡El número era {numeroAleatorio}!\nHas necesitado {intentos} intentos.");
            WriteLine("\n¿Quiere jugar otra vez?");
            WriteLine("Intro o cualquier tecla (continuar) m (Volver al menu)");
            Write("==>");
            string? seguir = ReadLine();
            if (seguir == "m"||seguir == "M") {break;}
            else continue;
        }
        Clear();   
    }
}