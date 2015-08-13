using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppleMusicBrowser
{
	public partial class AlbumListPage : BasePage
	{
		private AlbumListPageModel model { get { return (AlbumListPageModel)BindingContext; } }

		public AlbumListPage (AlbumListPageModel model) : base(model) {
			InitializeComponent ();
		}

		private void OnDebugButtonClicked(object sender, EventArgs args) {
		}
	}
}

