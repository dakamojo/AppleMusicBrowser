using System;

using Xamarin.Forms;

namespace AppleMusicBrowser
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new AlbumListPage(new AlbumListPageModel());
		}
	}
}

