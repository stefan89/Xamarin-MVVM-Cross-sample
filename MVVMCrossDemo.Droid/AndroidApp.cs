using System;

using Android.App;
using Android.Runtime;

namespace MVVMCrossDemo.Droid
{
	[Application(Label = "MVVM Cross Demo")]
    public class AndroidApp : Application
    {
		static AndroidApp _context;

		public AndroidApp (IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

		public AndroidApp ()
        {
        }

        public override void OnCreate ()
        {
            base.OnCreate();

			_context = this;
        }

		public static AndroidApp GetAppContext()
		{
			return _context;
		}
    }
}