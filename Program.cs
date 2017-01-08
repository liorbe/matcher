using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnersMatcher
{
    class Program
    {
        static void Main(string[] args)
        {

            Model m = new Model();
            List<string> l = new List<string>();
            l.Add("sport");
            l.Add("Pistachiu icecream");
            User u = new User("Yakir", "Hershkovitz", new DateTime(1923, 4, 4), "female", "yakirhe1@gmail.com", "1234"
                , "jew", "caeseria", "married", l);
            //User u2 = new User("bibib", "amelech", new DateTime(1923, 4, 4), "male", "bibib@sara.com", "1234"
            // , "jew", "caeseria", "married", l);
            m.SignUp(u);
            ////m.SignUp(u2);
            ////m.WriteUsersDicToDisk();
            //m.ReadUsersDicFromDisk();
            //Console.WriteLine();
        }
    }
}
