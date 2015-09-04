using Android.Content;

using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;

using MVVMCrossDemo.Common;
using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore;

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