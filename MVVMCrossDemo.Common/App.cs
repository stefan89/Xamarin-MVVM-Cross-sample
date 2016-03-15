using MvvmCross.Core.ViewModels;

using MVVMLightDemo.Common;

namespace MVVMCrossDemo.Common
{
	public class App : MvxApplication
	{
		public App ()
		{
			RegisterAppStart<TodoItemsViewModel>();
		}
	}
}
//Documentation: 
//https://github.com/MvvmCross
//https://mvvmcross.readme.io/docs/
//https://mvvmcross.wordpress.com