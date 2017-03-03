using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class UserViewModel
    {
        int ID { get; set; }
        string email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime birthdate { get; set; }
    }
}
