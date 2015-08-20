using System;

using Xamarin.Forms;

namespace AppleMusicBrowser
{
	public class AlbumListPage : BasePage
	{
		private AlbumListPageModel model {get {return (AlbumListPageModel)BindingContext;}}
		private ListView listView;

		public AlbumListPage (AlbumListPageModel model) : base(model)
		{
			Button debugButton = new Button () {
				Text = "Debug"
			};
			debugButton.Clicked += (object sender, EventArgs e) => {
				int n = model.AlbumList.Count;
//				listView.ItemsSource = model.AlbumList;
			};

			listView = new ListView () {
				ItemsSource = model.AlbumList,
				ItemTemplate = new DataTemplate(typeof(TextCell)),
				Footer = debugButton
			};



			Content = new ScrollView {
				Content = listView 
			};

			listView.ItemTemplate.SetBinding (TextCell.TextProperty, "Name");
			listView.ItemsSource = model.AlbumList;

		}

	}
}


