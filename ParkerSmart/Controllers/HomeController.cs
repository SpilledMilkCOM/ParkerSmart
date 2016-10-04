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
			Title = "Home";

			return View();
		}

		public ActionResult Play()
		{
			Title = nameof(Play);

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

		/// <summary>
		/// The Title used on each page.
		/// </summary>
		private string Title
		{
			get { return ViewBag.Title; }
			set { ViewBag.Title = value; }
		}
	}
}