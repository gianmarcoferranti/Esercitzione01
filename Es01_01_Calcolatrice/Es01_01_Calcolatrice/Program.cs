using System.Linq.Expressions;

namespace Es01_01_Calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            while (check)
            {

                string? str = null;
                double? x = null;
                double? y = null;

                Console.WriteLine(
                    "Benvenuto\n" +
                    "Quale operazione vuoi solgere?\n" +
                    "A - Addizione\n" +
                    "S - Sottrazione\n" +
                    "M - Moltiplicazione\n" +
                    "D - Divisione\n" +
                    "R - Radice\n" +
                    "P - Potenza\n" +
                    "U - Uscire\n");

                str = Console.ReadLine();
                str = str.ToUpper();
                switch (str)
                {
                    // ADDIZIONE
                    case "A":
                        Console.WriteLine("Inserisci il primo numero");
                        try
                        {
                            x = Convert.ToDouble(Console.ReadLine());
                        }
                        catch{
                            Console.WriteLine("Inserimento non valido");
                            break;
                        }
                            Console.WriteLine("Inserisci il secondo numero");
                        
                        try
                        {
                            y = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Inserimento non valido");
                            break;
                        }
                        Console.WriteLine($"Il risultato della somma è : {x + y}");
                        break;
                        //SOTTRAZIONE
                    case "S":
                        Console.WriteLine("Inserisci il primo numero");
                        try
                        {
                            x = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Inserimento non valido");
                            break;
                        }
                        Console.WriteLine("Inserisci il secondo numero");

                        try
                        {
                            y = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Inserimento non valido");
                            break;
                        }
                        Console.WriteLine($"Il risultato della sottrazione è : {x - y}");
                        break;
                        //MOLTIPLICAZIONE
                    case "M":
                        Console.WriteLine("Inserisci il primo numero");
                        try
                        {
                            x = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Inserimento non valido");
                            break;
                        }
                        Console.WriteLine("Inserisci il secondo numero");

                        try
                        {
                            y = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Inserimento non valido");
                            break;
                        }
                        Console.WriteLine($"Il risultato della moltiplicazione è : {x * y}");
                        break;
                        //DIVISIONE
                    case "D":
                        Console.WriteLine("Inserisci il primo numero");
                        try
                        {
                            x = Convert.ToDouble(Console.ReadLine());
                            if (x == 0)
                            {
                                Console.WriteLine("Divisione per zero non concessa");
                                break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Inserimento non valido");
                            break;
                        }
                        Console.WriteLine("Inserisci il secondo numero");

                        try
                        {
                            y = Convert.ToDouble(Console.ReadLine());
                            if (y == 0)
                            { Console.WriteLine("Divisione per zero non concessa"); 
                                break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Inserimento non valido");
                            break;
                        }
                        Console.WriteLine($"Il risultato della divisione è : {x / y}");
                        break;
                        //RADICE
                    case "R":
                        Console.WriteLine("Inserisci il primo numero");
                        try
                        {
                            x = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Inserimento non valido");
                            break;
                        }
                        Console.WriteLine("Inserisci il secondo numero");

                        try
                        {
                            y = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Inserimento non valido");
                            break;
                        }
                        Console.WriteLine($"Il risultato della radice è : {Math.Sqrt((double)(x+y))}");
                        break;
                        //POTENZA
                    case "P":
                        Console.WriteLine("Inserisci il primo numero");
                        try
                        {
                            x = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Inserimento non valido");
                            break;
                        }
                        Console.WriteLine("Inserisci il secondo numero");

                        try
                        {
                            y = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Inserimento non valido");
                            break;
                        }
                        Console.WriteLine($"Il risultato della potenza è : {Math.Pow((double)x, (double)y)}");

                        break;

                    case "U":
                        check = false;
                        break;

                    default:
                        Console.WriteLine("Comando errato riprovare");
                        break;



                }


            }
            Console.WriteLine("Arrivederci");



        }
    }
}
