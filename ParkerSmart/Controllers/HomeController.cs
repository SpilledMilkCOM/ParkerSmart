using System.Web.Mvc;

namespace ParkerSmart.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult About()
		{
			Title = nameof(About);

			return View();
		}

		public ActionResult Contact()
		{
			Title = nameof(Contact);

			return View();
		}

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Versions()
		{
			Title = nameof(Versions);

			return View();
		}

		public ActionResult Work()
		{
			Title = nameof(Work);

			return View();
		}

		//----==== PRIVATE ====--------------------------------------------------------------------

		private string Title
		{
			get { return ViewBag.Title; }
			set { ViewBag.Title = value; }
		}
	}
}