using System;

namespace ParkerSmart.Utilities
{
	public static class ViewUtility
	{
		private const int BASE_COPYRIGHT_YEAR = 2006;

		public static string CopyrightDates()
		{
			string result = BASE_COPYRIGHT_YEAR.ToString();

			if (DateTime.Now.Year != BASE_COPYRIGHT_YEAR)
			{
				result += $"-{DateTime.Now.Year}";
			}

			return result;
		}
	}
}