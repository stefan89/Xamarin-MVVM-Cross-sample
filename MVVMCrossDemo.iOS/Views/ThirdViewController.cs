using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;

using MVVMCrossDemo.Common;

namespace MVVMCrossDemo.iOS
{
	public partial class ThirdViewController : MvxViewController<ThirdViewModel>, IMvxModalIosView
	{
		public ThirdViewController () : base ("ThirdViewController", null)
		{
			Title = "Third Page";
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var bindingSet = this.CreateBindingSet<ThirdViewController, ThirdViewModel> ();
			bindingSet.Bind (buttonClosePage).To (vm => vm.ClosePageCommand);
			bindingSet.Apply ();
		}
	}
}