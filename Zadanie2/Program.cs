namespace Zadanie2;

static class Program
{
    public static void Main(string[] args)
    {
        var uni = new Uni();
        var dopuszczalneOceny = new List<double> {2, 2.5, 3, 3.5, 4, 4.5, 5};
        uni.ListaDopuszczalnychOcen = dopuszczalneOceny;

        var endOfProgram = false;
        while (!endOfProgram)
        {
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("0. Dodaj studenta");
            Console.WriteLine("1. Usuń studenta");
            Console.WriteLine("2. Oblicz średnią ocen studenta");
            Console.WriteLine("3. Oblicz średnią ocen wszystkich studentów");
            Console.WriteLine("4. Zakończenie programu");
            Console.Write("Wybieram: ");
            var selected = Int32.Parse(Console.ReadLine()!);

            switch (selected)
            {
                case 0:
                {
                    uni.DodajStudenta();
                    break;
                }

                case 1:
                {
                    uni.UsunStudenta();
                    break;
                }

                case 2:
                {
                    uni.ObliczSrednia();
                    break;
                }

                case 3:
                {
                    uni.ObliczSredniaAll();
                    break;
                }

                case 4:
                {
                    endOfProgram = true;
                    break;
                }

                default:
                {
                    Console.WriteLine("Wprowadzono błędny znak! Podaj wartość 0-4! \n\n");
                    break;
                }
            }
        }
    }
}