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
			albumListView.ItemsSource = model.AlbumList;
		}

		private void OnDebugButtonClicked(object sender, EventArgs args) {
			albumListView.ItemsSource = model.AlbumList;
		}
	}
}

