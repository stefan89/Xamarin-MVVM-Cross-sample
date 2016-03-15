using Android.Content;

using MvvmCross.Platform;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;

using MVVMCrossDemo.Common;

namespace MVVMCrossDemo.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
			Mvx.RegisterType<IDialog, Dialog_Droid> (); //Info: https://github.com/MvvmCross/MvvmCross/wiki/Service-Location-and-Inversion-of-Control

            return new App();
        }
		
        protected override IMvxTrace CreateDebugTrace()
        {
			return new DebugTrace();
        }
    }
}