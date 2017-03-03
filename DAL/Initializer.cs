using IFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ContactsContext>
    {
        protected override void Seed(ContactsContext context)
        {
            var users = new List<DALUser>
            {
                new DALUser {FirstName="Carson",LastName="Alexander",birthdate = DateTime.Now},
                new DALUser {FirstName="Meredith",LastName="Alonso",birthdate = DateTime.Now },
                new DALUser {FirstName="Laura",LastName="Norman",birthdate = DateTime.Now }
            };
            users.ForEach(s => context.users.Add(s));
            context.SaveChanges();

            //var phones = new List<PhoneNumber>
            //{
            //    new PhoneNumber {ContactID = 1,number = "0631337563",Type = PhoneNumber.PhoneType.Personal},
            //    new PhoneNumber {ContactID = 1,number = "0445437894",Type = PhoneNumber.PhoneType.Work},
            //    new PhoneNumber {ContactID = 2,number = "0995782753",Type = PhoneNumber.PhoneType.Personal},
            //    new PhoneNumber {ContactID = 3,number = "0664639964",Type = PhoneNumber.PhoneType.Personal}
            //};
            //phones.ForEach(s => context.PhoneNumbers.Add(s));
            //context.SaveChanges();


            //var users = new List<User>
            //{
            //    new User {username = "admin", password = "1", roles = "admin" },
            //    new User {username = "user" , password = "2", roles = "" }
            //};
            //users.ForEach(s => context.Users.Add(s));
            //context.SaveChanges();

        }
    }
}