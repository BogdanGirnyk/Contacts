using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Data.Entity;
    using System.Text;
    using IFaces;
    using Models;


        public class ContactsContext : DbContext,IUserRepository
        {
            public ContactsContext() : base("ContactsContext")
            { }

            public DbSet<DALUser> users { get; set; }

            public IUser CreateUser(IUser userToCreate)
            {
                throw new NotImplementedException();
            }

            public void DeleteUser(IUser userToDelete)
            {
                throw new NotImplementedException();
            }

            public IUser EditContact(IUser userToUpdate)
            {
                throw new NotImplementedException();
            }

            public IUser GetUser(int id)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<IUser> GetUsers()
            {
                return  users.ToList<IUser>();
            }
        }

    
}
