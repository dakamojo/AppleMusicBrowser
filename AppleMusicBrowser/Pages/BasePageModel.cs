using System;
using System.ComponentModel;
using PropertyChanged;

namespace AppleMusicBrowser
{
	[ImplementPropertyChanged]
	public abstract class BasePageModel
	{
		private BasePage _page;
		public BasePage Page {
			get {
				if (_page == null) {
					_page = CreatePage ();
					_page.BindingContext = this;
				}
				return _page;
			}
		}

		public abstract BasePage CreatePage ();

	}
}

