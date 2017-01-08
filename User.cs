using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnersMatcher
{
    [Serializable]
    public class User
    {

        public string firstName { get; set; }
        public string lastName { get; set; }
        DateTime dateOfBirth;
        string gender;
        public string email { get; set; }
        public string password { get; set; }
        public string religion{ get; set; }
        public string city { get; set; } 
        public string maritalStatus { get; set; }
        public List<string> areas { get; set; }


        public User(string fName, string lName, DateTime dob, string gen, string mail,
            string pass, string relig, string cty, string marital, List<string> area)
        {
            firstName = fName;
            lastName = lName;
            dateOfBirth = dob;
            gender = gen;
            email = mail;
            password = pass;
            religion = relig;
            city = cty;
            maritalStatus = marital;
            areas = area;
        }
        public User(User toCopy)
        {
            firstName = toCopy.firstName;
            lastName = toCopy.lastName;
            dateOfBirth = toCopy.dateOfBirth;
            gender = toCopy.gender;
            email = toCopy.email;
            password = toCopy.password;
            religion = toCopy.religion;
            city = toCopy.city;
            maritalStatus = toCopy.maritalStatus;
            areas = new List<string>(toCopy.areas);
        }



    }
}
