using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23_LambdaFunction
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to address book program..");
            Console.WriteLine();

            MakingFromPattern patterns = new MakingFromPattern();
            Console.WriteLine(patterns.validateFirstName("Suraj"));
            Console.WriteLine(patterns.validateLastName("kumar"));
            Console.WriteLine(patterns.validateEmail("Soorajkrpandit@gmail.com"));
            Console.WriteLine(patterns.validatePhoneNo("91 6200749278"));
            Console.WriteLine(patterns.validatePassword("LabBridge@001"));
            Console.WriteLine();

            Console.WriteLine("To validate the user entry using lambda function");
            List<Person> listed = new List<Person>();
            LambdaAnynomous.ValidateUserEntry(listed);

            Console.ReadKey();

        }
    }
}
