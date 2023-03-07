namespace ConsoleApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Old { get; set; }
        public double AnnualSalaryBrut { get; set; }
        public double Tax { get; set; }

        public User (int id, string firstName, string lastName, int old, double annualSalaryBrut, double tax)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Old = old;
            this.AnnualSalaryBrut = annualSalaryBrut;
            this.Tax = tax;
        }
    }
}
