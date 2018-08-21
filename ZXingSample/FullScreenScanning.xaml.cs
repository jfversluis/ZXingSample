using Xamarin.Forms;
using ZXing;
using ZXing.Net.Mobile.Forms;

namespace ZXingSample
{
	public partial class FullScreenScanning : ZXingScannerPage
	{
		public FullScreenScanning()
		{
			InitializeComponent();
		}

		public void Handle_OnScanResult(Result result)
		{
			Device.BeginInvokeOnMainThread(async () =>
			{
				await DisplayAlert("Scanned result", result.Text, "OK");
			});
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			IsScanning = true;
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();

			IsScanning = false;
		}
	}
}