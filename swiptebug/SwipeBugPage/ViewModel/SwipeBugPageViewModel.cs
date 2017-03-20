using System;
using System.Collections.ObjectModel;

namespace swipebug
{
	public class SwipeBugPageViewModel
	{
		private ObservableCollection<SwipeBugListItem> itemSource = new ObservableCollection<SwipeBugListItem>();

		public SwipeBugPageViewModel ()
		{
			for (var i = 0; i < 30; i++) {
				itemSource.Add (new SwipeBugListItem("Test " + i));
			}
		}

		public ObservableCollection<SwipeBugListItem> ItemSource {
			get {
				return this.itemSource;
			}
			set {
				itemSource = value;
			}
		}
	}
}
