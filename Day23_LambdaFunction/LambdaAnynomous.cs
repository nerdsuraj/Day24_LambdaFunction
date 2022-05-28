using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23_LambdaFunction
{
    public class LambdaAnynomous
    {
        public static void ValidateUserEntry(List<Person> listed)
        {
            listed.Add(new Person("Suraj", "kumar", "Soorajkrpandit@gmail.com", "6200749278", "LabBridge@labz1"));
            listed.Add(new Person("Prashansa", "Sinha", "PrashansaSinha121@gmail.com", "8340359894", "sinhaLab@labz2"));
            listed.Add(new Person("Rajesh", "Pandit", "PanditRajesh@gmail.com", "9905497370", "LOveBird@JSW"));

            Console.WriteLine(listed.ToString());

            listed.ForEach(x => Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}\t", x.firstname.ToString(), x.lastname.ToString(), x.email.ToString(), x.mobile.ToString(), x.password.ToString()));
        }
    }
}
