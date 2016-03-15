using MVVMCrossDemo.Common;

using Android.App;

namespace MVVMCrossDemo.Droid
{
	public class Dialog_Droid : IDialog
	{
		public Dialog_Droid ()
		{
		}

		public void ShowMessage (string title, string message)
		{
			var currentActivity = AndroidApp.CurrentActivity;

			var alert = new AlertDialog.Builder (currentActivity);
			alert.SetTitle (title);
			alert.SetMessage (message);
			alert.SetPositiveButton ("OK", (senderAlert, args) => {
			} );

			currentActivity.RunOnUiThread (() => {
				alert.Show ();
			});

			//Toast.MakeText (AndroidApp.GetAppContext (), message, ToastLength.Short).Show ();
		}
	}
}