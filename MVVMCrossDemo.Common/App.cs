using MvvmCross.Core.ViewModels;

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
//http://mvvmcross.com/
//https://github.com/MvvmCross
//https://mvvmcross.readme.io/docs/
//https://mvvmcross.wordpress.com