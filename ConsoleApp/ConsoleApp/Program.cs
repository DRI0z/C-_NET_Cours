class Program
{

    static void Taxes(double anualGrossSalary, double tax)
    {
        double anualNetSalary = anualGrossSalary - (anualGrossSalary * (tax / 100));
        double netSalary = anualNetSalary / 12;

        Console.WriteLine("Le salaire Brut annuel : " + anualGrossSalary + "€, le salaire Net annuel : " + anualNetSalary + "€, le salaire Net mensuel :" + netSalary + "€");
    }


    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Le salaire annuel brut : ");
        double anualGrossSalary = double.Parse(Console.ReadLine());

        Console.WriteLine("La taxe : ");
        double tax = double.Parse(Console.ReadLine());

        Taxes(anualGrossSalary, tax);
    }
}