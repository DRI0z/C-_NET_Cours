class Program
{

    static void MessageInfo(double anualGrossSalary, double anualNetSalary, double netMonthlySalary)
    {
        switch(true)
        {
            case bool condition0 when anualGrossSalary >= 50000.0:
                Console.WriteLine("Conseille d'ami, fais des dons pour réduire les impôts");
                break;

            case bool condition1 when anualNetSalary >= 30000.0 || anualNetSalary <= 40000.0:
                Console.WriteLine("Faut faire un Bac+5 en Dév");
                break;

            case bool condition2 when netMonthlySalary < 1501.0:
                Console.WriteLine("C'est normal c'est le salaire d'un alternant");
                break;

            default:
                Console.WriteLine("Aucune condition n'est remplie");
                break;

        }
    }
    
    
    static void Taxes(double anualGrossSalary, double tax)
    {
        double anualNetSalary = Math.Round(anualGrossSalary - (anualGrossSalary * (tax / 100)), 2);
        double netMonthlySalary = Math.Round((anualNetSalary / 12), 2);

        Console.WriteLine("Le salaire Brut annuel : " + anualGrossSalary + "€, le salaire Net annuel : " + anualNetSalary + "€, le salaire Net mensuel :" + netMonthlySalary + "€");

        MessageInfo(anualGrossSalary, anualNetSalary, netMonthlySalary);
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