using static System.Console;
namespace AreaVolumenCuboA;

class AreaVolumenCubo
{
    public void areavolumencubo()
    {
        while (true)
        {
            Clear();
            WriteLine("Programa Obtención de Área y volumen de un cubo...");
            WriteLine("------------------------------------------------------");
            Write("Ingrese el valor del lado de su cubo: ");
            string? valor = ReadLine();
            if (valor != null)
            {
                decimal Lado;
                if (decimal.TryParse((valor.Replace(".",",")),out Lado))
                {
                    decimal cuadrado = Lado * Lado;
                    decimal area =  cuadrado * 6m;
                    decimal volumen = cuadrado * Lado;
                    string res = $"\n\tEl área de cubo de lado {Lado} es: {area}, y el volumen: {volumen}.";
                    WriteLine(res);
                }
                else
                {
                    WriteLine("Error. Introduzca valores numéricos válidos.");
                }
            }
            else
            {
            WriteLine("Error. Introduzca valores para realizar la operación."); 
            }
            WriteLine("\n¿Quiere introducir otro valor? ");
            Write(@"Cualquier tecla (Nuevo cubo); m (Volver al menu)");
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