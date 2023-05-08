using static System.Console;

using MenorMayorA;
using ParImparA;
using AnyoBisiestoA;
using PalindromoA;
using ListaOrdenadaA;
using FactorialA;
using NumeroPrimoA;
using AreaVolumenCuboA;
using SumaNumerosParesA;
using NumeroPositivoNegativoCeroA;
using MediaListaA;
using AdivinarNumeroA;
using AnagramaA;
using EliminarDuplicadosA;
using CapicuaA;

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
                SumaNumerosPares mi_par = new SumaNumerosPares();
                mi_par.sumanumerospares();
                break;
            case 10:
                MayorMenor0 mi_numero0 = new MayorMenor0();
                mi_numero0.mayormenor0();
                break;
            case 11:
                MediaLista mi_medialista = new MediaLista();
                mi_medialista.medialista();
                break;
            case 12:
                AdivinarNumero mi_juego = new AdivinarNumero();
                mi_juego.adivinarnumero();
                break;
            case 13:
                Anagrama mi_anagrama = new Anagrama();
                mi_anagrama.anagrama();
                break;
            case 14:
                EliminarDuplicados mi_duplicado = new EliminarDuplicados();
                mi_duplicado.eliminarduplicados();
                break;
            case 15:
                Capicua mi_capi = new Capicua();
                mi_capi.capicua();
                break;
        }
    }
    else {WriteLine ("\nSolo se admiten números para selecionar la opción.\nPulse intro para probar de nuevo"); ReadLine();continue;}
}
Clear();
WriteLine("\n\n¡Hasta pronto! :)\n\n\t");