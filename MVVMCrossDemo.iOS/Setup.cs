using UIKit;

using Cirrious.CrossCore;
using Cirrious.CrossCore.Platform;

using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Touch.Platform;

using MVVMCrossDemo.Common;

namespace MVVMCrossDemo.iOS
{
	public class Setup : MvxTouchSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
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