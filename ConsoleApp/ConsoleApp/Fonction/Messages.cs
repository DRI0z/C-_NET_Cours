using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Fonction
{
    public class Messages
    {
        public static void MessageInfo(double anualGrossSalary, double anualNetSalary, double netMonthlySalary)
        {
            switch (true)
            {
                case bool condition0 when anualGrossSalary >= 50000.0:
                    Console.WriteLine("Conseil d'ami, fais des dons pour réduire les impôts");
                    break;

                case bool condition1 when anualNetSalary >= 30000.0 && anualNetSalary <= 40000.0:
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
    }
}
