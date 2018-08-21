using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ZXingSample
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var mainPage = new TabbedPage();
			mainPage.Children.Add(new FullScreenScanning());
			mainPage.Children.Add(new PartialScreenScanning());
			mainPage.Children.Add(new GenerateBarcodePage());

			MainPage = mainPage;
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
