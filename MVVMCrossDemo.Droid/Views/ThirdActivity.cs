using Android.App;

using MVVMCrossDemo.Common;

namespace MVVMCrossDemo.Droid
{
	[Activity (Label = "Third page")]			
	public class ThirdActivity : BaseMvxActivity
	{
		public new ThirdViewModel ViewModel
		{
			get { return (ThirdViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}
	}
}