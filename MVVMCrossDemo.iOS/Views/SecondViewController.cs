using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;

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
			Title = "Second Page";
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var bindingSet = this.CreateBindingSet<SecondViewController, SecondViewModel> ();
			bindingSet.Bind (buttonNavigateToThirdPage).To (vm => vm.NavigateToThirdPageCommand);
			bindingSet.Apply ();
		}
	}
}