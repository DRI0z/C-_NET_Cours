using ConsoleApp.Fonction;

class Program
{
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

        Taxes.Tax(anualGrossSalary, tax);
    }
}