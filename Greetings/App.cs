﻿using System;

using Xamarin.Forms;

namespace Greetings
{
	public class App : Application
	{
		public App()
		{
			var bs = new Bootstrapper();
			bs.Run(this);
		}

		private void UpdateTitle(object sender, EventArgs e)
		{
			
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

