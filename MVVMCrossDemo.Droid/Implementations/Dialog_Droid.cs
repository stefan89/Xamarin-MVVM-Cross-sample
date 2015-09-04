using System;

using MVVMCrossDemo.Common;
using Android.App;
using Android.Widget;

namespace MVVMCrossDemo.Droid
{
	public class Dialog_Droid : IDialog
	{
		public Dialog_Droid ()
		{
		}

		public void ShowMessage (string title, string message)
		{
			Toast.MakeText (AndroidApp.GetAppContext (), message, ToastLength.Short).Show ();
		}
	}
}