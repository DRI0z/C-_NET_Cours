class Program
{

    static void Taxes(double anualGrossSalary, double tax)
    {
        double anualNetSalary = Math.Round(anualGrossSalary - (anualGrossSalary * (tax / 100)), 2);
        double netSalary = Math.Round((anualNetSalary / 12), 2);

        Console.WriteLine("Le salaire Brut annuel : " + anualGrossSalary + "€, le salaire Net annuel : " + anualNetSalary + "€, le salaire Net mensuel :" + netSalary + "€");

        if (anualGrossSalary >= 50000.0)
        {
            Console.WriteLine("Conseille d'ami, fais des dons pour réduire les impôts");
        }
        else if (netSalary <= 1501.0)
        {
            Console.WriteLine("C'est normal c'est le salaire d'un alternant");
        }
        else if(anualGrossSalary >= 30000.0 && anualGrossSalary <= 40000.0)
        {
            Console.WriteLine("Faut faire un bac +5 en dev");
        }

    }


    static void Main(string[] args)
    {
        
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        double anualGrossSalary;
        double tax;

        Console.WriteLine("Le salaire annuel brut : ");
        string input = Console.ReadLine();

        if(double.TryParse(input, out anualGrossSalary))
        {
            Console.WriteLine("Vous avez entré : "+anualGrossSalary+"€");
        }
        else
        {
            Console.WriteLine("Vous n'avez pas rentré un nombre");
        }

        Console.WriteLine("La taxe : ");
        input = Console.ReadLine();

        if (double.TryParse(input, out tax))
        {
            Console.WriteLine("Vous avez entré : " + tax + "%");
        }
        else
        {
            Console.WriteLine("Vous n'avez pas rentré un poucentage");
        }

        Taxes(anualGrossSalary, tax);
    }
}