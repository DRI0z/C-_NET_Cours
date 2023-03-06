using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Fonction
{
    public class Calendar
    {
        public static string[] monthCalendar = new string[] { "Janaruy", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December", "Prime"};


        public static void SalaryMonth(double netMonthlySalary, double anualNetSalary)
        {
            for(int i = 0; i < monthCalendar.Length; i++)
            {
                if (monthCalendar[i] == "August")
                {
                    Console.WriteLine(monthCalendar[i] + " : Vacances");
                }
                else if (monthCalendar[i] == "Prime")
                {
                    Console.WriteLine(monthCalendar[i] +" de fin d'année : "+ Math.Round(anualNetSalary * 0.1 ,2)+"€");
                }
                else
                { 
                    Console.WriteLine(monthCalendar[i]+ " : " +netMonthlySalary);
                }
            }
        }

    }
}
