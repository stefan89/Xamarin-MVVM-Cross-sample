using System.Windows.Input;

using Cirrious.MvvmCross.ViewModels;

namespace MVVMCrossDemo.Common
{
	public class ThirdViewModel : MvxViewModel
	{
		public ICommand ClosePageCommand { 
			get {
				return new MvxCommand (() => {
					Close (this);
				});
			}
		}

		public ThirdViewModel ()
		{
		}
	}
}