namespace SummatorMVC.Controllers
{
    using System.Web.Mvc;
    using SummatorMVC.Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }

        [HttpGet]
        public ActionResult Summator()
        {
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Summator(SummatorViewModel model)
        {
            model.Sum = model.FirstNumber + model.SecondNumber;

            return this.View(model);
        }
    }
}