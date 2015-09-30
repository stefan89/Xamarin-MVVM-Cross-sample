using Cirrious.MvvmCross.ViewModels;

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
//Tutorials: https://mvvmcross.wordpress.com
//Documentation: https://github.com/MvvmCross/MvvmCross