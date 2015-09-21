using Android.App;

using MVVMCrossDemo.Common;

namespace MVVMCrossDemo.Droid
{
	[Activity (Label = "Second Page")]			
	public class SecondActivity : BaseMvxActivity
	{
		public new SecondViewModel ViewModel
		{
			get { return (SecondViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		protected override void OnViewModelSet ()
		{
			base.OnViewModelSet ();

			SetContentView(Resource.Layout.SecondActivity);
		}
	}
}