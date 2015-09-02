using System;
using System.Collections.Generic;
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
			AlbumList = new ObservableCollection<Album> ();
		}

		private async void Init() {
			ObservableCollection<Album> list = await AppleMusicClient.GetTopAlbumFeed(10);

			foreach (Album album in list)
				AlbumList.Add (album);
		}

		public override BasePage CreatePage () {
			return new AlbumListPage (this);
		}
	}
}

