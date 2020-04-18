using ParkerSmart.Utilities;
using System.Web.Mvc;

namespace ParkerSmart.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult About()
		{
			Title = nameof(About);

			ControllerUtility.SetTwitterCard(ViewBag);

			return View();
		}

		public ActionResult Contact()
		{
			Title = nameof(Contact);

			ControllerUtility.SetTwitterCard(ViewBag);

			return View();
		}

		public ActionResult Index()
		{
			Title = "Home";

			ControllerUtility.SetTwitterCard(ViewBag);

			return View();
		}

		public ActionResult Play()
		{
			Title = nameof(Play);

			ControllerUtility.SetTwitterCard(ViewBag);

			return View();
		}

		public ActionResult Versions()
		{
			Title = nameof(Versions);

			ControllerUtility.SetTwitterCard(ViewBag);

			return View();
		}

		public ActionResult Work()
		{
			Title = nameof(Work);

			ControllerUtility.SetTwitterCard(ViewBag);

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