using System.Windows.Input;

using MvvmCross.Core.ViewModels;

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