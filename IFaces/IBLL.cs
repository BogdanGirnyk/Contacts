using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFaces
{
    public class Result<T>
    {
        public bool success;
        public string message;
        public T ResultData;

    }

    public interface IBLL
    {
        Result<IEnumerable<IUser>> GetAllUsers();
        Result<IUser> GetUser(int ID);
    }
}
