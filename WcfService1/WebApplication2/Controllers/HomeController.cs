namespace WebApplication2.Controllers
{
    using System.Web.Mvc;
    using Newtonsoft.Json;
    using ServiceReference1;
    public class HomeController : Controller
    {
        private Service1Client client;
        public HomeController()
        {
            client = new Service1Client();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public string Submit(string trainee)
        {
            var traineeInfo = JsonConvert.DeserializeObject<Trainee>(trainee);               
            var name = client.PostTrainee(traineeInfo);
            return name;
        }
    }
}