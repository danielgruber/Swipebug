using System;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms;

namespace swipebug
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new NavigationPage(new SwipeBugPage());
		}

		protected override void OnStart ()
		{
			MobileCenter.Start ("ios=b87149bf-c293-4d25-85c1-6e0eef006087;" +
				   "android={Your Android App secret here}",
				   typeof (Analytics), typeof (Crashes));
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

