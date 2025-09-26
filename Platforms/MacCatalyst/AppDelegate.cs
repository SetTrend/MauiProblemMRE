using Foundation;

using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace FirstApp
{
	[Register("AppDelegate")]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	}
}
