using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PartnersMatcher
{
    public class Model
    {
        public Dictionary<string, User> emailToUser; //<mail, user>
        public Dictionary<int, Post> systemPosts;
        public List<string> modelAreas;
        public string currentUserEmail;
        public Model()
        {
            emailToUser = new Dictionary<string, User>();
            modelAreas = new List<string>();
            systemPosts = new Dictionary<int, Post>();
            modelAreas.Add("Traveling");
            modelAreas.Add("Roomates");
            modelAreas.Add("Sport");
            modelAreas.Add("Dating");
            systemPosts.Add(1, new Post(1,"one","this",new List<string>(){"Traveling"}, "sagy", "holon"));
            ReadUsersDicFromDisk();
            ReadUAreasDicFromDisk();
        }
        public void SignUp(User user)
        {
            if (emailToUser.Keys.Contains(user.email))
                throw new Exception("Mail exists");
            emailToUser.Add(user.email, user);
            WriteUsersDicToDisk();
            SmtpClient sender = new SmtpClient();
            SendRegistrationCompletedMail(user);
        }

        private void SendRegistrationCompletedMail(User user)
        {
            var fromAddress = new MailAddress("partnermatcher@gmail.com", "PartnerMatcher");
            var toAddress = new MailAddress(user.email, user.firstName + " " + user.lastName);
            const string fromPassword = "Sg504504";
            const string subject = "Registration Approval For Partner Matcher";
             string body = "Hello " + user.firstName + ",\n\nThank you for joining Partner Matcher family!";
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
        public void WriteUsersDicToDisk()
        {

            using (Stream log = File.Open("Users.txt", FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(log, emailToUser);
            }
        }

        public void WriteAreasDicToDisk()
        {

            using (Stream log = File.Open("Areas.txt", FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(log, modelAreas);
            }
        }

        public void ReadUsersDicFromDisk()
        {

            if (File.Exists("Users.txt"))
            {
                using (Stream users = File.Open("Users.txt", FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    emailToUser = (Dictionary<string, User>) binaryFormatter.Deserialize(users);
                }
            }
        }

        public void ReadUAreasDicFromDisk()
        {

            if (File.Exists("Areas.txt"))
            {
                using (Stream areas = File.Open("Areas.txt", FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    modelAreas = (List<string>)binaryFormatter.Deserialize(areas);
                }
            }
        }

        public List<Post> SearchParterByCityAndArea(string city, string area)
        {
            List<Post> res = new List<Post>();
            foreach(int id in systemPosts.Keys)
            {
                if(systemPosts[id].city == city)
                {
                    foreach(string are in systemPosts[id].postAreas)
                    {
                        if(are == area)
                        {
                            res.Add(systemPosts[id]);
                            break;
                        }
                    }
                }
            }
            return res;
        }

        public void login(string email, string password)
        {
            if( emailToUser.ContainsKey(email) )
            {
                if(emailToUser[email].password == password)
                {
                    currentUserEmail = email;
                }
                else
                    throw new Exception("password is  incorrect!");
            }
            else
                throw new Exception("user doesn't exist  incorrect!");

        }

    }
}
