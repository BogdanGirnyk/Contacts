
using System.Web.Mvc;
using System.Linq;


namespace ContactList.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}