using Xamarin.Forms;
using ZXing;
using ZXing.Net.Mobile.Forms;

namespace ZXingSample
{
	public partial class PartialScreenScanning : ContentPage
	{
		public PartialScreenScanning()
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

			_scanView.IsScanning = true;
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();

			_scanView.IsScanning = false;
		}
	}
}