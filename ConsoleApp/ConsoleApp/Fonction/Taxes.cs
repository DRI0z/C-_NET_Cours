using ConsoleApp.Fonction;

namespace ConsoleApp.Fonction
{
    public class Taxes
    {

        public static void Tax(double anualGrossSalary, double tax)
        {
            double anualNetSalary = Math.Round(anualGrossSalary - (anualGrossSalary * (tax / 100)), 2);
            double netMonthlySalary = Math.Round((anualNetSalary / 12), 2);

            Console.WriteLine("Le salaire Brut annuel : " + anualGrossSalary + "€, le salaire Net annuel : " + anualNetSalary + "€, le salaire Net mensuel :" + netMonthlySalary + "€");

            Calendar.SalaryMonth(netMonthlySalary, anualNetSalary);

            Messages.MessageInfo(anualGrossSalary, anualNetSalary, netMonthlySalary);
        }
    }
}
