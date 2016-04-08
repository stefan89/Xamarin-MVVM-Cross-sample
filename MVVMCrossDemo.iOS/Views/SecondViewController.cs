using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;

using MVVMCrossDemo.Common;

namespace MVVMCrossDemo.iOS
{
	public partial class SecondViewController : MvxViewController<SecondViewModel>
	{
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