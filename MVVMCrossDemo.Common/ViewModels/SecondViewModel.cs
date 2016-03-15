using System.Windows.Input;

using MvvmCross.Core.ViewModels;

namespace MVVMCrossDemo.Common
{
	public class SecondViewModel : MvxViewModel
	{
		public ICommand NavigateToThirdPageCommand { 
			get {
				return new MvxCommand (() => {
					ShowViewModel<ThirdViewModel>();
				});
			}
		}

		public SecondViewModel ()
		{
		}
	}
}