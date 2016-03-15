using UIKit;

using MvvmCross.Platform;
using MvvmCross.iOS.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.iOS.Views.Presenters;

using MVVMCrossDemo.Common;

namespace MVVMCrossDemo.iOS
{
	public class Setup : MvxIosSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window)
		{
		}

		public Setup(IMvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter) : base(applicationDelegate, presenter)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			Mvx.RegisterType<IDialog, Dialog_iOS> (); //Info: https://github.com/MvvmCross/MvvmCross/wiki/Service-Location-and-Inversion-of-Control

			return new App();
		}
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
	}
}