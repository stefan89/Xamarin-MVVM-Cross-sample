using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;

using MVVMCrossDemo.Common;

namespace MVVMCrossDemo.iOS
{
	public partial class ThirdViewController : MvxViewController, IMvxModalTouchView
	{
		public new ThirdViewModel ViewModel {
			get { 
				return base.ViewModel as ThirdViewModel; 
			}
			set { 
				base.ViewModel = value; 
			}
		}

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