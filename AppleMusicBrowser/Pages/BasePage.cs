using System;

using Xamarin.Forms;

namespace AppleMusicBrowser
{
	public class BasePage : ContentPage
	{
		public BasePage (BasePageModel model)
		{
			BindingContext = model;
		}
	}
}


