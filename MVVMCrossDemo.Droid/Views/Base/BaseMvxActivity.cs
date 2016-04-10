using System;

using MvvmCross.Droid.Views;

namespace MVVMCrossDemo.Droid
{
	public class BaseMvxActivity : MvxActivity
	{
		public BaseMvxActivity ()
		{
		}

		protected override void OnResume ()
		{
			base.OnResume ();

			AndroidApp.CurrentActivity = this;
		}

		protected override void OnDestroy ()
		{
			base.OnDestroy ();

			GC.Collect ();
		}
	}
}