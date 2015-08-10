using Android.OS;
using Android.App;

using Cirrious.MvvmCross.Droid.Views;

using MVVMCrossDemo.Common;

namespace MVVMCrossDemo.Droid
{
	[Activity (Label = "Second Page")]			
	public class SecondActivity : MvxActivity
	{
		public new SecondViewModel ViewModel
		{
			get { return (SecondViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
		}
	}
}