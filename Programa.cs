using static System.Console;

using MenorMayorA;
using ParImparA;
using AnyoBisiestoA;
using PalindromoA;
using ListaOrdenadaA;
using FactorialA;
using NumeroPrimoA;
using AreaVolumenCuboA;
using SumaNUmerosParesA;
using NumeroPositivoNegativoCeroA;
using MediaListaA;
using AdivinarNumeroA;
using AnagramaA;
using EliminarDuplicadosA;
using CapicuaA;

/*

void NumeroPrimo()
{
    int num = 0, i;
    bool esPrimo = true;

    Write("Introduce un número entero positivo: ");
    if (!int.TryParse(ReadLine(), out num))
    {
        WriteLine("Número invalido");
        return;
    }

    for (i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            esPrimo = false;
            break;
        }
    }

    if (esPrimo)
        WriteLine("{0} es un número primo", num);
    else
        WriteLine("{0} no es un número primo", num);
}

void AreaVolumenCubo()
{
    double lado = 0, area, volumen;

    Write("Introduce el valor del lado del cubo: ");
    if (!double.TryParse(ReadLine(), out lado))
    {
        WriteLine("Lado invalido");
        return;
    }

    area = 6 * Pow(lado, 2);
    volumen = Pow(lado, 3);

    WriteLine("El área del cubo es {0}", area);
    WriteLine("El volumen del cubo es {0}", volumen);

    ReadKey();
}

void SumaNumerosPares()
{
    List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int suma = 0;

    foreach (int num in numeros)
    {
        if (num % 2 == 0)
            suma += num;
    }

    WriteLine("La suma de los números pares es {0}", suma);

    ReadKey();
}

void NumeroPositivoNegativoCero()
{

    int num;

    Write("Introduce un número entero: ");
    if (!int.TryParse(ReadLine(), out num))
    {
        WriteLine("Número invalido");
        return;
    }

    if (num > 0)
        WriteLine("{0} es un número positivo", num);
    else if (num < 0)
        WriteLine("{0} es un número negativo", num);
    else
        WriteLine("{0} es cero", num);

    ReadKey();
}

void MediaLista()
{
    int[] numeros = { 10, 20, 30, 40, 50 };
    double media = numeros.Average();
    WriteLine("La media es: " + media);
}

void AdivinarNumero()
{

    Random random = new Random();
    int numeroAleatorio = random.Next(1, 101);
    int intentos = 0;
    int numeroUsuario = 0;

    while (numeroUsuario != numeroAleatorio)
    {
        WriteLine("Adivina el número (entre 1 y 100):");
        if (!int.TryParse(ReadLine(), out numeroUsuario))
        {
            WriteLine("Número invalido");
            continue;
        }
        intentos++;

        if (numeroUsuario < numeroAleatorio)
        {
            WriteLine("El número introducido es menor que el número aleatorio.");
        }
        else if (numeroUsuario > numeroAleatorio)
        {
            WriteLine("El número introducido es mayor que el número aleatorio.");
        }
    }

    WriteLine("¡Has acertado el número en " + intentos + " intentos!");
}

void Anagrama()
{
    string palabra1 = "roma";
    string palabra2 = "amor";

    char[] letras1 = palabra1.ToLower().ToCharArray();
    char[] letras2 = palabra2.ToLower().ToCharArray();

    Array.Sort(letras1);
    Array.Sort(letras2);

    bool sonAnagramas = letras1.SequenceEqual(letras2);

    if (sonAnagramas)
    {
        WriteLine(palabra1 + " y " + palabra2 + " son anagramas.");
    }
    else
    {
        WriteLine(palabra1 + " y " + palabra2 + " no son anagramas.");
    }
}

void EliminarDuplicados()
{
    List<int> numeros = new List<int>() { 10, 20, 30, 20, 50 };

    List<int> numerosSinDuplicados = new List<int>();

    foreach (int numero in numeros)
    {
        if (!numerosSinDuplicados.Contains(numero))
        {
            numerosSinDuplicados.Add(numero);
        }
    }

    WriteLine("Números originales: " + string.Join(", ", numeros));
    WriteLine("Números originales: " + string.Join(", ", numeros));

}

void Capicua()
{
    Console.Write("Ingresa un número: ");
    int num = 0;
    if (!int.TryParse(ReadLine(), out num))
    {
        WriteLine("Número invalido");
        return;
    }
    int originalNum = num;
    int reversedNum = 0;

    while (num > 0)
    {
        int digit = num % 10;
        reversedNum = (reversedNum * 10) + digit;
        num /= 10;
    }

    if (originalNum == reversedNum)
    {
        Console.WriteLine("El número es capicúa.");
    }
    else
    {
        Console.WriteLine("El número no es capicúa.");
    }
}
*/

/*
AnyoBisiesto();
palindromo();
ordenarLista();
factorial();
NumeroPrimo();
AreaVolumenCubo();
SumaNumerosPares();
NumeroPositivoNegativoCero();
MediaLista();
AdivinarNumero();
Anagrama();
EliminarDuplicados();
Capicua();
*/
bool cerrar = false;
while (cerrar == false)
{
    Clear();
    Write(@"
        Menu Principal:
        ------------------------------------------------------
        - Opción 1: Programa Mayor y menor numero.
        - Opción 2: Programa detector de números pares.
        - Opción 3: Programa detector de años bisiestos.
        - Opción 4: Programa detector de palíndromos.
        - Opción 5: Programa ordenador de nombres. 
        - Opción 6: Programa calculador de factoriales.
        - Opción 7: Programa detector de números primos.
        - Opción 8: Programa calculador de area y volumen de cubos.
        - Opción 9: Programa sumatorio de numeros pares.
        - Opción 10: Programa comparador con 0.
        - Opción 11: Programa media de una lista.
        - Opción 12: Programa juego de adivinación.
        - Opción 13: Programa detector de anagramas.
        - Opción 14: Programa eliminador de duplicados.
        - Opción 15: Programa detector de capicuas.
        ------------------------------------------------------
        - Opción 0: Salir del Menu.
        ------------------------------------------------------
        Introduzca el número de su opción: ");
    string? input = ReadLine();
    int opcion;
    if (string.IsNullOrEmpty(input)) {WriteLine("\n No ha ingresado ninguna opción. Pulse intro para probar de nuevo"); ReadLine();continue;}
    else if (int.TryParse(input, out opcion))
    {
        switch (opcion)
        {
            case 0 :
                cerrar = true;
                break;
            case 1:
                MenorMayor mi_menormayor = new MenorMayor();
                mi_menormayor.menormayor();
                break;
            case 2:
                ParImpar mi_parimpar = new ParImpar();
                mi_parimpar.parimpar();
                break;
            case 3:
                AnyoBisiesto mi_anyo = new AnyoBisiesto();
                mi_anyo.anyobisiesto();
                break;
            case 4:
                Palindromo mi_palindromo = new Palindromo();
                mi_palindromo.palindromo();
                break;
            case 5:
                ListaOrdenada mi_listaordenada = new ListaOrdenada();
                mi_listaordenada.listaordenada();
                break;
            case 6:
                Factorial mi_factorial = new Factorial();
                mi_factorial.factorial();
                break;
            case 7:
                NumeroPrimo mi_primo = new NumeroPrimo();
                mi_primo.primos();
                break;
            case 8:
                AreaVolumenCubo mi_cubo = new AreaVolumenCubo();
                mi_cubo.areavolumencubo();
                break;
            case 9:
                break;
            case 10:
                MayorMenor0 mi_numero0 = new MayorMenor0();
                mi_numero0.mayormenor0();
                break;
            case 11:
                break;
            case 12:
                break;
            case 13:
                break;
            case 14:
                break;
            case 15:
                break;
        }
    }
    else {WriteLine ("\nSolo se admiten números para selecionar la opción.\nPulse intro para probar de nuevo"); ReadLine();continue;}
}
Clear();
WriteLine("\n\n¡Hasta pronto! :)\n\n\t");