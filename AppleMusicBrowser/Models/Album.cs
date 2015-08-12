using System;
using System.Collections.Generic;
using PropertyChanged;

namespace AppleMusicBrowser
{
	[ImplementPropertyChanged]
	public class Album
	{
		public string Name { get; set; }
		public Artist Artist { get; set; }
	}

	[ImplementPropertyChanged]
	public class Artist
	{
		public string Name { get; set; }
		public string Rights { get; set; }
	}
}

