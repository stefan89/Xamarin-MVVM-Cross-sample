using UIKit;
using Foundation;

using MvvmCross.Platform;
using MvvmCross.iOS.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views.Presenters;

namespace MVVMCrossDemo.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : MvxApplicationDelegate 
	{
		UIWindow _window;

		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			_window = new UIWindow(UIScreen.MainScreen.Bounds);

			var presenter = new MvxModalSupportIosViewPresenter(this, _window);
			var setup = new Setup (this, presenter);

			//var setup = new Setup(this, _window);
			setup.Initialize();

			var startup = Mvx.Resolve<IMvxAppStart>();
			startup.Start();

			_window.MakeKeyAndVisible();
			
			return true;
		}
	}
}