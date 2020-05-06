using ParkerSmart.Models;

namespace ParkerSmart.Utilities
{
	public static class ControllerUtility
	{
		public static bool HasHttpPrefix(string url)
		{
			// Probably should use RegEx.

			return url != null && (url.StartsWith("http://") || url.StartsWith("https://"));
		}

		/// <summary>
		/// Initialize the ViewBag with the Twitter Card "meta" tag info.
		/// NOTE: This code was borrowed from MooVee Picker
		/// </summary>
		/// <param name="viewBag">The view's ViewBag property</param>
		/// <param name="card">The card type defined by Twitter "summary", "app", "player"</param>
		/// <param name="title">The card title</param>
		/// <param name="description">The descriptive text for the card</param>
		/// <param name="imageUrl">The url of the image</param>
		/// <param name="imageUrlAlt">Descriptive text of the image for the visuall impared</param>
		public static void SetTwitterCard(dynamic viewBag, string card = null, string title = null, string description = null, string imageUrl = null, string imageUrlAlt = null, string tweetText = null)
		{
			if (viewBag != null)
			{
				viewBag.TwitterCard = card ?? "summary";
				viewBag.TwitterCreatorId = Constants.TWITTER_CREATOR_ID;
				viewBag.TwitterId = Constants.TWITTER_ID;
				viewBag.TwitterTitle = title ?? Constants.TWITTER_TITLE;
				viewBag.TwitterDescription = description ?? "Basically... My online resumé. It's a work in progress. (May contain awesome)";
				viewBag.TwitterTweetText = tweetText ?? viewBag.TwitterTitle;

				if (!string.IsNullOrEmpty(imageUrl))
				{
					if (imageUrl.Substring(0, 1) == "~")
					{
						imageUrl = imageUrl.Replace("~", Constants.WEBSITE_URL);
					}
					else if (!HasHttpPrefix(imageUrl))
					{
						imageUrl = $"{Constants.WEBSITE_URL}/{imageUrl}";
					}

					imageUrl = imageUrl.Replace(" ", "%20");
				}
				else
				{
					imageUrl = $"{Constants.WEBSITE_URL}/Images/TwitterSummaryCard.png";
				}

				viewBag.TwitterImage = imageUrl;
				viewBag.TwitterImageAlt = imageUrlAlt ?? "May contain awesome. A preview of Parker Smart's resumé site.";
				viewBag.OpenGraphImage = imageUrl.Replace(".png", "OG.png");
				viewBag.OpenGraphUrl = Constants.WEBSITE_URL;
				viewBag.OpenGraphSiteName = Constants.APPLICATION_NAME;
			}
		}
	}
}