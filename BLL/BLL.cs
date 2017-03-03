using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFaces;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace BLL
{
    public class BLL : IBLL
    {


        private IUserRepository GetRepository()
        {
            return new UnityContainer().LoadConfiguration().Resolve<IUserRepository>();
        }

        public Result<IUser> GetUser(int ID)
        {
            Result<IUser> result = new Result<IUser>();
            using (IUserRepository repository = GetRepository())
            {
                try
                {
                    result.ResultData = repository.GetUser(ID);
                    result.success = true;
                }
                catch (Exception ex)
                {
                    result.success = false;
                    result.message = ex.Message;
                }
            }
            return result;
        }

        public Result<IEnumerable<IUser>> GetAllUsers()
        {
            using (IUserRepository repository = GetRepository())
            {
                Result<IEnumerable<IUser>> result = new Result<IEnumerable<IUser>>();

                try
                {
                    result.ResultData = repository.GetUsers();
                    result.success = true;
                }
                catch (Exception ex)
                {
                    result.success = false;
                    result.message = ex.Message;
                }

                return result;
            }
        }
    }
}
