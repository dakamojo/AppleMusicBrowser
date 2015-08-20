using System;

using Xamarin.Forms;

namespace AppleMusicBrowser
{
	public abstract class BasePage : ContentPage
	{
		public BasePage (BasePageModel model) {
			BindingContext = model;
		}
	}
}


