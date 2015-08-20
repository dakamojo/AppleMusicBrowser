using System;
using Xamarin.Forms;

namespace AppleMusicBrowser
{
	public class NavigationController
	{
		public NavigationPage NavigationPage;

		public NavigationController (BasePage rootPage) {
			NavigationPage = new NavigationPage (rootPage);
		}

	}
}

