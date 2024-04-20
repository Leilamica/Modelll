using Businesssss;

namespace ProgramUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your UserID:");
            string UserID = Console.ReadLine();
            Console.WriteLine("Enter your Password:");
            string Password = Console.ReadLine();

            VerifyID DataService = new VerifyID();
            bool result = VerifyID.VerifyIDS(UserID);

            VerifyID PasswordService = new VerifyID();
            bool result1 = PasswordService.VerifyPassword(Password);

            if (result1)
            {
                Console.WriteLine("You've login successfully");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

    }
}