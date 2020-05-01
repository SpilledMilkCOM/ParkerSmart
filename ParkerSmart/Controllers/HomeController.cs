using ParkerSmart.Models;
using ParkerSmart.Utilities;
using System;
using SysIO = System.IO;			// Because File() is a method off of Controller
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

			SetVersion();
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

		private void SetVersion()
		{
			// "File()" is a method off of the controller.  :(

			var versionFilePath = $"{Server?.MapPath("~")}bin{SysIO.Path.DirectorySeparatorChar}{Constants.APPLICATION_VERSION_FILE}";
			var fileDate = SysIO.File.Exists(versionFilePath) ? SysIO.File.GetLastWriteTime(versionFilePath) : (DateTime?)null;

			ViewUtility.Version(fileDate?.ToString("yyyy.MM.dd"));
		}

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