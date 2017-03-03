using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFaces
{
    public enum PhoneType
    {
        Mobile = 1,
        Home   = 2,
        Work   = 3
    };


    public interface IUser
    {
        int ID { get; set; }
        string email { get; set; }
        string password { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime birthdate { get; set; }
        byte[] Image { get; set; }
        ICollection<IPhoneNumber> PhoneNumbers { get; set; }
        ICollection<IUser> Contacts { get; set; }
    }

    public interface IPhoneNumber
    {
         int ID { get; set; }
         string number { get; set; }
         PhoneType Type { get; set; }
    }

    public interface IUserRepository : IDisposable
    {
        IUser CreateUser(IUser userToCreate);
        void DeleteUser(IUser userToDelete);
        IUser EditContact(IUser userToUpdate);
        IUser GetUser(int id);
        IEnumerable<IUser> GetUsers();
    }
}
