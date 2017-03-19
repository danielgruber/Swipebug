using System;

namespace swipebug
{
	public class SwipeBugListItem
	{
		private String text;

		public SwipeBugListItem (String text)
		{
			this.text = text;
		}

		public string Text {
			get {
				return this.text;
			}
		}
	}
}

