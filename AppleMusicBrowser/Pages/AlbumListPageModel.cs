using System;
using System.Collections.ObjectModel;
using PropertyChanged;

namespace AppleMusicBrowser
{
	[ImplementPropertyChanged]
	public class AlbumListPageModel : BasePageModel
	{
		public ObservableCollection<Album> AlbumList { get; set; }

		public AlbumListPageModel ()
		{
			Init ();
		}

		private async void Init() {
			AlbumList = await AppleMusicClient.GetTopAlbumFeed(10);
		}

		public override BasePage CreatePage () {
			return new AlbumListPage (this);
		}
	}
}

