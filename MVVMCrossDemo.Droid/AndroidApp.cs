using System;

using Android.App;
using Android.Runtime;

namespace MVVMCrossDemo.Droid
{
	[Application(Label = "MVVM Cross Demo")]
    public class AndroidApp : Application
    {
		public static Activity CurrentActivity;

		public AndroidApp (IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

		public AndroidApp ()
        {
        }

        public override void OnCreate ()
        {
            base.OnCreate();
        }
    }
}