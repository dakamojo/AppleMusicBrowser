using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppleMusicBrowser
{
	public static class AppleMusicClient
	{
		public static async Task<ObservableCollection<Album>> GetTopAlbumFeed(int limit) {
//			Url url = new Url ("https://itunes.apple.com/us/rss/topalbums/json");
//			var data = await url.GetJsonAsync ();

			Assembly assembly = typeof(AppleMusicClient).GetTypeInfo().Assembly;
			Stream stream = assembly.GetManifestResourceStream("AppleMusicBrowser.Models.SampleAlbumData.json");
			StreamReader reader = new StreamReader (stream);

			ObservableCollection<Album> albumList = await JsonConvert.DeserializeObjectAsync<ObservableCollection<Album>> (reader.ReadToEnd ());

			return albumList;
		}

	}
}

