using System;

using Xamarin.Forms;

namespace AppleMusicBrowser
{
	public class App : Application
	{
		public NavigationController NavigationController;

		public App ()
		{
			NavigationController = new NavigationController(new AlbumListPageModel().Page);
			MainPage = NavigationController.NavigationPage;
		}
	}
}

