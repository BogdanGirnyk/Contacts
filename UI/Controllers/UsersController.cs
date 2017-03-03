using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IFaces;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;


namespace UI.Controllers
{
    public class UsersController : Controller
    {
       
        public ActionResult Index()
        {

            //IUnityContainer container = new UnityContainer();
            //container.LoadConfiguration();
            //var context = container.Resolve<IUserRepository>();
            IBLL BLL = BLLGetter.GetBLL();

            Result <IEnumerable<IUser>> result = BLL.GetAllUsers();
            if (result.success)
            {
                return View(result.ResultData);
            }
            else
            {
                return View("Error",result.message);
            }

            
        }
    }
}