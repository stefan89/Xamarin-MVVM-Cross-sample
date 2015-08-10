using Cirrious.MvvmCross.Touch.Views;

using MVVMCrossDemo.Common;

namespace MVVMCrossDemo.iOS
{
	public partial class SecondViewController : MvxViewController
	{
		public new SecondViewModel ViewModel {
			get { 
				return base.ViewModel as SecondViewModel; 
			}
			set { 
				base.ViewModel = value; 
			}
		}

		public SecondViewController () : base ("SecondViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.Title = "Second Page";
		}
	}
}