using Cirrious.MvvmCross.ViewModels;

using MVVMLightDemo.Common;
using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore;

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