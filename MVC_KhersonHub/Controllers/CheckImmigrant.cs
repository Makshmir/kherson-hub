using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Drawing;

namespace MVC_KhersonHub.Controllers
{
    public class CheckImmigrant : Controller
    {
        public IList<Immigrant> ImmigrantList = new List<Immigrant>();

        
        public ActionResult Index()
        {

            Immigrant immigrant = new Immigrant();
            ImmigrantList = immigrant.GetImmigrant();

            ViewBag.Im = ImmigrantList;

            return View();
        }
    }

}
