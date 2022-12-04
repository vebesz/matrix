using matrix;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Üdvözöljük a mátrixban!");
        Console.WriteLine("Először is hozzonk létre egy mátrixot!");
        Matrix matrix = Matrix.CreateFromUserInput();
        Console.WriteLine("A mátrix:");
        matrix.Kiir();

        Console.WriteLine("==================================");
        Console.WriteLine("Funkciók:");
        Console.WriteLine("1 - Minimum érték");
        Console.WriteLine("2 - Maximum érték");
        Console.WriteLine("3 - Átlag érték");
        Console.WriteLine("4 - Van-e benne szám");
        Console.WriteLine("5 - Rendezés");
        Console.WriteLine("6 - Rendezés viszont fordítva");
        Console.WriteLine("7 - Páros és páratlan számok szétválogatása");
        Console.WriteLine("0 - Kilépés");
        Console.WriteLine("Egy funkció kiválasztásához írja be a számát!");
        bool fut = true;
        while (fut)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Funkció: ");
            string input = Console.ReadLine();
            int valasztas = int.Parse(input);

            switch (valasztas)
            {
                case 1:
                    Console.WriteLine("Mátrix: ");
                    matrix.Kiir();
                    Console.WriteLine("--");
                    Console.WriteLine("A minimum érték: " + matrix.Minimum());
                    break;
                case 2:
                    Console.WriteLine("Mátrix: ");
                    matrix.Kiir();
                    Console.WriteLine("--");
                    Console.WriteLine("A maximum érték: " + matrix.Maximum());
                    break;
                case 3:
                    Console.WriteLine("Mátrix: ");
                    matrix.Kiir();
                    Console.WriteLine("--");
                    Console.WriteLine("A átlag érték: " + matrix.Atlag());
                    break;
                case 4:
                    Console.WriteLine("Adja meg a számot amit keresni szeretne: ");
                    double szam = double.Parse(Console.ReadLine());
                    Console.WriteLine("Mátrix: ");
                    matrix.Kiir();
                    Console.WriteLine("--");
                    if (matrix.VanBenne(szam))
                    {
                        Console.WriteLine("A mátrixban benne van a szám!");
                    }
                    else
                    {
                        Console.WriteLine("A mátrixban nincs benne a szám!");
                    }
                    Console.WriteLine("Van benne " + szam);
                    break;
                case 5:
                    Console.WriteLine("Mátrix: ");
                    matrix.Kiir();
                    Console.WriteLine("--");
                    Console.WriteLine("Rendezett mátrix: ");
                    matrix.Rendezes();
                    break;
                case 6:
                    Console.WriteLine("Mátrix: ");
                    matrix.Kiir();
                    Console.WriteLine("--");
                    Console.WriteLine("Visszafelé rendezett mátrix: ");
                    matrix.RendezesVisszafele();
                    break;
                case 7:
                    Console.WriteLine("Mátrix: ");
                    matrix.Kiir();
                    Console.WriteLine("--");
                    matrix.ParosParatlan();
                    break;
                case 0:
                    Console.WriteLine("Kilépés...");
                    fut = false;
                    break;
                default:
                    Console.WriteLine("Nem létező funkció!");
                    break;
            }
        }

    }
}