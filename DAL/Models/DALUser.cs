using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFaces;

namespace DAL.Models
{
  public  class DALUser : IUser
    {
        public int ID { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime birthdate { get; set; }
        public byte[] Image { get; set; }
        public ICollection<IPhoneNumber> PhoneNumbers { get; set; }
        public ICollection<IUser> Contacts { get; set; }
    }
}
