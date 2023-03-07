using ConsoleApp.Models;

namespace ConsoleApp.Fonction
{
    public class NewUser
    {
        public static void User() 
        {
            User user1 = new User();

            Console.WriteLine("Son Id :");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int id))
            {
                user1.Id = id;
            }
            else
            {
                Console.WriteLine("Vous n'avez pas saisie un Id correct");
            }

            Console.WriteLine("Le Prénom :");
            user1.FirstName = Console.ReadLine();

            Console.WriteLine("Le Nom :");
            user1.LastName = Console.ReadLine();

            Console.WriteLine("Son Age :");
            string input1 = Console.ReadLine();
            if (int.TryParse(input1, out int old))
            {
                user1.Old = old;
            }
            else
            {
                Console.WriteLine("Vous n'avez pas saisie une Age correct");
            }


            Console.WriteLine("Le Salaire brut annuel :");
            string input2 = Console.ReadLine();
            if (int.TryParse(input2, out int annualSalaryBrut))
            {
                user1.AnnualSalaryBrut = annualSalaryBrut;
            }
            else
            {
                Console.WriteLine("Vous n'avez pas saisie un Salaire brut annuel correct");
            }


            Console.WriteLine("La Taxe :");
            string input3 = Console.ReadLine();
            if (int.TryParse(input3, out int tax))
            {
                user1.Tax = tax;
            }
            else
            {
                Console.WriteLine("Vous n'avez pas saisie une Taxe correct");
            }

            User user2 = new User(2, "Bastien", "Da Silva", 23, 50000, 23);

            /*user2.Id = 2;
            user2.FirstName = "Bastien";
            user2.LastName = "Da Silva";
            user2.Old = 23;
            user2.AnnualSalaryBrut = 50000;
            user2.Tax = 23;*/

            Taxes.Tax(user1.AnnualSalaryBrut, user1.Tax);

            Console.WriteLine(user2.FirstName +","+ user2.LastName+", Age : "+ user2.Old+ ", Salaire : "+ user2.AnnualSalaryBrut+", Taxe : "+ user2.Tax);
            Console.WriteLine(user1.FirstName +","+ user1.LastName+", Age : "+ user1.Old+ ", Salaire : "+ user1.AnnualSalaryBrut+", Taxe : "+ user1.Tax);
        }
    }
}
